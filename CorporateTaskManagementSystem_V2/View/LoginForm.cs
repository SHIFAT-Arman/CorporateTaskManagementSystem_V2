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
            if(userIdTB.Text == "admin" && passwordMaskedTextBox.Text == "admin")
            {
                DashboardAdmin dashboardAdmin = new DashboardAdmin();
                dashboardAdmin.Show();
                this.Hide();
            }
            else if(userIdTB.Text == "employee" && passwordMaskedTextBox.Text == "employee123")
            {
                DashboardEmployee dashboardEmployee = new DashboardEmployee();
                dashboardEmployee.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User ID or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
