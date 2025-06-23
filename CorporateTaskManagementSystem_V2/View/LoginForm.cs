using CorporateTaskManagementSystem_V2.Controller;
using CorporateTaskManagementSystem_V2.Model;
using System;
using System.Windows.Forms;
using System.Net.Mail;

namespace CorporateTaskManagementSystem_V2.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                MailAddress addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string empEmail = emailTB.Text.Trim();
            string empPassword = passwordMaskedTextBox.Text.Trim();

            // Validate email format
            if( IsValidEmail(empEmail) == false)
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // this is a test edit for tb01 branch
            // this is edit from sh02 branch
            LoginController lgc = new LoginController();
            Login login = lgc.SearchLogin(empEmail);

            if (login != null)
            {
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
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
