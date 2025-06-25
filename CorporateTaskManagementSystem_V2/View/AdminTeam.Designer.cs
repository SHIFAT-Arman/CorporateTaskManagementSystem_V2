namespace CorporateTaskManagementSystem_V2.View
{
    partial class AdminTeam
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
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamsLabel = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.TeamsDataGridView = new System.Windows.Forms.DataGridView();
            this.chooseDeptLabel = new System.Windows.Forms.Label();
            this.chooseDeptComboBox = new System.Windows.Forms.ComboBox();
            this.TeamIdTB = new System.Windows.Forms.TextBox();
            this.teamIdLabel = new System.Windows.Forms.Label();
            this.CreationDateLabel = new System.Windows.Forms.Label();
            this.CreationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Location = new System.Drawing.Point(76, 205);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(274, 32);
            this.teamNameTextBox.TabIndex = 67;
            this.teamNameTextBox.TextChanged += new System.EventHandler(this.teamNameTextBox_TextChanged);
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(71, 177);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(116, 24);
            this.teamNameLabel.TabIndex = 66;
            this.teamNameLabel.Text = "Team Name";
            // 
            // teamsLabel
            // 
            this.teamsLabel.AutoSize = true;
            this.teamsLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsLabel.Location = new System.Drawing.Point(485, 10);
            this.teamsLabel.Name = "teamsLabel";
            this.teamsLabel.Size = new System.Drawing.Size(101, 36);
            this.teamsLabel.TabIndex = 65;
            this.teamsLabel.Text = "Teams";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(1011, 267);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(89, 32);
            this.refreshBtn.TabIndex = 64;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(482, 265);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(89, 32);
            this.SearchBtn.TabIndex = 62;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(253, 267);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(89, 32);
            this.DeleteBtn.TabIndex = 61;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(158, 266);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(89, 32);
            this.UpdateBtn.TabIndex = 60;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(63, 267);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(89, 32);
            this.AddBtn.TabIndex = 59;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.ForeColor = System.Drawing.Color.Silver;
            this.SearchTextBox.Location = new System.Drawing.Point(577, 266);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(401, 32);
            this.SearchTextBox.TabIndex = 63;
            this.SearchTextBox.Text = "Search Team by Name";
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // TeamsDataGridView
            // 
            this.TeamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamsDataGridView.Location = new System.Drawing.Point(2, 304);
            this.TeamsDataGridView.Name = "TeamsDataGridView";
            this.TeamsDataGridView.RowHeadersWidth = 51;
            this.TeamsDataGridView.RowTemplate.Height = 24;
            this.TeamsDataGridView.Size = new System.Drawing.Size(1509, 639);
            this.TeamsDataGridView.TabIndex = 58;
            this.TeamsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TeamsDataGridView_CellMouseClick);
            // 
            // chooseDeptLabel
            // 
            this.chooseDeptLabel.AutoSize = true;
            this.chooseDeptLabel.Location = new System.Drawing.Point(684, 177);
            this.chooseDeptLabel.Name = "chooseDeptLabel";
            this.chooseDeptLabel.Size = new System.Drawing.Size(128, 24);
            this.chooseDeptLabel.TabIndex = 69;
            this.chooseDeptLabel.Text = "Choose Dept.";
            // 
            // chooseDeptComboBox
            // 
            this.chooseDeptComboBox.FormattingEnabled = true;
            this.chooseDeptComboBox.Location = new System.Drawing.Point(688, 205);
            this.chooseDeptComboBox.Name = "chooseDeptComboBox";
            this.chooseDeptComboBox.Size = new System.Drawing.Size(271, 32);
            this.chooseDeptComboBox.TabIndex = 68;
            this.chooseDeptComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseDeptComboBox_SelectedIndexChanged);
            this.chooseDeptComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseDeptComboBox_MouseClick);
            // 
            // TeamIdTB
            // 
            this.TeamIdTB.Enabled = false;
            this.TeamIdTB.Location = new System.Drawing.Point(75, 132);
            this.TeamIdTB.Name = "TeamIdTB";
            this.TeamIdTB.Size = new System.Drawing.Size(123, 32);
            this.TeamIdTB.TabIndex = 71;
            // 
            // teamIdLabel
            // 
            this.teamIdLabel.AutoSize = true;
            this.teamIdLabel.Location = new System.Drawing.Point(70, 104);
            this.teamIdLabel.Name = "teamIdLabel";
            this.teamIdLabel.Size = new System.Drawing.Size(82, 24);
            this.teamIdLabel.TabIndex = 70;
            this.teamIdLabel.Text = "Team ID";
            // 
            // CreationDateLabel
            // 
            this.CreationDateLabel.AutoSize = true;
            this.CreationDateLabel.Location = new System.Drawing.Point(683, 104);
            this.CreationDateLabel.Name = "CreationDateLabel";
            this.CreationDateLabel.Size = new System.Drawing.Size(134, 24);
            this.CreationDateLabel.TabIndex = 73;
            this.CreationDateLabel.Text = "Creation Date";
            // 
            // CreationDateTimePicker
            // 
            this.CreationDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CreationDateTimePicker.Location = new System.Drawing.Point(688, 132);
            this.CreationDateTimePicker.MaxDate = new System.DateTime(2030, 12, 25, 23, 59, 59, 0);
            this.CreationDateTimePicker.Name = "CreationDateTimePicker";
            this.CreationDateTimePicker.Size = new System.Drawing.Size(274, 32);
            this.CreationDateTimePicker.TabIndex = 72;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(348, 267);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(89, 32);
            this.resetBtn.TabIndex = 74;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // AdminTeam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.CreationDateLabel);
            this.Controls.Add(this.CreationDateTimePicker);
            this.Controls.Add(this.TeamIdTB);
            this.Controls.Add(this.teamIdLabel);
            this.Controls.Add(this.chooseDeptLabel);
            this.Controls.Add(this.chooseDeptComboBox);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.teamsLabel);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.TeamsDataGridView);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminTeam";
            this.Size = new System.Drawing.Size(1207, 877);
            this.Load += new System.EventHandler(this.AdminTeam_Load);
            this.Click += new System.EventHandler(this.AdminTeam_Click);
            ((System.ComponentModel.ISupportInitialize)(this.TeamsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label teamsLabel;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView TeamsDataGridView;
        private System.Windows.Forms.Label chooseDeptLabel;
        private System.Windows.Forms.ComboBox chooseDeptComboBox;
        private System.Windows.Forms.TextBox TeamIdTB;
        private System.Windows.Forms.Label teamIdLabel;
        private System.Windows.Forms.Label CreationDateLabel;
        private System.Windows.Forms.DateTimePicker CreationDateTimePicker;
        private System.Windows.Forms.Button resetBtn;
    }
}
