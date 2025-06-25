namespace CorporateTaskManagementSystem_V2.View
{
    partial class DashboardEmployee
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
            this.defaultPictureBox = new System.Windows.Forms.PictureBox();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.EditProfileBtn = new System.Windows.Forms.Button();
            this.tasksBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pfpPictureBox = new System.Windows.Forms.PictureBox();
            this.employeeTask1 = new CorporateTaskManagementSystem_V2.View.EmployeeTask();
            this.editProfileV21 = new CorporateTaskManagementSystem_V2.View.EditProfileV2();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultPictureBox
            // 
            this.defaultPictureBox.Image = global::CorporateTaskManagementSystem_V2.Properties.Resources.defaultPfpImage;
            this.defaultPictureBox.Location = new System.Drawing.Point(233, 99);
            this.defaultPictureBox.Name = "defaultPictureBox";
            this.defaultPictureBox.Size = new System.Drawing.Size(28, 27);
            this.defaultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defaultPictureBox.TabIndex = 76;
            this.defaultPictureBox.TabStop = false;
            this.defaultPictureBox.Visible = false;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(91, 731);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(100, 57);
            this.LogoutBtn.TabIndex = 68;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // EditProfileBtn
            // 
            this.EditProfileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.EditProfileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.EditProfileBtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProfileBtn.Location = new System.Drawing.Point(33, 675);
            this.EditProfileBtn.Name = "EditProfileBtn";
            this.EditProfileBtn.Size = new System.Drawing.Size(215, 43);
            this.EditProfileBtn.TabIndex = 74;
            this.EditProfileBtn.Text = "Edit Profile";
            this.EditProfileBtn.UseVisualStyleBackColor = true;
            this.EditProfileBtn.Click += new System.EventHandler(this.editProfile_Click);
            // 
            // tasksBtn
            // 
            this.tasksBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.tasksBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.tasksBtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksBtn.Location = new System.Drawing.Point(33, 474);
            this.tasksBtn.Name = "tasksBtn";
            this.tasksBtn.Size = new System.Drawing.Size(215, 43);
            this.tasksBtn.TabIndex = 69;
            this.tasksBtn.Text = "Tasks";
            this.tasksBtn.UseVisualStyleBackColor = true;
            this.tasksBtn.Click += new System.EventHandler(this.taskBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(101, 56);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 24);
            this.nameLabel.TabIndex = 70;
            this.nameLabel.Text = "Name";
            // 
            // pfpPictureBox
            // 
            this.pfpPictureBox.Image = global::CorporateTaskManagementSystem_V2.Properties.Resources.defaultPfpImage;
            this.pfpPictureBox.Location = new System.Drawing.Point(53, 99);
            this.pfpPictureBox.Name = "pfpPictureBox";
            this.pfpPictureBox.Size = new System.Drawing.Size(174, 169);
            this.pfpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfpPictureBox.TabIndex = 71;
            this.pfpPictureBox.TabStop = false;
            // 
            // employeeTask1
            // 
            this.employeeTask1.BackColor = System.Drawing.Color.AliceBlue;
            this.employeeTask1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeTask1.Location = new System.Drawing.Point(277, 0);
            this.employeeTask1.Name = "employeeTask1";
            this.employeeTask1.Size = new System.Drawing.Size(1207, 896);
            this.employeeTask1.TabIndex = 78;
            // 
            // editProfileV21
            // 
            this.editProfileV21.BackColor = System.Drawing.Color.AliceBlue;
            this.editProfileV21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfileV21.Location = new System.Drawing.Point(277, 0);
            this.editProfileV21.Name = "editProfileV21";
            this.editProfileV21.Size = new System.Drawing.Size(1207, 896);
            this.editProfileV21.TabIndex = 77;
            // 
            // DashboardEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1496, 896);
            this.Controls.Add(this.defaultPictureBox);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.EditProfileBtn);
            this.Controls.Add(this.tasksBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pfpPictureBox);
            this.Controls.Add(this.employeeTask1);
            this.Controls.Add(this.editProfileV21);
            this.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DashboardEmployee";
            this.Text = "DashboardEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.defaultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox defaultPictureBox;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button EditProfileBtn;
        private System.Windows.Forms.Button tasksBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox pfpPictureBox;
        private EditProfileV2 editProfileV21;
        private EmployeeTask employeeTask1;
    }
}