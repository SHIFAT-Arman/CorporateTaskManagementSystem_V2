using System;
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
    }
}
