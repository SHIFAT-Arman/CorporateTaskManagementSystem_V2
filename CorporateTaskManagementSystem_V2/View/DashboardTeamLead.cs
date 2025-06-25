using CorporateTaskManagementSystem_V2.Controller;
using CorporateTaskManagementSystem_V2.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace CorporateTaskManagementSystem_V2.View
{
    public partial class DashboardTeamLead : Form
    {
        public DashboardTeamLead()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void editProfileBtn_Click(object sender, System.EventArgs e)
        {
            editProfileV21.Visible = true;
            adminTask1.Visible = false;
            adminEmployee1.Visible = false;
        }

        private void tasksBtn_Click(object sender, System.EventArgs e)
        {
            editProfileV21.Visible = false;
            adminTask1.Visible = true;
            adminEmployee1.Visible = false;
        }

        private void employeesBtn_Click(object sender, System.EventArgs e)
        {
            editProfileV21.Visible = false;
            adminTask1.Visible = false;
            adminEmployee1.Visible = true;

            adminEmployee1.DeleteBtnVisibility = false; // Hide the delete button for Team Lead
            adminEmployee1.UpdateBtnVisibility = false;
            adminEmployee1.AddBtnVisibility = false;
            adminEmployee1.ResetBtnVisibility = false;
        }

        public void LoadLoginInfo(string empId)
        {
            EmployeeController employeeController = new EmployeeController();
            //Employee employee = new Employee();
            //employee.EmpId = empId;

            //employeeController.SearchEmployee(empId);
            List<Employee> list = employeeController.GetDataFromLogin(empId);
            Console.WriteLine(list[0].EmpFirstName);


            if (list[0].EmpPfp != null)
            {
                using (MemoryStream ms = new MemoryStream(list[0].EmpPfp))
                {
                    pfpPictureBox.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pfpPictureBox.Image = defaultPictureBox.Image;
            }
            nameLabel.Text = list[0].EmpFirstName;
        }

        private void DashboardTeamLead_Load(object sender, System.EventArgs e)
        {
            positionLabel.Text = "Team Lead";
            
        }
    }
}
