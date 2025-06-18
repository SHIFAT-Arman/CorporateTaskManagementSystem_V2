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
        }

        private void departmentsBtn_Click(object sender, EventArgs e)
        {
            adminEmployee1.Visible = false;
            adminDepartment1.Visible = true;
            adminTask1.Visible = false;
            adminTeam1.Visible = false;
        }

        private void teamsBtn_Click(object sender, EventArgs e)
        {
            adminEmployee1.Visible = false;
            adminDepartment1.Visible = false;
            adminTask1.Visible = false;
            adminTeam1.Visible = true;
        }

        private void tasksBtn_Click(object sender, EventArgs e)
        {
            adminEmployee1.Visible = false;
            adminDepartment1.Visible = false;
            adminTask1.Visible = true;
            adminTeam1.Visible = false;
        }
    }
}
