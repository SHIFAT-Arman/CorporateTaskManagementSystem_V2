using CorporateTaskManagementSystem_V2.Controller;
using CorporateTaskManagementSystem_V2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorporateTaskManagementSystem_V2.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string empEmail = emailTB.Text.Trim();
            string empPassword = passwordMaskedTextBox.Text.Trim();

            // this is a test edit for tb01 branch
            LoginController lgc = new LoginController();
            Login login = lgc.SearchLogin(empEmail);


            if (login.EmpEmail.Contains("admin"))
            {
                login.EmpPosition = "Admin";
            }
            else if (login.EmpEmail.Contains("dept"))
            {
                login.EmpPosition = "Department Head";
            }
            else if (login.EmpEmail.Contains("emp"))
            {
                login.EmpPosition = "Regular Employee";
            }


            if (login != null)
            {

                if (login.EmpEmail.Equals(empEmail) && login.EmpPassword.Equals(empPassword) && login.EmpPosition.Equals("Admin"))
                {
                    this.Hide();
                    DashboardAdmin dashboardAdmin = new DashboardAdmin();
                    dashboardAdmin.Show();
                }
                else if (login.EmpEmail.Equals(empEmail) && login.EmpPassword.Equals(empPassword) && login.EmpPosition.Equals("Department Head"))
                {
                    this.Hide();
                    DashboardDepartmentHead dashboardDepartmentHead = new DashboardDepartmentHead();
                    dashboardDepartmentHead.Show();
                }
                else if (login.EmpEmail.Equals(empEmail) && login.EmpPassword.Equals(empPassword) && login.EmpPosition.Equals("Regular Employee"))
                {
                    this.Hide();
                    DashboardEmployee dashboardEmployee = new DashboardEmployee();
                    dashboardEmployee.Show();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
