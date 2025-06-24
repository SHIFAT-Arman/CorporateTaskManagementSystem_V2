namespace CorporateTaskManagementSystem_V2.View
{
    partial class AdminEmployee
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.regularEmpRadioButton = new System.Windows.Forms.RadioButton();
            this.deptHeadRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.choosePositionGroupBox = new System.Windows.Forms.GroupBox();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.teamLeadRadioButton = new System.Windows.Forms.RadioButton();
            this.chooseDept = new System.Windows.Forms.Label();
            this.chooseDeptComboBox = new System.Windows.Forms.ComboBox();
            this.salaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.chooseTeamLabel = new System.Windows.Forms.Label();
            this.chooseTeamComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.joinDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.empIDLabel = new System.Windows.Forms.Label();
            this.empIdTB = new System.Windows.Forms.TextBox();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.chooseTeamErrorLabel = new System.Windows.Forms.Label();
            this.chooseDeptErrorLabel = new System.Windows.Forms.Label();
            this.salaryErrorLabel = new System.Windows.Forms.Label();
            this.showLinkLabel = new System.Windows.Forms.LinkLabel();
            this.passInfoLabel = new System.Windows.Forms.Label();
            this.passInfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pfpFileNameTextBox = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.defaultPictureBox = new System.Windows.Forms.PictureBox();
            this.choosePositionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(1114, 492);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(89, 32);
            this.refreshBtn.TabIndex = 12;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(439, 490);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(89, 32);
            this.SearchBtn.TabIndex = 18;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(297, 492);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(89, 32);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(202, 492);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(89, 32);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(7, 490);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(89, 32);
            this.AddBtn.TabIndex = 13;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(960, 455);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(89, 32);
            this.uploadBtn.TabIndex = 11;
            this.uploadBtn.Text = "upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // regularEmpRadioButton
            // 
            this.regularEmpRadioButton.AutoSize = true;
            this.regularEmpRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularEmpRadioButton.Location = new System.Drawing.Point(157, 43);
            this.regularEmpRadioButton.Name = "regularEmpRadioButton";
            this.regularEmpRadioButton.Size = new System.Drawing.Size(150, 22);
            this.regularEmpRadioButton.TabIndex = 1;
            this.regularEmpRadioButton.TabStop = true;
            this.regularEmpRadioButton.Text = "Regular Employee";
            this.regularEmpRadioButton.UseVisualStyleBackColor = true;
            this.regularEmpRadioButton.CheckedChanged += new System.EventHandler(this.regularEmpRadioButton_CheckedChanged);
            // 
            // deptHeadRadioButton
            // 
            this.deptHeadRadioButton.AutoSize = true;
            this.deptHeadRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptHeadRadioButton.Location = new System.Drawing.Point(32, 43);
            this.deptHeadRadioButton.Name = "deptHeadRadioButton";
            this.deptHeadRadioButton.Size = new System.Drawing.Size(103, 22);
            this.deptHeadRadioButton.TabIndex = 0;
            this.deptHeadRadioButton.TabStop = true;
            this.deptHeadRadioButton.Text = "Dept. Head";
            this.deptHeadRadioButton.UseVisualStyleBackColor = true;
            this.deptHeadRadioButton.CheckedChanged += new System.EventHandler(this.deptHeadRadioButton_CheckedChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.ForeColor = System.Drawing.Color.Silver;
            this.SearchTextBox.Location = new System.Drawing.Point(549, 490);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(229, 30);
            this.SearchTextBox.TabIndex = 17;
            this.SearchTextBox.Text = "Search by First Name";
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // choosePositionGroupBox
            // 
            this.choosePositionGroupBox.Controls.Add(this.adminRadioButton);
            this.choosePositionGroupBox.Controls.Add(this.teamLeadRadioButton);
            this.choosePositionGroupBox.Controls.Add(this.regularEmpRadioButton);
            this.choosePositionGroupBox.Controls.Add(this.deptHeadRadioButton);
            this.choosePositionGroupBox.Location = new System.Drawing.Point(879, 47);
            this.choosePositionGroupBox.Name = "choosePositionGroupBox";
            this.choosePositionGroupBox.Size = new System.Drawing.Size(324, 111);
            this.choosePositionGroupBox.TabIndex = 8;
            this.choosePositionGroupBox.TabStop = false;
            this.choosePositionGroupBox.Text = "Choose Position";
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRadioButton.Location = new System.Drawing.Point(157, 83);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(70, 22);
            this.adminRadioButton.TabIndex = 3;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            this.adminRadioButton.CheckedChanged += new System.EventHandler(this.adminRadioButton_CheckedChanged);
            // 
            // teamLeadRadioButton
            // 
            this.teamLeadRadioButton.AutoSize = true;
            this.teamLeadRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLeadRadioButton.Location = new System.Drawing.Point(32, 83);
            this.teamLeadRadioButton.Name = "teamLeadRadioButton";
            this.teamLeadRadioButton.Size = new System.Drawing.Size(103, 22);
            this.teamLeadRadioButton.TabIndex = 2;
            this.teamLeadRadioButton.TabStop = true;
            this.teamLeadRadioButton.Text = "Team Lead";
            this.teamLeadRadioButton.UseVisualStyleBackColor = true;
            this.teamLeadRadioButton.CheckedChanged += new System.EventHandler(this.teamLeadRadioButton_CheckedChanged);
            // 
            // chooseDept
            // 
            this.chooseDept.AutoSize = true;
            this.chooseDept.Location = new System.Drawing.Point(883, 272);
            this.chooseDept.Name = "chooseDept";
            this.chooseDept.Size = new System.Drawing.Size(132, 25);
            this.chooseDept.TabIndex = 38;
            this.chooseDept.Text = "Choose Dept.";
            // 
            // chooseDeptComboBox
            // 
            this.chooseDeptComboBox.Enabled = false;
            this.chooseDeptComboBox.FormattingEnabled = true;
            this.chooseDeptComboBox.Location = new System.Drawing.Point(1036, 269);
            this.chooseDeptComboBox.Name = "chooseDeptComboBox";
            this.chooseDeptComboBox.Size = new System.Drawing.Size(165, 33);
            this.chooseDeptComboBox.TabIndex = 10;
            this.chooseDeptComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseDeptComboBox_SelectedIndexChanged);
            // 
            // salaryNumericUpDown
            // 
            this.salaryNumericUpDown.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.salaryNumericUpDown.Location = new System.Drawing.Point(689, 128);
            this.salaryNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.salaryNumericUpDown.Name = "salaryNumericUpDown";
            this.salaryNumericUpDown.Size = new System.Drawing.Size(165, 30);
            this.salaryNumericUpDown.TabIndex = 7;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(684, 100);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(68, 25);
            this.salaryLabel.TabIndex = 35;
            this.salaryLabel.Text = "Salary";
            // 
            // chooseTeamLabel
            // 
            this.chooseTeamLabel.AutoSize = true;
            this.chooseTeamLabel.Location = new System.Drawing.Point(883, 200);
            this.chooseTeamLabel.Name = "chooseTeamLabel";
            this.chooseTeamLabel.Size = new System.Drawing.Size(137, 25);
            this.chooseTeamLabel.TabIndex = 34;
            this.chooseTeamLabel.Text = "Choose Team";
            // 
            // chooseTeamComboBox
            // 
            this.chooseTeamComboBox.Enabled = false;
            this.chooseTeamComboBox.FormattingEnabled = true;
            this.chooseTeamComboBox.Location = new System.Drawing.Point(1036, 197);
            this.chooseTeamComboBox.Name = "chooseTeamComboBox";
            this.chooseTeamComboBox.Size = new System.Drawing.Size(165, 33);
            this.chooseTeamComboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Join Date";
            // 
            // joinDateDateTimePicker
            // 
            this.joinDateDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.joinDateDateTimePicker.Location = new System.Drawing.Point(386, 337);
            this.joinDateDateTimePicker.Name = "joinDateDateTimePicker";
            this.joinDateDateTimePicker.Size = new System.Drawing.Size(274, 30);
            this.joinDateDateTimePicker.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Date of Birth";
            // 
            // DOBDateTimePicker
            // 
            this.DOBDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DOBDateTimePicker.Location = new System.Drawing.Point(43, 337);
            this.DOBDateTimePicker.MaxDate = new System.DateTime(2030, 12, 25, 23, 59, 59, 0);
            this.DOBDateTimePicker.Name = "DOBDateTimePicker";
            this.DOBDateTimePicker.Size = new System.Drawing.Size(274, 30);
            this.DOBDateTimePicker.TabIndex = 5;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(386, 128);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(274, 30);
            this.lastNameTB.TabIndex = 2;
            this.lastNameTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lastNameTB_MouseClick);
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(43, 128);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(274, 30);
            this.firstNameTB.TabIndex = 1;
            this.firstNameTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.firstNameTB_MouseClick);
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToAddRows = false;
            this.EmployeeDataGridView.AllowUserToDeleteRows = false;
            this.EmployeeDataGridView.AllowUserToOrderColumns = true;
            this.EmployeeDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmployeeDataGridView.GridColor = System.Drawing.Color.MidnightBlue;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(0, 530);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.ReadOnly = true;
            this.EmployeeDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.EmployeeDataGridView.RowTemplate.Height = 24;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(1207, 347);
            this.EmployeeDataGridView.TabIndex = 26;
            this.EmployeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView_CellClick);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(381, 100);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.lastNameLabel.TabIndex = 25;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(38, 100);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.firstNameLabel.TabIndex = 24;
            this.firstNameLabel.Text = "First Name";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(43, 233);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(274, 30);
            this.emailTB.TabIndex = 3;
            this.passInfoToolTip.SetToolTip(this.emailTB, "Format must be either of three:\r\n<email><E-ID>.emp@gmail.com\r\n<email><E-ID>.dept@" +
        "gmail.com\r\n<email><E-ID>.admin@gmail.com");
            this.emailTB.Enter += new System.EventHandler(this.emailTB_Enter);
            this.emailTB.MouseHover += new System.EventHandler(this.emailTB_MouseHover);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(38, 205);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(60, 25);
            this.emailLabel.TabIndex = 48;
            this.emailLabel.Text = "Email";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(386, 233);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(274, 30);
            this.passwordTB.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(381, 205);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordLabel.TabIndex = 51;
            this.passwordLabel.Text = "Password";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = global::CorporateTaskManagementSystem_V2.Properties.Resources.defaultPfpImage;
            this.profilePictureBox.Location = new System.Drawing.Point(1055, 337);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(148, 144);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 40;
            this.profilePictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(543, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 34);
            this.label8.TabIndex = 52;
            this.label8.Text = "Employees";
            // 
            // empIDLabel
            // 
            this.empIDLabel.AutoSize = true;
            this.empIDLabel.Location = new System.Drawing.Point(38, 57);
            this.empIDLabel.Name = "empIDLabel";
            this.empIDLabel.Size = new System.Drawing.Size(123, 25);
            this.empIDLabel.TabIndex = 53;
            this.empIDLabel.Text = "Employee ID";
            // 
            // empIdTB
            // 
            this.empIdTB.Enabled = false;
            this.empIdTB.Location = new System.Drawing.Point(164, 57);
            this.empIdTB.Name = "empIdTB";
            this.empIdTB.Size = new System.Drawing.Size(153, 30);
            this.empIdTB.TabIndex = 54;
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoEllipsis = true;
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.BackColor = System.Drawing.Color.Brown;
            this.firstNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(43, 165);
            this.firstNameErrorLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.firstNameErrorLabel.TabIndex = 55;
            this.firstNameErrorLabel.Visible = false;
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoEllipsis = true;
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.BackColor = System.Drawing.Color.Brown;
            this.lastNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(386, 161);
            this.lastNameErrorLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.lastNameErrorLabel.TabIndex = 56;
            this.lastNameErrorLabel.Visible = false;
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoEllipsis = true;
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.BackColor = System.Drawing.Color.Brown;
            this.emailErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailErrorLabel.Location = new System.Drawing.Point(43, 266);
            this.emailErrorLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.emailErrorLabel.TabIndex = 57;
            this.emailErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoEllipsis = true;
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.BackColor = System.Drawing.Color.Brown;
            this.passwordErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordErrorLabel.Location = new System.Drawing.Point(386, 270);
            this.passwordErrorLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.passwordErrorLabel.TabIndex = 58;
            this.passwordErrorLabel.Visible = false;
            // 
            // chooseTeamErrorLabel
            // 
            this.chooseTeamErrorLabel.AutoEllipsis = true;
            this.chooseTeamErrorLabel.AutoSize = true;
            this.chooseTeamErrorLabel.BackColor = System.Drawing.Color.Brown;
            this.chooseTeamErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseTeamErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chooseTeamErrorLabel.Location = new System.Drawing.Point(907, 225);
            this.chooseTeamErrorLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.chooseTeamErrorLabel.Name = "chooseTeamErrorLabel";
            this.chooseTeamErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.chooseTeamErrorLabel.TabIndex = 59;
            this.chooseTeamErrorLabel.Visible = false;
            // 
            // chooseDeptErrorLabel
            // 
            this.chooseDeptErrorLabel.AutoEllipsis = true;
            this.chooseDeptErrorLabel.AutoSize = true;
            this.chooseDeptErrorLabel.BackColor = System.Drawing.Color.Brown;
            this.chooseDeptErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDeptErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chooseDeptErrorLabel.Location = new System.Drawing.Point(907, 309);
            this.chooseDeptErrorLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.chooseDeptErrorLabel.Name = "chooseDeptErrorLabel";
            this.chooseDeptErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.chooseDeptErrorLabel.TabIndex = 60;
            this.chooseDeptErrorLabel.Visible = false;
            // 
            // salaryErrorLabel
            // 
            this.salaryErrorLabel.AutoEllipsis = true;
            this.salaryErrorLabel.AutoSize = true;
            this.salaryErrorLabel.BackColor = System.Drawing.Color.Brown;
            this.salaryErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salaryErrorLabel.Location = new System.Drawing.Point(1082, 426);
            this.salaryErrorLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.salaryErrorLabel.Name = "salaryErrorLabel";
            this.salaryErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.salaryErrorLabel.TabIndex = 61;
            this.salaryErrorLabel.Visible = false;
            // 
            // showLinkLabel
            // 
            this.showLinkLabel.AutoSize = true;
            this.showLinkLabel.Location = new System.Drawing.Point(666, 237);
            this.showLinkLabel.Name = "showLinkLabel";
            this.showLinkLabel.Size = new System.Drawing.Size(62, 25);
            this.showLinkLabel.TabIndex = 62;
            this.showLinkLabel.TabStop = true;
            this.showLinkLabel.Text = "Show";
            this.showLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showLinkLabel_LinkClicked);
            // 
            // passInfoLabel
            // 
            this.passInfoLabel.AutoSize = true;
            this.passInfoLabel.Location = new System.Drawing.Point(630, 207);
            this.passInfoLabel.Name = "passInfoLabel";
            this.passInfoLabel.Size = new System.Drawing.Size(30, 25);
            this.passInfoLabel.TabIndex = 63;
            this.passInfoLabel.Text = "(i)";
            this.passInfoToolTip.SetToolTip(this.passInfoLabel, "Has minimum 8 characters in length.\r\nAt least one uppercase English letter.\r\nAt l" +
        "east one lowercase English letter. \r\nAt least one digit.\r\nAt least one special c" +
        "haracter.\r\n\r\n");
            // 
            // passInfoToolTip
            // 
            this.passInfoToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // pfpFileNameTextBox
            // 
            this.pfpFileNameTextBox.Location = new System.Drawing.Point(949, 419);
            this.pfpFileNameTextBox.Name = "pfpFileNameTextBox";
            this.pfpFileNameTextBox.Size = new System.Drawing.Size(100, 30);
            this.pfpFileNameTextBox.TabIndex = 64;
            this.pfpFileNameTextBox.Visible = false;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(107, 492);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(89, 32);
            this.resetBtn.TabIndex = 14;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // defaultPictureBox
            // 
            this.defaultPictureBox.Image = global::CorporateTaskManagementSystem_V2.Properties.Resources.defaultPfpImage;
            this.defaultPictureBox.Location = new System.Drawing.Point(1021, 386);
            this.defaultPictureBox.Name = "defaultPictureBox";
            this.defaultPictureBox.Size = new System.Drawing.Size(28, 27);
            this.defaultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defaultPictureBox.TabIndex = 66;
            this.defaultPictureBox.TabStop = false;
            this.defaultPictureBox.Visible = false;
            // 
            // AdminEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.defaultPictureBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.pfpFileNameTextBox);
            this.Controls.Add(this.passInfoLabel);
            this.Controls.Add(this.showLinkLabel);
            this.Controls.Add(this.salaryErrorLabel);
            this.Controls.Add(this.chooseDeptErrorLabel);
            this.Controls.Add(this.chooseTeamErrorLabel);
            this.Controls.Add(this.passwordErrorLabel);
            this.Controls.Add(this.emailErrorLabel);
            this.Controls.Add(this.lastNameErrorLabel);
            this.Controls.Add(this.firstNameErrorLabel);
            this.Controls.Add(this.empIdTB);
            this.Controls.Add(this.empIDLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.choosePositionGroupBox);
            this.Controls.Add(this.chooseDept);
            this.Controls.Add(this.chooseDeptComboBox);
            this.Controls.Add(this.salaryNumericUpDown);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.chooseTeamLabel);
            this.Controls.Add(this.chooseTeamComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.joinDateDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DOBDateTimePicker);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminEmployee";
            this.Size = new System.Drawing.Size(1207, 877);
            this.Load += new System.EventHandler(this.AdminEmployee_Load);
            this.Click += new System.EventHandler(this.AdminEmployee_Click);
            this.choosePositionGroupBox.ResumeLayout(false);
            this.choosePositionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.RadioButton regularEmpRadioButton;
        private System.Windows.Forms.RadioButton deptHeadRadioButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox choosePositionGroupBox;
        private System.Windows.Forms.Label chooseDept;
        private System.Windows.Forms.ComboBox chooseDeptComboBox;
        private System.Windows.Forms.NumericUpDown salaryNumericUpDown;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label chooseTeamLabel;
        private System.Windows.Forms.ComboBox chooseTeamComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker joinDateDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DOBDateTimePicker;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.RadioButton teamLeadRadioButton;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label empIDLabel;
        private System.Windows.Forms.TextBox empIdTB;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label chooseTeamErrorLabel;
        private System.Windows.Forms.Label chooseDeptErrorLabel;
        private System.Windows.Forms.Label salaryErrorLabel;
        private System.Windows.Forms.LinkLabel showLinkLabel;
        private System.Windows.Forms.Label passInfoLabel;
        private System.Windows.Forms.ToolTip passInfoToolTip;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.TextBox pfpFileNameTextBox;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.PictureBox defaultPictureBox;
    }
}
