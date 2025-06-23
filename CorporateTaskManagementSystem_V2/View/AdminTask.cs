using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorporateTaskManagementSystem_V2.Model;
using CorporateTaskManagementSystem_V2.Controller;
using System.Data.SqlClient;

namespace CorporateTaskManagementSystem_V2.View
{
    public partial class AdminTask : UserControl
    {
        private Departments deps = new Departments();
        private Teams teams = new Teams();
        public AdminTask()
        {
            InitializeComponent();
        }

        private void AdminTask_Load(object sender, EventArgs e)
        {
            TaskController tc = new TaskController();
            adminTaskGridView1.DataSource = tc.GetAllTask();

            departmentCombobox.DisplayMember = "DeptName";
            departmentCombobox.ValueMember = "DeptId";
            departmentCombobox.DataSource = deps.GetAllDept();
            assignedDt.Value = DateTime.Today;
        }

        private void RefreshTaskGrid()
        {
            TaskController tc = new TaskController();
            adminTaskGridView1.DataSource = tc.GetAllTask();
            adminTaskGridView1.Refresh();
        }
        private void LoadDepartments()
        {
            departmentCombobox.DisplayMember = "DeptName";
            departmentCombobox.ValueMember = "DeptId";
            departmentCombobox.DataSource = deps.GetAllDept();
            teamcomboBox1.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           //try
           // {
                string task = taskNameTextBox.Text;
                string taskId =null;
                string taskName = taskNameTextBox.Text;
                // DateTime taskAssignedDate = assignedDt.Text;

                DateTime taskAssignedDate;
                if(!DateTime.TryParse(assignedDt.Text,out taskAssignedDate))
                {
                    MessageBox.Show("enter valid date");
                    return;
                }
                string taskStatus="pending";
                string teamId = Convert.ToString( teamcomboBox1.SelectedValue);

                Model.Task t = new Model.Task(taskId, taskName, taskAssignedDate, taskStatus, teamId);
                TaskController tc = new TaskController();
                tc.AddTask(t);

                MessageBox.Show("Task added successfully");

                adminTaskGridView1.DataSource = tc.GetAllTask();
                adminTaskGridView1.Refresh();
            //}
          // catch(Exception exp)
          //  {
            //    MessageBox.Show(exp.StackTrace);    
          //  }
        }

        private void departmentCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentCombobox.SelectedValue != null && departmentCombobox.SelectedValue.ToString() != string.Empty)
            {
                string selectedDeptId = departmentCombobox.SelectedValue.ToString();
                SqlCommand cmd = new SqlDbDataAccess().GetQuery("SELECT teamId,teamName,teamCreationDate,deptId FROM Team Where deptId = @deptId");
                cmd.Parameters.AddWithValue("@deptId", selectedDeptId);

                teamcomboBox1.DisplayMember = "TeamName";
                teamcomboBox1.ValueMember = "TeamId";
                teamcomboBox1.DataSource = teams.GetData(cmd);
            }
        }
    }
}
