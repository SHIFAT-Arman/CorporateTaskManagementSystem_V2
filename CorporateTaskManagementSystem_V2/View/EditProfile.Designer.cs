namespace CorporateTaskManagementSystem_V2.View
{
    partial class EditProfile
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
            this.passInfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.passInfoLabel = new System.Windows.Forms.Label();
            this.defaultPictureBox = new System.Windows.Forms.PictureBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.pfpFileNameTextBox = new System.Windows.Forms.TextBox();
            this.showLinkLabel = new System.Windows.Forms.LinkLabel();
            this.salaryErrorLabel = new System.Windows.Forms.Label();
            this.chooseDeptErrorLabel = new System.Windows.Forms.Label();
            this.chooseTeamErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.empIdTB = new System.Windows.Forms.TextBox();
            this.empIDLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.regularEmpRadioButton = new System.Windows.Forms.RadioButton();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.choosePositionGroupBox = new System.Windows.Forms.GroupBox();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.teamLeadRadioButton = new System.Windows.Forms.RadioButton();
            this.deptHeadRadioButton = new System.Windows.Forms.RadioButton();
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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.choosePositionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // passInfoToolTip
            // 
            this.passInfoToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // passInfoLabel
            // 
            this.passInfoLabel.AutoSize = true;
            this.passInfoLabel.Location = new System.Drawing.Point(630, 207);
            this.passInfoLabel.Name = "passInfoLabel";
            this.passInfoLabel.Size = new System.Drawing.Size(30, 25);
            this.passInfoLabel.TabIndex = 107;
            this.passInfoLabel.Text = "(i)";
            this.passInfoToolTip.SetToolTip(this.passInfoLabel, "Has minimum 8 characters in length.\r\nAt least one uppercase English letter.\r\nAt l" +
        "east one lowercase English letter. \r\nAt least one digit.\r\nAt least one special c" +
        "haracter.\r\n\r\n");
            // 
            // defaultPictureBox
            // 
            this.defaultPictureBox.Image = global::CorporateTaskManagementSystem_V2.Properties.Resources.defaultPfpImage;
            this.defaultPictureBox.Location = new System.Drawing.Point(1021, 386);
            this.defaultPictureBox.Name = "defaultPictureBox";
            this.defaultPictureBox.Size = new System.Drawing.Size(28, 27);
            this.defaultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defaultPictureBox.TabIndex = 109;
            this.defaultPictureBox.TabStop = false;
            this.defaultPictureBox.Visible = false;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(483, 490);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(89, 32);
            this.ResetBtn.TabIndex = 80;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // pfpFileNameTextBox
            // 
            this.pfpFileNameTextBox.Location = new System.Drawing.Point(949, 419);
            this.pfpFileNameTextBox.Name = "pfpFileNameTextBox";
            this.pfpFileNameTextBox.Size = new System.Drawing.Size(100, 30);
            this.pfpFileNameTextBox.TabIndex = 108;
            this.pfpFileNameTextBox.Visible = false;
            // 
            // showLinkLabel
            // 
            this.showLinkLabel.AutoSize = true;
            this.showLinkLabel.Location = new System.Drawing.Point(666, 237);
            this.showLinkLabel.Name = "showLinkLabel";
            this.showLinkLabel.Size = new System.Drawing.Size(62, 25);
            this.showLinkLabel.TabIndex = 106;
            this.showLinkLabel.TabStop = true;
            this.showLinkLabel.Text = "Show";
            this.showLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showLinkLabel_LinkClicked);
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
            this.salaryErrorLabel.TabIndex = 105;
            this.salaryErrorLabel.Visible = false;
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
            this.chooseDeptErrorLabel.TabIndex = 104;
            this.chooseDeptErrorLabel.Visible = false;
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
            this.chooseTeamErrorLabel.TabIndex = 103;
            this.chooseTeamErrorLabel.Visible = false;
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
            this.passwordErrorLabel.TabIndex = 102;
            this.passwordErrorLabel.Visible = false;
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
            this.emailErrorLabel.TabIndex = 101;
            this.emailErrorLabel.Visible = false;
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
            this.lastNameErrorLabel.TabIndex = 100;
            this.lastNameErrorLabel.Visible = false;
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
            this.firstNameErrorLabel.TabIndex = 99;
            this.firstNameErrorLabel.Visible = false;
            // 
            // empIdTB
            // 
            this.empIdTB.Enabled = false;
            this.empIdTB.Location = new System.Drawing.Point(164, 57);
            this.empIdTB.Name = "empIdTB";
            this.empIdTB.Size = new System.Drawing.Size(153, 30);
            this.empIdTB.TabIndex = 98;
            // 
            // empIDLabel
            // 
            this.empIDLabel.AutoSize = true;
            this.empIDLabel.Location = new System.Drawing.Point(38, 57);
            this.empIDLabel.Name = "empIDLabel";
            this.empIDLabel.Size = new System.Drawing.Size(123, 25);
            this.empIDLabel.TabIndex = 97;
            this.empIDLabel.Text = "Employee ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(492, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 34);
            this.label8.TabIndex = 96;
            this.label8.Text = "Edit Profile";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(381, 205);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordLabel.TabIndex = 95;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(386, 233);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(274, 30);
            this.passwordTB.TabIndex = 70;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(43, 233);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(274, 30);
            this.emailTB.TabIndex = 69;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(38, 205);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(60, 25);
            this.emailLabel.TabIndex = 94;
            this.emailLabel.Text = "Email";
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
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(578, 490);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(89, 32);
            this.UpdateBtn.TabIndex = 81;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(960, 455);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(89, 32);
            this.uploadBtn.TabIndex = 77;
            this.uploadBtn.Text = "upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = global::CorporateTaskManagementSystem_V2.Properties.Resources.defaultPfpImage;
            this.profilePictureBox.Location = new System.Drawing.Point(1055, 337);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(148, 144);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 93;
            this.profilePictureBox.TabStop = false;
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
            this.choosePositionGroupBox.TabIndex = 74;
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
            // 
            // chooseDept
            // 
            this.chooseDept.AutoSize = true;
            this.chooseDept.Location = new System.Drawing.Point(883, 272);
            this.chooseDept.Name = "chooseDept";
            this.chooseDept.Size = new System.Drawing.Size(132, 25);
            this.chooseDept.TabIndex = 92;
            this.chooseDept.Text = "Choose Dept.";
            // 
            // chooseDeptComboBox
            // 
            this.chooseDeptComboBox.Enabled = false;
            this.chooseDeptComboBox.FormattingEnabled = true;
            this.chooseDeptComboBox.Location = new System.Drawing.Point(1036, 269);
            this.chooseDeptComboBox.Name = "chooseDeptComboBox";
            this.chooseDeptComboBox.Size = new System.Drawing.Size(165, 33);
            this.chooseDeptComboBox.TabIndex = 76;
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
            this.salaryNumericUpDown.TabIndex = 73;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(684, 100);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(68, 25);
            this.salaryLabel.TabIndex = 91;
            this.salaryLabel.Text = "Salary";
            // 
            // chooseTeamLabel
            // 
            this.chooseTeamLabel.AutoSize = true;
            this.chooseTeamLabel.Location = new System.Drawing.Point(883, 200);
            this.chooseTeamLabel.Name = "chooseTeamLabel";
            this.chooseTeamLabel.Size = new System.Drawing.Size(137, 25);
            this.chooseTeamLabel.TabIndex = 90;
            this.chooseTeamLabel.Text = "Choose Team";
            // 
            // chooseTeamComboBox
            // 
            this.chooseTeamComboBox.Enabled = false;
            this.chooseTeamComboBox.FormattingEnabled = true;
            this.chooseTeamComboBox.Location = new System.Drawing.Point(1036, 197);
            this.chooseTeamComboBox.Name = "chooseTeamComboBox";
            this.chooseTeamComboBox.Size = new System.Drawing.Size(165, 33);
            this.chooseTeamComboBox.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 89;
            this.label3.Text = "Join Date";
            // 
            // joinDateDateTimePicker
            // 
            this.joinDateDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.joinDateDateTimePicker.Location = new System.Drawing.Point(386, 337);
            this.joinDateDateTimePicker.Name = "joinDateDateTimePicker";
            this.joinDateDateTimePicker.Size = new System.Drawing.Size(274, 30);
            this.joinDateDateTimePicker.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 88;
            this.label2.Text = "Date of Birth";
            // 
            // DOBDateTimePicker
            // 
            this.DOBDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DOBDateTimePicker.Location = new System.Drawing.Point(43, 337);
            this.DOBDateTimePicker.MaxDate = new System.DateTime(2030, 12, 25, 23, 59, 59, 0);
            this.DOBDateTimePicker.Name = "DOBDateTimePicker";
            this.DOBDateTimePicker.Size = new System.Drawing.Size(274, 30);
            this.DOBDateTimePicker.TabIndex = 71;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(386, 128);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(274, 30);
            this.lastNameTB.TabIndex = 68;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(381, 100);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.lastNameLabel.TabIndex = 86;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(38, 100);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.firstNameLabel.TabIndex = 85;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(43, 128);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(274, 30);
            this.firstNameTB.TabIndex = 67;
            // 
            // EditProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.defaultPictureBox);
            this.Controls.Add(this.ResetBtn);
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
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.profilePictureBox);
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
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditProfile";
            this.Size = new System.Drawing.Size(1207, 877);
            this.Load += new System.EventHandler(this.EditProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.choosePositionGroupBox.ResumeLayout(false);
            this.choosePositionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip passInfoToolTip;
        private System.Windows.Forms.Label passInfoLabel;
        private System.Windows.Forms.PictureBox defaultPictureBox;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.TextBox pfpFileNameTextBox;
        private System.Windows.Forms.LinkLabel showLinkLabel;
        private System.Windows.Forms.Label salaryErrorLabel;
        private System.Windows.Forms.Label chooseDeptErrorLabel;
        private System.Windows.Forms.Label chooseTeamErrorLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.TextBox empIdTB;
        private System.Windows.Forms.Label empIDLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.RadioButton regularEmpRadioButton;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.GroupBox choosePositionGroupBox;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.RadioButton teamLeadRadioButton;
        private System.Windows.Forms.RadioButton deptHeadRadioButton;
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
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTB;
    }
}
