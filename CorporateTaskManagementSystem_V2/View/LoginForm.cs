using CorporateTaskManagementSystem_V2.Controller;
using CorporateTaskManagementSystem_V2.Model;
using System;
using System.Net.Mail;
using System.Windows.Forms;
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
                // Check if the email address is in a valid format
                if (addr.Address == email)
                {
                    if (email.Contains("emp") || email.Contains("dept") || email.Contains("admin"))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool IsValidEmpId(string empId)
        {
            if(empId.Contains("E-") && empId != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string empId = IdTB.Text.Trim();
                string empEmail = emailTB.Text.Trim();
                string empPassword = passwordMaskedTextBox.Text.Trim();
                Session.LoggedInEmpId = empId;

                //validate ID format
                if(IsValidEmpId(empId) == false)
                {
                    MessageBox.Show("Please enter a valid Employee ID (format: E-XXX).", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate email format
                if (IsValidEmail(empEmail) == false)
                {
                    MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(empId) || string.IsNullOrEmpty(empEmail) || string.IsNullOrEmpty(empPassword))
                {
                    MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // this is a test edit for tb01 branch
                // this is edit from sh02 branch
                LoginController lgc = new LoginController();
                Login login = lgc.SearchLogin(empId);

                if (login != null)
                {

                    if (login.EmpId.Equals(empId) && login.EmpEmail.Equals(empEmail) && login.EmpPassword.Equals(empPassword) && login.EmpPosition.Equals("Admin"))
                    {
                        this.Hide();
                        DashboardAdmin dashboardAdmin = new DashboardAdmin();
                        dashboardAdmin.Show();
                        dashboardAdmin.LoadLoginInfo(empId);

                    }
                    else if (login.EmpId.Equals(empId) && login.EmpEmail.Equals(empEmail) && login.EmpPassword.Equals(empPassword) && login.EmpPosition.Equals("Department Head"))
                    {
                        this.Hide();
                        DashboardDepartmentHead dashboardDepartmentHead = new DashboardDepartmentHead();
                        dashboardDepartmentHead.Show();
                        dashboardDepartmentHead.LoadLoginInfo(empId);
                    }
                    else if (login.EmpId.Equals(empId) && login.EmpEmail.Equals(empEmail) && login.EmpPassword.Equals(empPassword) && login.EmpPosition.Equals("Regular Employee"))
                    {
                        this.Hide();
                        DashboardEmployee dashboardEmployee = new DashboardEmployee();
                        dashboardEmployee.Show();
                        dashboardEmployee.LoadLoginInfo(empId);
                    }
                    else if (login.EmpId.Equals(empId) && login.EmpEmail.Equals(empEmail) && login.EmpPassword.Equals(empPassword) && login.EmpPosition.Equals("Team Lead"))
                    {
                        this.Hide();
                        DashboardTeamLead dashboardTeamLead = new DashboardTeamLead();
                        dashboardTeamLead.Show();
                        dashboardTeamLead.LoadLoginInfo(empId);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Credentials!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (showLinkLabel.Text == "Show")
            {
                passwordMaskedTextBox.PasswordChar = '\0';
                showLinkLabel.Text = "Hide";
            }
            else
            {
                passwordMaskedTextBox.PasswordChar = '*';
                showLinkLabel.Text = "Show";
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
