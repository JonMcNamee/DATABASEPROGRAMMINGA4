namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabEmp = new System.Windows.Forms.TabControl();
            this.tabView = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.bdnDataGrid = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.tabRevise = new System.Windows.Forms.TabPage();
            this.grpTitles = new System.Windows.Forms.GroupBox();
            this.lstEmpNo = new System.Windows.Forms.ListBox();
            this.btnDeleteTitle = new System.Windows.Forms.Button();
            this.lstTitles = new System.Windows.Forms.ListBox();
            this.grpDept = new System.Windows.Forms.GroupBox();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDept = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRemoveTitle = new System.Windows.Forms.RadioButton();
            this.radDept = new System.Windows.Forms.RadioButton();
            this.tabEmp.SuspendLayout();
            this.tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnDataGrid)).BeginInit();
            this.bdnDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.tabRevise.SuspendLayout();
            this.grpTitles.SuspendLayout();
            this.grpDept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDept)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmp
            // 
            this.tabEmp.Controls.Add(this.tabView);
            this.tabEmp.Controls.Add(this.tabRevise);
            this.tabEmp.Location = new System.Drawing.Point(12, 12);
            this.tabEmp.Name = "tabEmp";
            this.tabEmp.SelectedIndex = 0;
            this.tabEmp.Size = new System.Drawing.Size(737, 508);
            this.tabEmp.TabIndex = 1;
            // 
            // tabView
            // 
            this.tabView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabView.Controls.Add(this.label4);
            this.tabView.Controls.Add(this.label3);
            this.tabView.Controls.Add(this.dtpEndDate);
            this.tabView.Controls.Add(this.dtpStartDate);
            this.tabView.Controls.Add(this.label2);
            this.tabView.Controls.Add(this.cboSearch);
            this.tabView.Controls.Add(this.bdnDataGrid);
            this.tabView.Controls.Add(this.label1);
            this.tabView.Controls.Add(this.dgvResults);
            this.tabView.Controls.Add(this.lstTables);
            this.tabView.Location = new System.Drawing.Point(4, 26);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(729, 478);
            this.tabView.TabIndex = 0;
            this.tabView.Text = "View";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "End Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(479, 109);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(114, 24);
            this.dtpEndDate.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(479, 65);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(114, 24);
            this.dtpStartDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search for ... \r\n(Select a Search)";
            // 
            // cboSearch
            // 
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "Average Salaries",
            "Hired Between..."});
            this.cboSearch.Location = new System.Drawing.Point(218, 76);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(120, 25);
            this.cboSearch.TabIndex = 4;
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.cboSearch_SelectedIndexChanged);
            // 
            // bdnDataGrid
            // 
            this.bdnDataGrid.AddNewItem = null;
            this.bdnDataGrid.CountItem = this.bindingNavigatorCountItem;
            this.bdnDataGrid.DeleteItem = null;
            this.bdnDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bdnDataGrid.Location = new System.Drawing.Point(3, 3);
            this.bdnDataGrid.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnDataGrid.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnDataGrid.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnDataGrid.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnDataGrid.Name = "bdnDataGrid";
            this.bdnDataGrid.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnDataGrid.Size = new System.Drawing.Size(637, 25);
            this.bdnDataGrid.TabIndex = 3;
            this.bdnDataGrid.Text = "bindingNavigator1";
            this.bdnDataGrid.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Show all data from... \r\n(Select a Table)";
            // 
            // dgvResults
            // 
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(10, 192);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(713, 268);
            this.dgvResults.TabIndex = 1;
            // 
            // lstTables
            // 
            this.lstTables.FormattingEnabled = true;
            this.lstTables.ItemHeight = 17;
            this.lstTables.Location = new System.Drawing.Point(10, 76);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(120, 106);
            this.lstTables.TabIndex = 0;
            this.lstTables.SelectedIndexChanged += new System.EventHandler(this.lstTables_SelectedIndexChanged);
            // 
            // tabRevise
            // 
            this.tabRevise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabRevise.Controls.Add(this.grpTitles);
            this.tabRevise.Controls.Add(this.grpDept);
            this.tabRevise.Controls.Add(this.groupBox1);
            this.tabRevise.Location = new System.Drawing.Point(4, 26);
            this.tabRevise.Name = "tabRevise";
            this.tabRevise.Padding = new System.Windows.Forms.Padding(3);
            this.tabRevise.Size = new System.Drawing.Size(729, 478);
            this.tabRevise.TabIndex = 1;
            this.tabRevise.Text = "Revise";
            // 
            // grpTitles
            // 
            this.grpTitles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpTitles.Controls.Add(this.lstEmpNo);
            this.grpTitles.Controls.Add(this.btnDeleteTitle);
            this.grpTitles.Controls.Add(this.lstTitles);
            this.grpTitles.Location = new System.Drawing.Point(402, 84);
            this.grpTitles.Name = "grpTitles";
            this.grpTitles.Size = new System.Drawing.Size(321, 229);
            this.grpTitles.TabIndex = 2;
            this.grpTitles.TabStop = false;
            this.grpTitles.Text = "Select Title and Employee Number";
            // 
            // lstEmpNo
            // 
            this.lstEmpNo.FormattingEnabled = true;
            this.lstEmpNo.ItemHeight = 17;
            this.lstEmpNo.Location = new System.Drawing.Point(164, 19);
            this.lstEmpNo.Name = "lstEmpNo";
            this.lstEmpNo.Size = new System.Drawing.Size(135, 191);
            this.lstEmpNo.TabIndex = 1;
            // 
            // btnDeleteTitle
            // 
            this.btnDeleteTitle.Location = new System.Drawing.Point(13, 157);
            this.btnDeleteTitle.Name = "btnDeleteTitle";
            this.btnDeleteTitle.Size = new System.Drawing.Size(114, 55);
            this.btnDeleteTitle.TabIndex = 2;
            this.btnDeleteTitle.Text = "&Delete\r\n Title";
            this.btnDeleteTitle.UseVisualStyleBackColor = true;
            this.btnDeleteTitle.Click += new System.EventHandler(this.btnDeleteTitle_Click);
            // 
            // lstTitles
            // 
            this.lstTitles.FormattingEnabled = true;
            this.lstTitles.ItemHeight = 17;
            this.lstTitles.Location = new System.Drawing.Point(6, 19);
            this.lstTitles.Name = "lstTitles";
            this.lstTitles.Size = new System.Drawing.Size(134, 106);
            this.lstTitles.TabIndex = 0;
            this.lstTitles.SelectedIndexChanged += new System.EventHandler(this.lstTitles_SelectedIndexChanged);
            // 
            // grpDept
            // 
            this.grpDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpDept.Controls.Add(this.btnAddDept);
            this.grpDept.Controls.Add(this.txtDept);
            this.grpDept.Controls.Add(this.label6);
            this.grpDept.Controls.Add(this.nudDept);
            this.grpDept.Controls.Add(this.label5);
            this.grpDept.Location = new System.Drawing.Point(6, 84);
            this.grpDept.Name = "grpDept";
            this.grpDept.Size = new System.Drawing.Size(390, 229);
            this.grpDept.TabIndex = 1;
            this.grpDept.TabStop = false;
            this.grpDept.Text = "New Department";
            // 
            // btnAddDept
            // 
            this.btnAddDept.Location = new System.Drawing.Point(131, 157);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(114, 55);
            this.btnAddDept.TabIndex = 2;
            this.btnAddDept.Text = "&Add Department";
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(10, 101);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(374, 24);
            this.txtDept.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Department Name: (maximum 40 characters)";
            // 
            // nudDept
            // 
            this.nudDept.Location = new System.Drawing.Point(225, 33);
            this.nudDept.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudDept.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDept.Name = "nudDept";
            this.nudDept.Size = new System.Drawing.Size(83, 24);
            this.nudDept.TabIndex = 0;
            this.nudDept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDept.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Department Number:  d0 +";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.radRemoveTitle);
            this.groupBox1.Controls.Add(this.radDept);
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change";
            // 
            // radRemoveTitle
            // 
            this.radRemoveTitle.AutoSize = true;
            this.radRemoveTitle.Location = new System.Drawing.Point(529, 24);
            this.radRemoveTitle.Name = "radRemoveTitle";
            this.radRemoveTitle.Size = new System.Drawing.Size(112, 21);
            this.radRemoveTitle.TabIndex = 1;
            this.radRemoveTitle.Text = "Remove a Title";
            this.radRemoveTitle.UseVisualStyleBackColor = true;
            // 
            // radDept
            // 
            this.radDept.AutoSize = true;
            this.radDept.Checked = true;
            this.radDept.Location = new System.Drawing.Point(23, 24);
            this.radDept.Name = "radDept";
            this.radDept.Size = new System.Drawing.Size(135, 21);
            this.radDept.TabIndex = 0;
            this.radDept.TabStop = true;
            this.radDept.Text = "Add a Department";
            this.radDept.UseVisualStyleBackColor = true;
            this.radDept.CheckedChanged += new System.EventHandler(this.radDept_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 542);
            this.Controls.Add(this.tabEmp);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Connect by Jon McNamee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabEmp.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tabView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnDataGrid)).EndInit();
            this.bdnDataGrid.ResumeLayout(false);
            this.bdnDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.tabRevise.ResumeLayout(false);
            this.grpTitles.ResumeLayout(false);
            this.grpDept.ResumeLayout(false);
            this.grpDept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDept)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmp;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.BindingNavigator bdnDataGrid;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.TabPage tabRevise;
        private System.Windows.Forms.GroupBox grpTitles;
        private System.Windows.Forms.ListBox lstEmpNo;
        private System.Windows.Forms.Button btnDeleteTitle;
        private System.Windows.Forms.ListBox lstTitles;
        private System.Windows.Forms.GroupBox grpDept;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRemoveTitle;
        private System.Windows.Forms.RadioButton radDept;
    }
}

