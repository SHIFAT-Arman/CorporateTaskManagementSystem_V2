using CorporateTaskManagementSystem_V2.Controller;
using CorporateTaskManagementSystem_V2.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CorporateTaskManagementSystem_V2.View
{
    public partial class DashboardEmployee : Form
    {
        public DashboardEmployee()
        {
            InitializeComponent();
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            employeeTask1.Visible = false;
            editProfileV21.Visible = true;

        }

        private void taskBtn_Click(object sender, EventArgs e)
        {
            employeeTask1.Visible = true;
            editProfileV21.Visible = false;


        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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

        private void DashboardEmployee_Load(object sender, EventArgs e)
        {
            positionLabel.Text = "Regular Employee";
        }
    }
}
