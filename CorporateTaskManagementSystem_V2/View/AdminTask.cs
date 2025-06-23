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

        private bool IsValidTaskFormat( string taskId)
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


            departmentCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentCombobox.DisplayMember = "DeptName";
            departmentCombobox.ValueMember = "DeptId";
            departmentCombobox.DataSource = deps.GetAllDept();

            teamcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            teamcomboBox1.Enabled = false;
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
            teamcomboBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
             {

                if (string.IsNullOrWhiteSpace(taskNameTextBox.Text)){
                    MessageBox.Show("enter task name");
                }
                   
                
            //string task = taskNameTextBox.Text;
            string taskId = null;
            string taskName = taskNameTextBox.Text;
            // DateTime taskAssignedDate = assignedDt.Text;

            DateTime taskAssignedDate;
            if (!DateTime.TryParse(assignedDt.Text, out taskAssignedDate))
            {
                MessageBox.Show("enter valid date");
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
                teamcomboBox1.Enabled = true;
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
                assignedDt.Text = dvr.Cells[2].Value.ToString();
                //departmentCombobox.Text = dvr.Cells[3].Value.ToString();


                if (dvr.Cells[4].Value != null)
                {
                    string teamId = dvr.Cells[4].Value.ToString();
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

                adminTaskGridView1.DataSource = tc.GetAllTask();
                adminTaskGridView1.Refresh();
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
                }
                //string task = taskNameTextBox.Text;
                //string taskId = null;
                string taskName = taskNameTextBox.Text;
                // DateTime taskAssignedDate = assignedDt.Text;

                DateTime taskAssignedDate;
                if (!DateTime.TryParse(assignedDt.Text, out taskAssignedDate))
                {
                    MessageBox.Show("enter valid date");
                    return;
                }
                string taskStatus = "pending";
                string teamId = Convert.ToString(teamcomboBox1.SelectedValue);

                Model.Task t = new Model.Task(taskId, taskName, taskAssignedDate, taskStatus, teamId);
                TaskController tc = new TaskController();

                Model.Task sf = tc.Search(taskId);
                if (sf == null)
                {
                    MessageBox.Show("task does not exist broski");

                }
                tc.UpdateTask(t);

                MessageBox.Show("yippe");
                adminTaskGridView1.DataSource = tc.GetAllTask();
                adminTaskGridView1.Refresh();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.StackTrace);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            taskNameTextBox.Clear();
            departmentCombobox.SelectedIndex = -1;
            teamcomboBox1.SelectedIndex = -1;
            SearchTextBox.Clear();
            TaskController tc = new TaskController();
            adminTaskGridView1.DataSource = tc.GetAllTask();
        }
    }
    }

