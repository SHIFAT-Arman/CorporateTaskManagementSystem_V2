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
using System.Text.RegularExpressions;

namespace CorporateTaskManagementSystem_V2.View
{
    public partial class AdminTask : UserControl
    {
        
        private Departments deps = new Departments();
        private Teams teams = new Teams();

        TaskController tc = new TaskController();
        Teams tec = new Teams();
        private bool IsValidTaskFormat(string taskId)
        {
            string pattern = @"^T-\d{3}$";
            return Regex.IsMatch(taskId, pattern);
        }
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

            departmentCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            teamcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
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
           try
             {
            //string task = taskNameTextBox.Text;
            string taskName = taskNameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("task Name can not be empty");
                return;
            }
                string taskId = null;

                // DateTime taskAssignedDate = assignedDt.Text;

                DateTime taskAssignedDate;
                if (!DateTime.TryParse(assignedDt.Text, out taskAssignedDate))
                {
                    MessageBox.Show("enter valid date");
                    return;
                }
                if (taskAssignedDate.Date > DateTime.Today)
                {
                    MessageBox.Show("Assigned date can not be in future");
                return;
                }
                string taskStatus = "pending";
                string teamId = Convert.ToString(teamcomboBox1.SelectedValue);

                Model.Task t = new Model.Task(taskId, taskName, taskAssignedDate, taskStatus, teamId);
                TaskController tc = new TaskController();
                tc.AddTask(t);

                MessageBox.Show("Task added successfully");

                adminTaskGridView1.DataSource = tc.GetAllTask();
                adminTaskGridView1.Refresh();

                SearchTextBox.Clear();


            }
            catch(Exception exp)
             {
                MessageBox.Show(exp.StackTrace);    
             }
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

            else
            {
                teamcomboBox1.DataSource = null;
                teamcomboBox1.Enabled = false;
            }
        }

        private void adminTaskGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvr = adminTaskGridView1.Rows[e.RowIndex];
                taskNameTextBox.Text = dvr.Cells[1].Value.ToString();
                assignedDt.Value = DateTime.Parse(dvr.Cells[2].Value?.ToString() ?? DateTime.Today.ToString());
                //departmentCombobox.Text = dvr.Cells[3].Value.ToString();
                SearchTextBox.Text = dvr.Cells[0].Value.ToString();


                if (dvr.Cells[4].Value != null)
                {
                    string teamId = dvr.Cells[4].Value.ToString()??"";
                    Team selectedTeam = teams.SearchTeam(teamId);
                    if (selectedTeam != null)
                    {
                        departmentCombobox.SelectedValue = selectedTeam.DeptId;

                        SqlCommand cmd = new SqlDbDataAccess().GetQuery("SELECT teamId,teamName,teamCreationDate,deptId FROM Team Where deptId=@deptId;");
                        cmd.Parameters.AddWithValue("@deptId", selectedTeam.DeptId);

                        teamcomboBox1.DisplayMember = "TeamName";
                        teamcomboBox1.ValueMember = "TeamId";

                        teamcomboBox1.DataSource = teams.GetData(cmd);

                        teamcomboBox1.SelectedValue = teamId;
                        departmentCombobox.SelectedValue = selectedTeam.DeptId;

                    }



                }
            }
            
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminTaskSearchbtn_Click(object sender, EventArgs e)
        {
            try {
                string taskId = SearchTextBox.Text.Trim();
                if (!IsValidTaskFormat(taskId))
                {
                    MessageBox.Show("enter id followinf format T-123");
                    return;
                }


                TaskController tc = new TaskController();
                Model.Task t = tc.Search(taskId);

                if (t != null)
                {
                    List<Model.Task> foundtask = new List<Model.Task>();
                    foundtask.Add(t);

                    adminTaskGridView1.DataSource = foundtask;
                    MessageBox.Show("task found");
                    taskNameTextBox.Text = t.TaskName;
                    assignedDt.Value = t.TaskAssignedDate;

                    //string teamId = dvr.Cells[4].Value.ToString();
                    string teamId = departmentCombobox.Text;
                    Team selectedTeam = teams.SearchTeam(teamId);
                    if (selectedTeam != null)
                    {
                        departmentCombobox.SelectedValue = selectedTeam.DeptId;

                        SqlCommand cmd = new SqlDbDataAccess().GetQuery("SELECT teamId,teamName,teamCreationDate,deptId FROM Team Where deptId=@deptId;");
                        cmd.Parameters.AddWithValue("@deptId", selectedTeam.DeptId);

                        taskNameTextBox.Text = t.TaskName;
                        teamcomboBox1.DisplayMember = "TeamName";
                        teamcomboBox1.ValueMember = "TeamId";

                        teamcomboBox1.DataSource = teams.GetData(cmd);

                        teamcomboBox1.SelectedValue = teamId;
                        departmentCombobox.SelectedValue = selectedTeam.DeptId;

                    }
                }
                else
                {
                    MessageBox.Show("Task not found");
                }

                //adminTaskGridView1.DataSource = tc.GetAllTask();
                // adminTaskGridView1.Refresh();
                SearchTextBox.Clear();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.StackTrace);
            }
        }

        private void adminTaskDltbt_Click(object sender, EventArgs e)
        {
            try
            {
                string taskId = SearchTextBox.Text.Trim();
                if (!IsValidTaskFormat(taskId))
                {
                    MessageBox.Show("enter id following format T-123");
                }
                TaskController tc = new TaskController();

                Model.Task sf = tc.Search(taskId);
                if (sf == null)
                {
                    MessageBox.Show("task does not exist broski");

                }
                else
                {


                    tc.DeleteTask(taskId);



                    MessageBox.Show("task deleted");
                }
                adminTaskGridView1.DataSource = tc.GetAllTask();
                adminTaskGridView1.Refresh();
                SearchTextBox.Clear();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string taskId = SearchTextBox.Text.Trim();
                if (!IsValidTaskFormat(taskId))
                {
                    MessageBox.Show("enter id following format T-123");
                    return;
                }
                if (string.IsNullOrWhiteSpace(taskNameTextBox.Text))
                {
                    MessageBox.Show("please enter a task Name;");
                    return;
                }

                DateTime taskAssignedDate;
                //string task = taskNameTextBox.Text;
                //string taskId = null;

                TaskController tc = new TaskController();
                Model.Task foundstat = tc.Search(taskId);
                
                if (foundstat == null)
                {
                    MessageBox.Show("task does not exist, enter proper id to update");
                    return;
                }
                string taskName = taskNameTextBox.Text;
                // DateTime taskAssignedDate = assignedDt.Text;

                if (!DateTime.TryParse(assignedDt.Text, out taskAssignedDate))
                {
                    MessageBox.Show("enter valid date");
                    return;
                }
                if (taskAssignedDate.Date > DateTime.Today)
                {
                    MessageBox.Show("Assigned date can not be in future");
                    return;
                }

                //string taskStatus = "pending";
                string teamId = null;
                if (teamcomboBox1.SelectedValue !=null && !string.IsNullOrEmpty(teamcomboBox1.SelectedValue.ToString()))
                {
                    teamId = teamcomboBox1.SelectedValue.ToString();
                }

                Model.Task t = new Model.Task(taskId, taskName, taskAssignedDate, foundstat.TaskStatus, teamId);
                

                //Model.Task sf = tc.Search(taskId);
                
                tc.UpdateTask(t);

                MessageBox.Show("Task was updated");
                //adminTaskGridView1.DataSource = tc.GetAllTask();
                //adminTaskGridView1.Refresh();
                adminTaskSearchbtn_Click(sender, e);
                SearchTextBox.Clear();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.StackTrace);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            taskNameTextBox.Clear();
            assignedDt.Value = DateTime.Today;
            departmentCombobox.SelectedIndex = -1;
            // teamcomboBox1.SelectedIndex = -1;
            teamcomboBox1.DataSource = null;
            teamcomboBox1.Text = string.Empty;
            teamcomboBox1.Enabled = true;
            SearchTextBox.Clear();
            TaskController tc = new TaskController();
            adminTaskGridView1.DataSource = tc.GetAllTask();
            SearchTextBox.Clear();

        }
    }
}
