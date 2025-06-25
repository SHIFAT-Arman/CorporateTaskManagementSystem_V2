namespace CorporateTaskManagementSystem_V2.View
{
    partial class DashboardAdmin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tasksBtn = new System.Windows.Forms.Button();
            this.teamsBtn = new System.Windows.Forms.Button();
            this.departmentsBtn = new System.Windows.Forms.Button();
            this.EditProfileBtn = new System.Windows.Forms.Button();
            this.employeesBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.defaultPictureBox = new System.Windows.Forms.PictureBox();
            this.pfpPictureBox = new System.Windows.Forms.PictureBox();
            this.adminDepartment1 = new CorporateTaskManagementSystem_V2.View.AdminDepartment();
            this.editProfileV21 = new CorporateTaskManagementSystem_V2.View.EditProfileV2();
            this.adminEmployee1 = new CorporateTaskManagementSystem_V2.View.AdminEmployee();
            this.adminTask1 = new CorporateTaskManagementSystem_V2.View.AdminTask();
            this.adminTeam1 = new CorporateTaskManagementSystem_V2.View.AdminTeam();
            this.positionLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1496, 896);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.adminTeam1);
            this.panel3.Controls.Add(this.adminDepartment1);
            this.panel3.Controls.Add(this.editProfileV21);
            this.panel3.Controls.Add(this.adminEmployee1);
            this.panel3.Controls.Add(this.adminTask1);
            this.panel3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1549, 896);
            this.panel3.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(102, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 24);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // tasksBtn
            // 
            this.tasksBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.tasksBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.tasksBtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksBtn.Location = new System.Drawing.Point(34, 462);
            this.tasksBtn.Name = "tasksBtn";
            this.tasksBtn.Size = new System.Drawing.Size(215, 43);
            this.tasksBtn.TabIndex = 1;
            this.tasksBtn.Text = "Tasks";
            this.tasksBtn.UseVisualStyleBackColor = true;
            this.tasksBtn.Click += new System.EventHandler(this.tasksBtn_Click);
            // 
            // teamsBtn
            // 
            this.teamsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.teamsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.teamsBtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsBtn.Location = new System.Drawing.Point(34, 364);
            this.teamsBtn.Name = "teamsBtn";
            this.teamsBtn.Size = new System.Drawing.Size(215, 43);
            this.teamsBtn.TabIndex = 3;
            this.teamsBtn.Text = "Teams";
            this.teamsBtn.UseVisualStyleBackColor = true;
            this.teamsBtn.Click += new System.EventHandler(this.teamsBtn_Click);
            // 
            // departmentsBtn
            // 
            this.departmentsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.departmentsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.departmentsBtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentsBtn.Location = new System.Drawing.Point(34, 315);
            this.departmentsBtn.Name = "departmentsBtn";
            this.departmentsBtn.Size = new System.Drawing.Size(215, 43);
            this.departmentsBtn.TabIndex = 4;
            this.departmentsBtn.Text = "Departments";
            this.departmentsBtn.UseVisualStyleBackColor = true;
            this.departmentsBtn.Click += new System.EventHandler(this.departmentsBtn_Click);
            // 
            // EditProfileBtn
            // 
            this.EditProfileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.EditProfileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.EditProfileBtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProfileBtn.Location = new System.Drawing.Point(34, 663);
            this.EditProfileBtn.Name = "EditProfileBtn";
            this.EditProfileBtn.Size = new System.Drawing.Size(215, 43);
            this.EditProfileBtn.TabIndex = 5;
            this.EditProfileBtn.Text = "Edit Profile";
            this.EditProfileBtn.UseVisualStyleBackColor = true;
            this.EditProfileBtn.Click += new System.EventHandler(this.EditProfileBtn_Click);
            // 
            // employeesBtn
            // 
            this.employeesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.employeesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.employeesBtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesBtn.Location = new System.Drawing.Point(34, 413);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Size = new System.Drawing.Size(215, 43);
            this.employeesBtn.TabIndex = 6;
            this.employeesBtn.Text = "Employees";
            this.employeesBtn.UseVisualStyleBackColor = true;
            this.employeesBtn.Click += new System.EventHandler(this.employeesBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(92, 719);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(100, 57);
            this.LogoutBtn.TabIndex = 1;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.positionLabel);
            this.panel1.Controls.Add(this.defaultPictureBox);
            this.panel1.Controls.Add(this.LogoutBtn);
            this.panel1.Controls.Add(this.employeesBtn);
            this.panel1.Controls.Add(this.EditProfileBtn);
            this.panel1.Controls.Add(this.departmentsBtn);
            this.panel1.Controls.Add(this.teamsBtn);
            this.panel1.Controls.Add(this.tasksBtn);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.pfpPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 896);
            this.panel1.TabIndex = 2;
            // 
            // defaultPictureBox
            // 
            this.defaultPictureBox.Image = global::CorporateTaskManagementSystem_V2.Properties.Resources.defaultPfpImage;
            this.defaultPictureBox.Location = new System.Drawing.Point(234, 87);
            this.defaultPictureBox.Name = "defaultPictureBox";
            this.defaultPictureBox.Size = new System.Drawing.Size(28, 27);
            this.defaultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defaultPictureBox.TabIndex = 67;
            this.defaultPictureBox.TabStop = false;
            this.defaultPictureBox.Visible = false;
            // 
            // pfpPictureBox
            // 
            this.pfpPictureBox.Image = global::CorporateTaskManagementSystem_V2.Properties.Resources.defaultPfpImage;
            this.pfpPictureBox.Location = new System.Drawing.Point(54, 87);
            this.pfpPictureBox.Name = "pfpPictureBox";
            this.pfpPictureBox.Size = new System.Drawing.Size(174, 169);
            this.pfpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfpPictureBox.TabIndex = 2;
            this.pfpPictureBox.TabStop = false;
            // 
            // adminDepartment1
            // 
            this.adminDepartment1.BackColor = System.Drawing.Color.AliceBlue;
            this.adminDepartment1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDepartment1.Location = new System.Drawing.Point(290, 0);
            this.adminDepartment1.Name = "adminDepartment1";
            this.adminDepartment1.Size = new System.Drawing.Size(1207, 877);
            this.adminDepartment1.TabIndex = 3;
            // 
            // editProfileV21
            // 
            this.editProfileV21.BackColor = System.Drawing.Color.AliceBlue;
            this.editProfileV21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfileV21.Location = new System.Drawing.Point(290, 0);
            this.editProfileV21.Name = "editProfileV21";
            this.editProfileV21.Size = new System.Drawing.Size(1207, 877);
            this.editProfileV21.TabIndex = 6;
            // 
            // adminEmployee1
            // 
            this.adminEmployee1.BackColor = System.Drawing.Color.AliceBlue;
            this.adminEmployee1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminEmployee1.Location = new System.Drawing.Point(290, 0);
            this.adminEmployee1.Name = "adminEmployee1";
            this.adminEmployee1.Size = new System.Drawing.Size(1206, 877);
            this.adminEmployee1.TabIndex = 2;
            // 
            // adminTask1
            // 
            this.adminTask1.BackColor = System.Drawing.Color.AliceBlue;
            this.adminTask1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTask1.Location = new System.Drawing.Point(290, 0);
            this.adminTask1.Name = "adminTask1";
            this.adminTask1.Size = new System.Drawing.Size(1206, 877);
            this.adminTask1.TabIndex = 5;
            // 
            // adminTeam1
            // 
            this.adminTeam1.BackColor = System.Drawing.Color.AliceBlue;
            this.adminTeam1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTeam1.Location = new System.Drawing.Point(290, 0);
            this.adminTeam1.Margin = new System.Windows.Forms.Padding(4);
            this.adminTeam1.Name = "adminTeam1";
            this.adminTeam1.Size = new System.Drawing.Size(1206, 877);
            this.adminTeam1.TabIndex = 4;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(88, 24);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(81, 24);
            this.positionLabel.TabIndex = 68;
            this.positionLabel.Text = "Position";
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 896);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardAdmin";
            this.Text = "DashboardAdmin";
            this.Load += new System.EventHandler(this.DashboardAdmin_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private AdminEmployee adminEmployee1;
        private AdminDepartment adminDepartment1;
        private AdminTeam adminTeam1;
        private AdminTask adminTask1;
        private System.Windows.Forms.PictureBox pfpPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button tasksBtn;
        private System.Windows.Forms.Button teamsBtn;
        private System.Windows.Forms.Button departmentsBtn;
        private System.Windows.Forms.Button EditProfileBtn;
        private System.Windows.Forms.Button employeesBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox defaultPictureBox;
        private EditProfileV2 editProfileV21;
        private System.Windows.Forms.Label positionLabel;
    }
}