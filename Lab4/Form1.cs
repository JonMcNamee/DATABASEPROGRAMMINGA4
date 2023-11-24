using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //handles all MySql classes
using System.Configuration; //for app.config having connection string
using System.IO; //for files
using System.Data.SqlClient;

namespace Lab4
{
    /*
        Jon McNamee
        Lab 4
        5 June 2023
    */
    //In Connection String I attempted to use account cathy with pswd cathy, but mySQL rejected the password for being too weak.
    public partial class Form1 : Form
    {
        private StreamWriter McNameeLog = new StreamWriter("McNameeLog.txt");
        static string connStr = ConfigurationManager.ConnectionStrings["empdb"].ConnectionString;
        MySqlConnection conn = new MySqlConnection(connStr);

        public Form1()
        {
            InitializeComponent();
            WriteLog();
            conn.Open();
            SetupDatabase();
            DropFamily();
            PopulateList();
            SetDates();
            GetTitles();
            FixDates();
            grpTitles.Enabled = false;
        }
        //method to set up database, nothing sent or returned
        private void SetupDatabase()
        {
            try
            {
                string script = File.ReadAllText("emp.sql");
                MySqlCommand comm = new MySqlCommand(script, conn);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error");
            }
        }
        //method to drop family table from db, nothing sent or returned
        private void DropFamily()
        {
            try
            {
                string tableName = "families";
                string dropFamilies = $"DROP TABLE IF EXISTS {tableName}";
                LogCommand(dropFamilies);
                MySqlCommand comm = new MySqlCommand(dropFamilies, conn);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error");
            }

        }
        //method to populate table listbox, nothing sent or returned
        private void PopulateList()
        {
            lstTables.Items.Clear();

            string showTables = "SHOW TABLES";
            LogCommand(showTables);
            MySqlCommand comm = new MySqlCommand(showTables, conn);

            try
            {
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    string tableName = reader.GetString(0);
                    lstTables.Items.Add(tableName);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error");
            }
        }
        //method to set start and end dates, nothing sent or returned
        private void SetDates()
        {
            string startDate = "SELECT MIN(hire_date) FROM employees";
            LogCommand(startDate);
            string endDate = "SELECT MAX(hire_date) FROM employees";
            LogCommand(endDate);

            MySqlCommand startComm = new MySqlCommand(startDate, conn);
            MySqlCommand endComm = new MySqlCommand(endDate, conn);

            try
            {
                DateTime startRes = (DateTime)startComm.ExecuteScalar();
                DateTime endRes = (DateTime)endComm.ExecuteScalar();

                dtpStartDate.Value = startRes;
                dtpEndDate.Value = endRes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error");
            }
        }
        //method to populate titles listbox, nothing sent or returned
        private void GetTitles()
        {
            lstTitles.Items.Clear();

            string selectTitles = "SELECT DISTINCT title FROM titles ORDER BY title";
            LogCommand(selectTitles);
            MySqlCommand comm = new MySqlCommand(selectTitles, conn);

            try
            {
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    string title = reader.GetString(0);
                    lstTitles.Items.Add(title);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error");
            }

        }
        //method to fix invalid to_date entries
        private void FixDates()
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            string updateDeptEmpQuery = $"UPDATE dept_emp SET to_date = '{currentDate}' WHERE to_date > '{currentDate}'";
            LogCommand(updateDeptEmpQuery);
            string updateDeptManagerQuery = $"UPDATE dept_manager SET to_date = '{currentDate}' WHERE to_date > '{currentDate}'";
            LogCommand(updateDeptManagerQuery);
            string updateSalariesQuery = $"UPDATE salaries SET to_date = '{currentDate}' WHERE to_date > '{currentDate}'";
            LogCommand(updateSalariesQuery);
            string updateTitlesQuery = $"UPDATE titles SET to_date = '{currentDate}' WHERE to_date > '{currentDate}'";
            LogCommand(updateTitlesQuery);
            try
            {
                MySqlCommand updateDeptEmpCommand = new MySqlCommand(updateDeptEmpQuery, conn);
                MySqlCommand updateDeptManagerCommand = new MySqlCommand(updateDeptManagerQuery, conn);
                MySqlCommand updateSalariesCommand = new MySqlCommand(updateSalariesQuery, conn);
                MySqlCommand updateTitlesCommand = new MySqlCommand(updateTitlesQuery, conn);

                updateDeptEmpCommand.ExecuteNonQuery();
                updateDeptManagerCommand.ExecuteNonQuery();
                updateSalariesCommand.ExecuteNonQuery();
                updateTitlesCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error");
            }
        }
        //displays table data based on listbox selection
        private void lstTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstTables.SelectedIndex > -1)
            {
                cboSearch.SelectedIndex = -1;

                string selectedTable = lstTables.SelectedItem.ToString();
                string query = $"SELECT * FROM {selectedTable}";
                LogCommand(query);
                try
                {
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dataTable);
                    }
                    //create bindingsource
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    //fills dgv with table info
                    dgvResults.DataSource = dataTable;
                    //set binding nav to binding source
                    BindingNavigator bindingNavigator = new BindingNavigator();
                    bindingNavigator.BindingSource = bindingSource;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Data Error");
                }

            }
        }
        //when combobox selection is made, runs query based on selection to filter dgv results
        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSearch.SelectedIndex > -1)
            {
                lstTables.ClearSelected();
                //displays average salaries for employees
                if (cboSearch.SelectedIndex == 0)
                {
                    string query =
                       "SELECT e.emp_no, CONCAT(e.last_name, ', ', e.first_name) AS Name, FORMAT(AVG(s.salary), 2) AS 'Avg Salary' " +
                       "FROM employees e " +
                       "JOIN salaries s ON e.emp_no = s.emp_no " +
                       "GROUP BY e.emp_no, e.first_name, e.last_name " +
                       "ORDER BY e.last_name ASC";
                    LogCommand(query);
                    try
                    {
                        DataTable dataTable = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                        adapter.Fill(dataTable);
                        dgvResults.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Data Error");
                    }
                }
                //queries employees where the hire date is between the chosen dates on form
                else if (cboSearch.SelectedIndex == 1)
                {
                    DateTime startDate = dtpStartDate.Value;
                    DateTime endDate = dtpEndDate.Value;

                    string query = 
                       $"SELECT emp_no, first_name, last_name, hire_date " +
                       $"FROM employees " +
                       $"WHERE hire_date >= '{startDate.ToString("yyyy-MM-dd")}' AND hire_date <= '{endDate.ToString("yyyy-MM-dd")}' " +
                       $"ORDER BY hire_date ASC";
                    LogCommand(query);
                    try
                    {
                        DataTable dataTable = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                        adapter.Fill(dataTable);
                        dgvResults.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Data Error");
                    }
                }
            }
        }
        //enables relevant groupbox based on rad button checked
        private void radDept_CheckedChanged(object sender, EventArgs e)
        {
            if (radDept.Checked)
            {
                grpDept.Enabled = true;
                grpTitles.Enabled = false;
                lstTitles.SelectedIndex = -1;
                lstEmpNo.Items.Clear();
            }
            else
            {
                grpTitles.Enabled = true;
                grpDept.Enabled= false;
            }
        }
        //checks correct format in textbox and creates new dept for database
        private void btnAddDept_Click(object sender, EventArgs e)
        {
            string deptNum = "d0" + nudDept.Value.ToString();
            string deptName = txtDept.Text;
            if (deptName.Length < 5)
                MessageBox.Show("Department name must be at least 5 characters", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if(deptName.Length >= 5)
            {
                DialogResult confirmAdd = MessageBox.Show("Are you sure you want to add a new department?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmAdd != DialogResult.Yes)
                    return;
                string query = $"INSERT INTO departments (dept_no, dept_name) VALUES ('{deptNum}', '{deptName}')";
                LogCommand(query);
                try
                {
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Confirmation: 1 record(s) added", "Addition Completed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //when title is selected, populated listbox with emp nums that have said title
        private void lstTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEmpNo();
        }
        //confirms deletion command with message box, then removes title from selected emp
        private void btnDeleteTitle_Click(object sender, EventArgs e)
        {
            if(lstTitles.SelectedIndex > -1 && lstEmpNo.SelectedIndex > -1)
            {
                string selectedTitle = lstTitles.SelectedItem.ToString();
                string selectedEmpNo = lstEmpNo.SelectedItem.ToString();

                DialogResult confirmDel = MessageBox.Show("Are you sure you want to delete based on the employee number and title selected?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmDel != DialogResult.Yes)
                    return;
                string query = $"DELETE FROM titles WHERE emp_no = '{selectedEmpNo}' AND title = '{selectedTitle}'";
                LogCommand(query);
                try
                {
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Confirmation: 1 record(s) deleted", "Deletion Completed");
                    GetEmpNo();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an employee number", "Selection Needed");
            }
        }
        //method to populate lstEmpNo, nothing sent or returned. Did it this way 
        private void GetEmpNo()
        {
            if (lstTitles.SelectedIndex > -1)
            {
                lstEmpNo.Items.Clear();

                string selectedTitle = lstTitles.SelectedItem.ToString();
                string query = $"SELECT emp_no FROM titles WHERE title = '{selectedTitle}'";
                LogCommand(query);
                try
                {
                    //runs query to get all emp_no with matching title and populate lstEmpNo
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    MySqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        lstEmpNo.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //method to begin writing log text file with name and date
        private void WriteLog()
        {
            McNameeLog.WriteLine("Command: Jon McNamee");
            McNameeLog.WriteLine($"Command: {DateTime.Now.ToString()}");
        }
        //method to log each sql query that is used. Sent query string to add to log file, returns nothing
        private void LogCommand(string query)
        {
            McNameeLog.WriteLine($"Command: {query}");
        }
        //closes connections when form closing begins
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            McNameeLog.Close();
        }
    }
}
