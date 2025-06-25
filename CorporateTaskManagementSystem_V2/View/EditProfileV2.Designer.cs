namespace CorporateTaskManagementSystem_V2.View
{
    partial class EditProfileV2
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
            this.teamLeadRadioButton = new System.Windows.Forms.RadioButton();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.pfpFileNameTextBox = new System.Windows.Forms.TextBox();
            this.passInfoLabel = new System.Windows.Forms.Label();
            this.showLinkLabel = new System.Windows.Forms.LinkLabel();
            this.salaryErrorLabel = new System.Windows.Forms.Label();
            this.chooseDeptErrorLabel = new System.Windows.Forms.Label();
            this.chooseTeamErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.deptHeadRadioButton = new System.Windows.Forms.RadioButton();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.empIdTB = new System.Windows.Forms.TextBox();
            this.empIDLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.passInfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.choosePositionGroupBox = new System.Windows.Forms.GroupBox();
            this.regularEmpRadioButton = new System.Windows.Forms.RadioButton();
            this.chooseDeptComboBox = new System.Windows.Forms.ComboBox();
            this.salaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.chooseTeamLabel = new System.Windows.Forms.Label();
            this.chooseTeamComboBox = new System.Windows.Forms.ComboBox();
            this.chooseDept = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.joinDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.defaultPictureBox = new System.Windows.Forms.PictureBox();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.choosePositionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
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
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(460, 518);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(89, 32);
            this.ResetBtn.TabIndex = 121;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click_1);
            // 
            // pfpFileNameTextBox
            // 
            this.pfpFileNameTextBox.Location = new System.Drawing.Point(926, 447);
            this.pfpFileNameTextBox.Name = "pfpFileNameTextBox";
            this.pfpFileNameTextBox.Size = new System.Drawing.Size(100, 30);
            this.pfpFileNameTextBox.TabIndex = 145;
            this.pfpFileNameTextBox.Visible = false;
            // 
            // passInfoLabel
            // 
            this.passInfoLabel.AutoSize = true;
            this.passInfoLabel.Location = new System.Drawing.Point(607, 235);
            this.passInfoLabel.Name = "passInfoLabel";
            this.passInfoLabel.Size = new System.Drawing.Size(30, 25);
            this.passInfoLabel.TabIndex = 144;
            this.passInfoLabel.Text = "(i)";
            this.passInfoToolTip.SetToolTip(this.passInfoLabel, "Has minimum 8 characters in length.\r\nAt least one uppercase English letter.\r\nAt l" +
        "east one lowercase English letter. \r\nAt least one digit.\r\nAt least one special c" +
        "haracter.\r\n\r\n");
            // 
            // showLinkLabel
            // 
            this.showLinkLabel.AutoSize = true;
            this.showLinkLabel.Location = new System.Drawing.Point(643, 265);
            this.showLinkLabel.Name = "showLinkLabel";
            this.showLinkLabel.Size = new System.Drawing.Size(62, 25);
            this.showLinkLabel.TabIndex = 143;
            this.showLinkLabel.TabStop = true;
            this.showLinkLabel.Text = "Show";
            this.showLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showLinkLabel_LinkClicked_1);
            // 
            // salaryErrorLabel
            // 
            this.salaryErrorLabel.AutoEllipsis = true;
            this.salaryErrorLabel.AutoSize = true;
            this.salaryErrorLabel.BackColor = System.Drawing.Color.Brown;
            this.salaryErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salaryErrorLabel.Location = new System.Drawing.Point(1059, 454);
            this.salaryErrorLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.salaryErrorLabel.Name = "salaryErrorLabel";
            this.salaryErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.salaryErrorLabel.TabIndex = 142;
            this.salaryErrorLabel.Visible = false;
            // 
            // chooseDeptErrorLabel
            // 
            this.chooseDeptErrorLabel.AutoEllipsis = true;
            this.chooseDeptErrorLabel.AutoSize = true;
            this.chooseDeptErrorLabel.BackColor = System.Drawing.Color.Brown;
            this.chooseDeptErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDeptErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chooseDeptErrorLabel.Location = new System.Drawing.Point(884, 337);
            this.chooseDeptErrorLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.chooseDeptErrorLabel.Name = "chooseDeptErrorLabel";
            this.chooseDeptErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.chooseDeptErrorLabel.TabIndex = 141;
            this.chooseDeptErrorLabel.Visible = false;
            // 
            // chooseTeamErrorLabel
            // 
            this.chooseTeamErrorLabel.AutoEllipsis = true;
            this.chooseTeamErrorLabel.AutoSize = true;
            this.chooseTeamErrorLabel.BackColor = System.Drawing.Color.Brown;
            this.chooseTeamErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseTeamErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chooseTeamErrorLabel.Location = new System.Drawing.Point(884, 253);
            this.chooseTeamErrorLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.chooseTeamErrorLabel.Name = "chooseTeamErrorLabel";
            this.chooseTeamErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.chooseTeamErrorLabel.TabIndex = 140;
            this.chooseTeamErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoEllipsis = true;
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.BackColor = System.Drawing.Color.Brown;
            this.passwordErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordErrorLabel.Location = new System.Drawing.Point(363, 298);
            this.passwordErrorLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.passwordErrorLabel.TabIndex = 139;
            this.passwordErrorLabel.Visible = false;
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoEllipsis = true;
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.BackColor = System.Drawing.Color.Brown;
            this.emailErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailErrorLabel.Location = new System.Drawing.Point(20, 294);
            this.emailErrorLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.emailErrorLabel.TabIndex = 138;
            this.emailErrorLabel.Visible = false;
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoEllipsis = true;
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.BackColor = System.Drawing.Color.Brown;
            this.lastNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(363, 189);
            this.lastNameErrorLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.lastNameErrorLabel.TabIndex = 137;
            this.lastNameErrorLabel.Visible = false;
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
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoEllipsis = true;
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.BackColor = System.Drawing.Color.Brown;
            this.firstNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(20, 193);
            this.firstNameErrorLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.firstNameErrorLabel.TabIndex = 136;
            this.firstNameErrorLabel.Visible = false;
            // 
            // empIdTB
            // 
            this.empIdTB.Enabled = false;
            this.empIdTB.Location = new System.Drawing.Point(141, 85);
            this.empIdTB.Name = "empIdTB";
            this.empIdTB.Size = new System.Drawing.Size(153, 30);
            this.empIdTB.TabIndex = 135;
            // 
            // empIDLabel
            // 
            this.empIDLabel.AutoSize = true;
            this.empIDLabel.Location = new System.Drawing.Point(15, 85);
            this.empIDLabel.Name = "empIDLabel";
            this.empIDLabel.Size = new System.Drawing.Size(123, 25);
            this.empIDLabel.TabIndex = 134;
            this.empIDLabel.Text = "Employee ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(469, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 34);
            this.label8.TabIndex = 133;
            this.label8.Text = "Edit Profile";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(358, 233);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordLabel.TabIndex = 132;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(363, 261);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(274, 30);
            this.passwordTB.TabIndex = 113;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(20, 261);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(274, 30);
            this.emailTB.TabIndex = 112;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(15, 233);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(60, 25);
            this.emailLabel.TabIndex = 131;
            this.emailLabel.Text = "Email";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(555, 518);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(89, 32);
            this.UpdateBtn.TabIndex = 122;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click_1);
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(937, 483);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(89, 32);
            this.uploadBtn.TabIndex = 120;
            this.uploadBtn.Text = "upload";
            this.passInfoToolTip.SetToolTip(this.uploadBtn, "Only *png images are allowed");
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click_1);
            this.uploadBtn.MouseHover += new System.EventHandler(this.uploadBtn_MouseHover);
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
            // passInfoToolTip
            // 
            this.passInfoToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // choosePositionGroupBox
            // 
            this.choosePositionGroupBox.Controls.Add(this.adminRadioButton);
            this.choosePositionGroupBox.Controls.Add(this.teamLeadRadioButton);
            this.choosePositionGroupBox.Controls.Add(this.regularEmpRadioButton);
            this.choosePositionGroupBox.Controls.Add(this.deptHeadRadioButton);
            this.choosePositionGroupBox.Enabled = false;
            this.choosePositionGroupBox.Location = new System.Drawing.Point(856, 75);
            this.choosePositionGroupBox.Name = "choosePositionGroupBox";
            this.choosePositionGroupBox.Size = new System.Drawing.Size(324, 111);
            this.choosePositionGroupBox.TabIndex = 117;
            this.choosePositionGroupBox.TabStop = false;
            this.choosePositionGroupBox.Text = "Choose Position";
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
            // chooseDeptComboBox
            // 
            this.chooseDeptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseDeptComboBox.Enabled = false;
            this.chooseDeptComboBox.FormattingEnabled = true;
            this.chooseDeptComboBox.Location = new System.Drawing.Point(1013, 297);
            this.chooseDeptComboBox.Name = "chooseDeptComboBox";
            this.chooseDeptComboBox.Size = new System.Drawing.Size(165, 33);
            this.chooseDeptComboBox.TabIndex = 119;
            // 
            // salaryNumericUpDown
            // 
            this.salaryNumericUpDown.Enabled = false;
            this.salaryNumericUpDown.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.salaryNumericUpDown.Location = new System.Drawing.Point(666, 156);
            this.salaryNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.salaryNumericUpDown.Name = "salaryNumericUpDown";
            this.salaryNumericUpDown.Size = new System.Drawing.Size(165, 30);
            this.salaryNumericUpDown.TabIndex = 116;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(661, 128);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(68, 25);
            this.salaryLabel.TabIndex = 128;
            this.salaryLabel.Text = "Salary";
            // 
            // chooseTeamLabel
            // 
            this.chooseTeamLabel.AutoSize = true;
            this.chooseTeamLabel.Location = new System.Drawing.Point(860, 228);
            this.chooseTeamLabel.Name = "chooseTeamLabel";
            this.chooseTeamLabel.Size = new System.Drawing.Size(137, 25);
            this.chooseTeamLabel.TabIndex = 127;
            this.chooseTeamLabel.Text = "Choose Team";
            // 
            // chooseTeamComboBox
            // 
            this.chooseTeamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseTeamComboBox.Enabled = false;
            this.chooseTeamComboBox.FormattingEnabled = true;
            this.chooseTeamComboBox.Location = new System.Drawing.Point(1013, 225);
            this.chooseTeamComboBox.Name = "chooseTeamComboBox";
            this.chooseTeamComboBox.Size = new System.Drawing.Size(165, 33);
            this.chooseTeamComboBox.TabIndex = 118;
            // 
            // chooseDept
            // 
            this.chooseDept.AutoSize = true;
            this.chooseDept.Location = new System.Drawing.Point(860, 300);
            this.chooseDept.Name = "chooseDept";
            this.chooseDept.Size = new System.Drawing.Size(132, 25);
            this.chooseDept.TabIndex = 129;
            this.chooseDept.Text = "Choose Dept.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 126;
            this.label3.Text = "Join Date";
            // 
            // joinDateDateTimePicker
            // 
            this.joinDateDateTimePicker.Enabled = false;
            this.joinDateDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.joinDateDateTimePicker.Location = new System.Drawing.Point(363, 365);
            this.joinDateDateTimePicker.Name = "joinDateDateTimePicker";
            this.joinDateDateTimePicker.Size = new System.Drawing.Size(274, 30);
            this.joinDateDateTimePicker.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 125;
            this.label2.Text = "Date of Birth";
            // 
            // DOBDateTimePicker
            // 
            this.DOBDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DOBDateTimePicker.Location = new System.Drawing.Point(20, 365);
            this.DOBDateTimePicker.MaxDate = new System.DateTime(2030, 12, 25, 23, 59, 59, 0);
            this.DOBDateTimePicker.Name = "DOBDateTimePicker";
            this.DOBDateTimePicker.Size = new System.Drawing.Size(274, 30);
            this.DOBDateTimePicker.TabIndex = 114;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(363, 156);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(274, 30);
            this.lastNameTB.TabIndex = 111;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(358, 128);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.lastNameLabel.TabIndex = 124;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(15, 128);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.firstNameLabel.TabIndex = 123;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(20, 156);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(274, 30);
            this.firstNameTB.TabIndex = 110;
            // 
            // defaultPictureBox
            // 
            this.defaultPictureBox.Image = global::CorporateTaskManagementSystem_V2.Properties.Resources.defaultPfpImage;
            this.defaultPictureBox.Location = new System.Drawing.Point(998, 414);
            this.defaultPictureBox.Name = "defaultPictureBox";
            this.defaultPictureBox.Size = new System.Drawing.Size(28, 27);
            this.defaultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defaultPictureBox.TabIndex = 146;
            this.defaultPictureBox.TabStop = false;
            this.defaultPictureBox.Visible = false;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = global::CorporateTaskManagementSystem_V2.Properties.Resources.defaultPfpImage;
            this.profilePictureBox.Location = new System.Drawing.Point(1032, 365);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(148, 144);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 130;
            this.profilePictureBox.TabStop = false;
            // 
            // EditProfileV2
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
            this.Controls.Add(this.chooseDeptComboBox);
            this.Controls.Add(this.salaryNumericUpDown);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.chooseTeamLabel);
            this.Controls.Add(this.chooseTeamComboBox);
            this.Controls.Add(this.chooseDept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.joinDateDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DOBDateTimePicker);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditProfileV2";
            this.Size = new System.Drawing.Size(1207, 877);
            this.Load += new System.EventHandler(this.EditProfileV2_Load);
            this.choosePositionGroupBox.ResumeLayout(false);
            this.choosePositionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton teamLeadRadioButton;
        private System.Windows.Forms.PictureBox defaultPictureBox;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.TextBox pfpFileNameTextBox;
        private System.Windows.Forms.Label passInfoLabel;
        private System.Windows.Forms.ToolTip passInfoToolTip;
        private System.Windows.Forms.LinkLabel showLinkLabel;
        private System.Windows.Forms.Label salaryErrorLabel;
        private System.Windows.Forms.Label chooseDeptErrorLabel;
        private System.Windows.Forms.Label chooseTeamErrorLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.RadioButton deptHeadRadioButton;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.TextBox empIdTB;
        private System.Windows.Forms.Label empIDLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.GroupBox choosePositionGroupBox;
        private System.Windows.Forms.RadioButton regularEmpRadioButton;
        private System.Windows.Forms.ComboBox chooseDeptComboBox;
        private System.Windows.Forms.NumericUpDown salaryNumericUpDown;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label chooseTeamLabel;
        private System.Windows.Forms.ComboBox chooseTeamComboBox;
        private System.Windows.Forms.Label chooseDept;
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
