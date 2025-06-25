namespace CorporateTaskManagementSystem_V2.View
{
    partial class AdminTask
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
            this.label6 = new System.Windows.Forms.Label();
            this.departmentCombobox = new System.Windows.Forms.ComboBox();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.adminTaskSearchbtn = new System.Windows.Forms.Button();
            this.adminTaskDltbt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.adminTaskGridView1 = new System.Windows.Forms.DataGridView();
            this.assignedDt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teamcomboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminTaskGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 24);
            this.label6.TabIndex = 81;
            this.label6.Text = "Choose Dept.";
            // 
            // departmentCombobox
            // 
            this.departmentCombobox.FormattingEnabled = true;
            this.departmentCombobox.Items.AddRange(new object[] {
            "IT",
            "HR"});
            this.departmentCombobox.Location = new System.Drawing.Point(459, 132);
            this.departmentCombobox.Name = "departmentCombobox";
            this.departmentCombobox.Size = new System.Drawing.Size(271, 32);
            this.departmentCombobox.TabIndex = 80;
            this.departmentCombobox.SelectedIndexChanged += new System.EventHandler(this.departmentCombobox_SelectedIndexChanged);
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Location = new System.Drawing.Point(70, 132);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(274, 32);
            this.taskNameTextBox.TabIndex = 79;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(65, 104);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(109, 24);
            this.teamNameLabel.TabIndex = 78;
            this.teamNameLabel.Text = "Task Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 36);
            this.label1.TabIndex = 77;
            this.label1.Text = "Tasks";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(719, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 32);
            this.button6.TabIndex = 76;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // adminTaskSearchbtn
            // 
            this.adminTaskSearchbtn.Location = new System.Drawing.Point(295, 354);
            this.adminTaskSearchbtn.Name = "adminTaskSearchbtn";
            this.adminTaskSearchbtn.Size = new System.Drawing.Size(89, 32);
            this.adminTaskSearchbtn.TabIndex = 74;
            this.adminTaskSearchbtn.Text = "Search";
            this.adminTaskSearchbtn.UseVisualStyleBackColor = true;
            this.adminTaskSearchbtn.Click += new System.EventHandler(this.adminTaskSearchbtn_Click);
            // 
            // adminTaskDltbt
            // 
            this.adminTaskDltbt.Location = new System.Drawing.Point(200, 354);
            this.adminTaskDltbt.Name = "adminTaskDltbt";
            this.adminTaskDltbt.Size = new System.Drawing.Size(89, 32);
            this.adminTaskDltbt.TabIndex = 73;
            this.adminTaskDltbt.Text = "Delete";
            this.adminTaskDltbt.UseVisualStyleBackColor = true;
            this.adminTaskDltbt.Click += new System.EventHandler(this.adminTaskDltbt_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 32);
            this.button3.TabIndex = 72;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 32);
            this.button2.TabIndex = 71;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.ForeColor = System.Drawing.Color.Silver;
            this.SearchTextBox.Location = new System.Drawing.Point(390, 354);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(229, 32);
            this.SearchTextBox.TabIndex = 75;
            this.SearchTextBox.Text = "Enter valid id";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // adminTaskGridView1
            // 
            this.adminTaskGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminTaskGridView1.Location = new System.Drawing.Point(2, 392);
            this.adminTaskGridView1.Name = "adminTaskGridView1";
            this.adminTaskGridView1.ReadOnly = true;
            this.adminTaskGridView1.RowHeadersWidth = 51;
            this.adminTaskGridView1.RowTemplate.Height = 24;
            this.adminTaskGridView1.Size = new System.Drawing.Size(822, 373);
            this.adminTaskGridView1.TabIndex = 70;
            this.adminTaskGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminTaskGridView1_CellContentClick);
            // 
            // assignedDt
            // 
            this.assignedDt.Location = new System.Drawing.Point(69, 223);
            this.assignedDt.Name = "assignedDt";
            this.assignedDt.Size = new System.Drawing.Size(275, 32);
            this.assignedDt.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 83;
            this.label2.Text = "Assign Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 85;
            this.label4.Text = "Choose Team";
            // 
            // teamcomboBox1
            // 
            this.teamcomboBox1.FormattingEnabled = true;
            this.teamcomboBox1.Items.AddRange(new object[] {
            "Website Designer",
            "Data Analyst"});
            this.teamcomboBox1.Location = new System.Drawing.Point(459, 226);
            this.teamcomboBox1.Name = "teamcomboBox1";
            this.teamcomboBox1.Size = new System.Drawing.Size(271, 32);
            this.teamcomboBox1.TabIndex = 84;
            // 
            // AdminTask
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teamcomboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assignedDt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.departmentCombobox);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.adminTaskSearchbtn);
            this.Controls.Add(this.adminTaskDltbt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.adminTaskGridView1);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminTask";
            this.Size = new System.Drawing.Size(827, 776);
            this.Load += new System.EventHandler(this.AdminTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminTaskGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox departmentCombobox;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button adminTaskSearchbtn;
        private System.Windows.Forms.Button adminTaskDltbt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView adminTaskGridView1;
        private System.Windows.Forms.DateTimePicker assignedDt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox teamcomboBox1;
    }
}
