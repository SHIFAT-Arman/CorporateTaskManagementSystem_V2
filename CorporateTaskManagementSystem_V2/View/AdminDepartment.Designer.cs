namespace CorporateTaskManagementSystem_V2.View
{
    partial class AdminDepartment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.deptNameTextBox = new System.Windows.Forms.TextBox();
            this.deptNameLabel = new System.Windows.Forms.Label();
            this.deptIdTB = new System.Windows.Forms.TextBox();
            this.deptIdLabel = new System.Windows.Forms.Label();
            this.deptCreationDate = new System.Windows.Forms.Label();
            this.deptCreationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(1103, 276);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(89, 32);
            this.RefreshBtn.TabIndex = 54;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(519, 275);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(89, 32);
            this.SearchBtn.TabIndex = 52;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(240, 277);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(89, 32);
            this.DeleteBtn.TabIndex = 51;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(145, 277);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(89, 32);
            this.UpdateBtn.TabIndex = 50;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(50, 277);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(89, 32);
            this.AddBtn.TabIndex = 49;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.ForeColor = System.Drawing.Color.Silver;
            this.SearchTextBox.Location = new System.Drawing.Point(624, 276);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(387, 32);
            this.SearchTextBox.TabIndex = 53;
            this.SearchTextBox.Text = "Search Department by Name";
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // DepartmentDataGridView
            // 
            this.DepartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentDataGridView.Location = new System.Drawing.Point(3, 315);
            this.DepartmentDataGridView.Name = "DepartmentDataGridView";
            this.DepartmentDataGridView.ReadOnly = true;
            this.DepartmentDataGridView.RowHeadersWidth = 51;
            this.DepartmentDataGridView.RowTemplate.Height = 24;
            this.DepartmentDataGridView.Size = new System.Drawing.Size(1201, 559);
            this.DepartmentDataGridView.TabIndex = 48;
            this.DepartmentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepartmentDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 36);
            this.label1.TabIndex = 55;
            this.label1.Text = "Departments";
            // 
            // deptNameTextBox
            // 
            this.deptNameTextBox.Location = new System.Drawing.Point(437, 141);
            this.deptNameTextBox.Name = "deptNameTextBox";
            this.deptNameTextBox.Size = new System.Drawing.Size(274, 32);
            this.deptNameTextBox.TabIndex = 57;
            this.deptNameTextBox.Enter += new System.EventHandler(this.deptNameTextBox_Enter);
            // 
            // deptNameLabel
            // 
            this.deptNameLabel.AutoSize = true;
            this.deptNameLabel.Location = new System.Drawing.Point(432, 113);
            this.deptNameLabel.Name = "deptNameLabel";
            this.deptNameLabel.Size = new System.Drawing.Size(176, 24);
            this.deptNameLabel.TabIndex = 56;
            this.deptNameLabel.Text = "Department Name";
            // 
            // deptIdTB
            // 
            this.deptIdTB.Enabled = false;
            this.deptIdTB.Location = new System.Drawing.Point(63, 141);
            this.deptIdTB.Name = "deptIdTB";
            this.deptIdTB.Size = new System.Drawing.Size(274, 32);
            this.deptIdTB.TabIndex = 59;
            // 
            // deptIdLabel
            // 
            this.deptIdLabel.AutoSize = true;
            this.deptIdLabel.Location = new System.Drawing.Point(58, 113);
            this.deptIdLabel.Name = "deptIdLabel";
            this.deptIdLabel.Size = new System.Drawing.Size(142, 24);
            this.deptIdLabel.TabIndex = 58;
            this.deptIdLabel.Text = "Department ID";
            // 
            // deptCreationDate
            // 
            this.deptCreationDate.AutoSize = true;
            this.deptCreationDate.Location = new System.Drawing.Point(826, 113);
            this.deptCreationDate.Name = "deptCreationDate";
            this.deptCreationDate.Size = new System.Drawing.Size(134, 24);
            this.deptCreationDate.TabIndex = 61;
            this.deptCreationDate.Text = "Creation Date";
            // 
            // deptCreationDateTimePicker
            // 
            this.deptCreationDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deptCreationDateTimePicker.Location = new System.Drawing.Point(831, 141);
            this.deptCreationDateTimePicker.MaxDate = new System.DateTime(2030, 12, 25, 23, 59, 59, 0);
            this.deptCreationDateTimePicker.Name = "deptCreationDateTimePicker";
            this.deptCreationDateTimePicker.Size = new System.Drawing.Size(274, 32);
            this.deptCreationDateTimePicker.TabIndex = 60;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(335, 275);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(89, 32);
            this.resetBtn.TabIndex = 62;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // AdminDepartment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.deptCreationDate);
            this.Controls.Add(this.deptCreationDateTimePicker);
            this.Controls.Add(this.deptIdTB);
            this.Controls.Add(this.deptIdLabel);
            this.Controls.Add(this.deptNameTextBox);
            this.Controls.Add(this.deptNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DepartmentDataGridView);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminDepartment";
            this.Size = new System.Drawing.Size(1207, 877);
            this.Load += new System.EventHandler(this.AdminDepartment_Load);
            this.Click += new System.EventHandler(this.AdminDepartment_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView DepartmentDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deptNameTextBox;
        private System.Windows.Forms.Label deptNameLabel;
        private System.Windows.Forms.TextBox deptIdTB;
        private System.Windows.Forms.Label deptIdLabel;
        private System.Windows.Forms.Label deptCreationDate;
        private System.Windows.Forms.DateTimePicker deptCreationDateTimePicker;
        private System.Windows.Forms.Button resetBtn;
    }
}
