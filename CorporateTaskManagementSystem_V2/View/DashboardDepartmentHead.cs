using System.Windows.Forms;

namespace CorporateTaskManagementSystem_V2.View
{
    public partial class DashboardDepartmentHead : Form
    {
        public DashboardDepartmentHead()
        {
            InitializeComponent();
        }

        private void editProfileBtn_Click(object sender, System.EventArgs e)
        {
            editProfileV21.Visible = true;
            adminEmployee1.Visible = false;
            adminTeam1.Visible = false;
            adminTask1.Visible = false;
        }

        private void employeesBtn_Click(object sender, System.EventArgs e)
        {
            editProfileV21.Visible = false;
            adminEmployee1.Visible = true;
            adminTeam1.Visible = false;
            adminTask1.Visible = false;
        }

        private void teamsBtn_Click(object sender, System.EventArgs e)
        {
            editProfileV21.Visible = false;
            adminEmployee1.Visible = false;
            adminTeam1.Visible = true;
            adminTask1.Visible = false;
        }

        private void tasksBtn_Click(object sender, System.EventArgs e)
        {
            adminTask1.Visible = true;
            editProfileV21.Visible = false;
            adminEmployee1.Visible = false;
            adminTeam1.Visible = false;
        }

        private void DashboardDepartmentHead_Load(object sender, System.EventArgs e)
        {

        }
    }
}
