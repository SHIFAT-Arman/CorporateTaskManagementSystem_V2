using CorporateTaskManagementSystem_V2.Controller;
using CorporateTaskManagementSystem_V2.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CorporateTaskManagementSystem_V2.View
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            adminEmployee1.Visible = true;
            adminDepartment1.Visible = false;
            adminTask1.Visible = false;
            adminTeam1.Visible = false;
            //editProfile1.Visible = false;
        }

        private void departmentsBtn_Click(object sender, EventArgs e)
        {
            adminEmployee1.Visible = false;
            adminDepartment1.Visible = true;
            adminTask1.Visible = false;
            adminTeam1.Visible = false;
            //editProfile1.Visible = false;
        }

        private void teamsBtn_Click(object sender, EventArgs e)
        {
            adminEmployee1.Visible = false;
            adminDepartment1.Visible = false;
            adminTask1.Visible = false;
            adminTeam1.Visible = true;
            //editProfile1.Visible = false;
            editProfileV21.Visible = false;
        }

        private void tasksBtn_Click(object sender, EventArgs e)
        {
            adminEmployee1.Visible = false;
            adminDepartment1.Visible = false;
            adminTask1.Visible = true;
            adminTeam1.Visible = false;
            //editProfile1.Visible = false;
            editProfileV21.Visible = false;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        public void EditProfileBtn_Click(object sender, EventArgs e)
        {
            //editProfile1.Visible = true;
            adminEmployee1.Visible = false;
            adminDepartment1.Visible = false;
            adminTask1.Visible = false;
            adminTeam1.Visible = false;
            editProfileV21.Visible = true;

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



        public void DashboardAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
