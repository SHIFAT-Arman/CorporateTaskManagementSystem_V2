namespace CorporateTaskManagementSystem_V2.View
{
    partial class EmployeeTask
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
            this.label4 = new System.Windows.Forms.Label();
            this.eTaskTeamComboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eTaskDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.eTaskNameTextBox = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.eTaskSearchBtn = new System.Windows.Forms.Button();
            this.eTaskUpdateBtn = new System.Windows.Forms.Button();
            this.eTaskSearchTextBox = new System.Windows.Forms.TextBox();
            this.eTaskDataGridView1 = new System.Windows.Forms.DataGridView();
            this.pendingRadioButton = new System.Windows.Forms.RadioButton();
            this.eTaskStatusGroupBox1 = new System.Windows.Forms.GroupBox();
            this.completedRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.eTaskDataGridView1)).BeginInit();
            this.eTaskStatusGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(874, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 101;
            this.label4.Text = "Choose Team";
            // 
            // eTaskTeamComboBox1
            // 
            this.eTaskTeamComboBox1.Enabled = false;
            this.eTaskTeamComboBox1.FormattingEnabled = true;
            this.eTaskTeamComboBox1.Items.AddRange(new object[] {
            "Website Designer",
            "Data Analyst"});
            this.eTaskTeamComboBox1.Location = new System.Drawing.Point(878, 132);
            this.eTaskTeamComboBox1.Name = "eTaskTeamComboBox1";
            this.eTaskTeamComboBox1.Size = new System.Drawing.Size(271, 32);
            this.eTaskTeamComboBox1.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 99;
            this.label2.Text = "Assign Date";
            // 
            // eTaskDateTimePicker1
            // 
            this.eTaskDateTimePicker1.Location = new System.Drawing.Point(69, 223);
            this.eTaskDateTimePicker1.Name = "eTaskDateTimePicker1";
            this.eTaskDateTimePicker1.Size = new System.Drawing.Size(275, 32);
            this.eTaskDateTimePicker1.TabIndex = 98;
            // 
            // eTaskNameTextBox
            // 
            this.eTaskNameTextBox.Location = new System.Drawing.Point(70, 132);
            this.eTaskNameTextBox.Name = "eTaskNameTextBox";
            this.eTaskNameTextBox.Size = new System.Drawing.Size(274, 32);
            this.eTaskNameTextBox.TabIndex = 95;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(65, 104);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(109, 24);
            this.teamNameLabel.TabIndex = 94;
            this.teamNameLabel.Text = "Task Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 36);
            this.label1.TabIndex = 93;
            this.label1.Text = "Tasks";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1060, 354);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 32);
            this.button6.TabIndex = 92;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // eTaskSearchBtn
            // 
            this.eTaskSearchBtn.Location = new System.Drawing.Point(361, 355);
            this.eTaskSearchBtn.Name = "eTaskSearchBtn";
            this.eTaskSearchBtn.Size = new System.Drawing.Size(89, 32);
            this.eTaskSearchBtn.TabIndex = 90;
            this.eTaskSearchBtn.Text = "Search";
            this.eTaskSearchBtn.UseVisualStyleBackColor = true;
            this.eTaskSearchBtn.Click += new System.EventHandler(this.eTaskSearchBtn_Click);
            // 
            // eTaskUpdateBtn
            // 
            this.eTaskUpdateBtn.Location = new System.Drawing.Point(70, 355);
            this.eTaskUpdateBtn.Name = "eTaskUpdateBtn";
            this.eTaskUpdateBtn.Size = new System.Drawing.Size(89, 32);
            this.eTaskUpdateBtn.TabIndex = 88;
            this.eTaskUpdateBtn.Text = "Update";
            this.eTaskUpdateBtn.UseVisualStyleBackColor = true;
            this.eTaskUpdateBtn.Click += new System.EventHandler(this.eTaskUpdateBtn_Click);
            // 
            // eTaskSearchTextBox
            // 
            this.eTaskSearchTextBox.ForeColor = System.Drawing.Color.Silver;
            this.eTaskSearchTextBox.Location = new System.Drawing.Point(456, 355);
            this.eTaskSearchTextBox.Name = "eTaskSearchTextBox";
            this.eTaskSearchTextBox.Size = new System.Drawing.Size(393, 32);
            this.eTaskSearchTextBox.TabIndex = 91;
            this.eTaskSearchTextBox.Text = "Enter Name";
            this.eTaskSearchTextBox.Enter += new System.EventHandler(this.eTaskSearchTextBox_Enter);
            this.eTaskSearchTextBox.Leave += new System.EventHandler(this.eTaskSearchTextBox_Leave);
            // 
            // eTaskDataGridView1
            // 
            this.eTaskDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eTaskDataGridView1.Location = new System.Drawing.Point(2, 392);
            this.eTaskDataGridView1.Name = "eTaskDataGridView1";
            this.eTaskDataGridView1.ReadOnly = true;
            this.eTaskDataGridView1.RowHeadersWidth = 51;
            this.eTaskDataGridView1.RowTemplate.Height = 24;
            this.eTaskDataGridView1.Size = new System.Drawing.Size(1205, 485);
            this.eTaskDataGridView1.TabIndex = 86;
            this.eTaskDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eTaskDataGridView1_CellContentClick);
            // 
            // pendingRadioButton
            // 
            this.pendingRadioButton.AutoSize = true;
            this.pendingRadioButton.Location = new System.Drawing.Point(11, 31);
            this.pendingRadioButton.Name = "pendingRadioButton";
            this.pendingRadioButton.Size = new System.Drawing.Size(102, 28);
            this.pendingRadioButton.TabIndex = 102;
            this.pendingRadioButton.TabStop = true;
            this.pendingRadioButton.Text = "Pending";
            this.pendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // eTaskStatusGroupBox1
            // 
            this.eTaskStatusGroupBox1.Controls.Add(this.completedRadioButton);
            this.eTaskStatusGroupBox1.Controls.Add(this.pendingRadioButton);
            this.eTaskStatusGroupBox1.Location = new System.Drawing.Point(878, 197);
            this.eTaskStatusGroupBox1.Name = "eTaskStatusGroupBox1";
            this.eTaskStatusGroupBox1.Size = new System.Drawing.Size(271, 103);
            this.eTaskStatusGroupBox1.TabIndex = 103;
            this.eTaskStatusGroupBox1.TabStop = false;
            this.eTaskStatusGroupBox1.Text = "Status";
            // 
            // completedRadioButton
            // 
            this.completedRadioButton.AutoSize = true;
            this.completedRadioButton.Location = new System.Drawing.Point(11, 69);
            this.completedRadioButton.Name = "completedRadioButton";
            this.completedRadioButton.Size = new System.Drawing.Size(128, 28);
            this.completedRadioButton.TabIndex = 103;
            this.completedRadioButton.TabStop = true;
            this.completedRadioButton.Text = "Completed";
            this.completedRadioButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeTask
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.eTaskStatusGroupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eTaskTeamComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eTaskDateTimePicker1);
            this.Controls.Add(this.eTaskNameTextBox);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.eTaskSearchBtn);
            this.Controls.Add(this.eTaskUpdateBtn);
            this.Controls.Add(this.eTaskSearchTextBox);
            this.Controls.Add(this.eTaskDataGridView1);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeeTask";
            this.Size = new System.Drawing.Size(1207, 877);
            this.Load += new System.EventHandler(this.EmployeeTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eTaskDataGridView1)).EndInit();
            this.eTaskStatusGroupBox1.ResumeLayout(false);
            this.eTaskStatusGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox eTaskTeamComboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker eTaskDateTimePicker1;
        private System.Windows.Forms.TextBox eTaskNameTextBox;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button eTaskSearchBtn;
        private System.Windows.Forms.Button eTaskUpdateBtn;
        private System.Windows.Forms.TextBox eTaskSearchTextBox;
        private System.Windows.Forms.DataGridView eTaskDataGridView1;
        private System.Windows.Forms.RadioButton pendingRadioButton;
        private System.Windows.Forms.GroupBox eTaskStatusGroupBox1;
        private System.Windows.Forms.RadioButton completedRadioButton;
    }
}
