using CorporateTaskManagementSystem_V2.Controller;
using CorporateTaskManagementSystem_V2.Model;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CorporateTaskManagementSystem_V2.View
{
    public partial class EmployeeTask : UserControl
    {
        TaskController tc = new TaskController();
        Teams tec = new Teams();
        private bool IsValidTaskFormat(string taskId)
        {
            string pattern = @"^T-\d{3}$";
            return Regex.IsMatch(taskId, pattern);
        }
        public EmployeeTask()
        {
            InitializeComponent();
        }

        private void EmployeeTask_Load(object sender, System.EventArgs e)
        {
            eTaskNameTextBox.Enabled = false;
            eTaskTeamComboBox1.Enabled = false;
            eTaskDateTimePicker1.Enabled = false;
        }

        private void eTaskSearchBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                string taskId = eTaskSearchTextBox.Text.Trim();
                if (!IsValidTaskFormat(taskId))
                {
                    MessageBox.Show("enter id followinf format T-123");
                    return;
                }

                Model.Task t = tc.Search(taskId);

                if (t != null)
                {
                    List<Model.Task> foundTask = new List<Model.Task>();
                    foundTask.Add(t);

                    eTaskDataGridView1.DataSource = foundTask;
                    MessageBox.Show("Task was found");
                    eTaskNameTextBox.Text = t.TaskName;
                    eTaskDateTimePicker1.Value = t.TaskAssignedDate;
                    eTaskTeamComboBox1.Items.Clear();
                    

                    if (!string.IsNullOrEmpty(t.TeamId))
                    {
                        Team team = tec.SearchTeam(t.TeamId);
                        if (team != null)
                        {
                            eTaskTeamComboBox1.Items.Clear();
                            eTaskTeamComboBox1.Items.Add(team.TeamName);
                            eTaskTeamComboBox1.SelectedIndex = 0;
                        }
                        else
                        {

                            eTaskTeamComboBox1.Items.Clear();
                            MessageBox.Show("No teams Assigned");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Task does not exist");
                    }
                    if (t.TaskStatus == "pending")
                    {
                        pendingRadioButton.Checked = true;
                        completedRadioButton.Checked = false;
                    }
                    else
                    {
                        pendingRadioButton.Checked = false;
                        completedRadioButton.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Task does not exist");
                }
                eTaskSearchTextBox.Clear();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.StackTrace);
            }
        }

        private void eTaskUpdateBtn_Click(object sender, EventArgs e)
        {
            string taskId = eTaskSearchTextBox.Text.Trim();
            if (!IsValidTaskFormat(taskId))
            {
                MessageBox.Show("enter id following format T-123");
                return;
            }

            Model.Task t = tc.Search(taskId);

            if (t == null)
            {
                MessageBox.Show("Task does not exist, please write proper taskId first");
                return;
            }
            try
            {
                if (pendingRadioButton.Checked)
                {
                    t.TaskStatus = "pending";
                }
                else
                {
                    t.TaskStatus = "completed";
                }

                tc.UpdateTask(t);
                MessageBox.Show("updated");
                eTaskSearchBtn_Click(sender, e);
                eTaskSearchTextBox.Clear();
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.StackTrace);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            eTaskNameTextBox.Clear();
            eTaskDateTimePicker1.Value = DateTime.Today;
            pendingRadioButton.Checked = false;
            completedRadioButton.Checked = false;
            eTaskTeamComboBox1.Items.Clear();
            eTaskTeamComboBox1.Text = "";
            eTaskDataGridView1.DataSource = tc.GetAllTask();
        }

        private void eTaskDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvr = eTaskDataGridView1.Rows[e.RowIndex];
                eTaskNameTextBox.Text = dvr.Cells[1].Value.ToString()??string.Empty;
                eTaskSearchTextBox.Text = dvr.Cells[0].Value.ToString()??string.Empty;
                eTaskDateTimePicker1.Value = DateTime.Parse(dvr.Cells[2].Value?.ToString() ?? DateTime.Today.ToString());
                //eTaskTeamComboBox1.Text = dvr.Cells[4].Value.ToString();
                eTaskTeamComboBox1.Items.Clear();
                string teamId = dvr.Cells[4].Value?.ToString();
                if (!string.IsNullOrEmpty(teamId))
                {
                    Team team = tec.SearchTeam(teamId);
                    if (team != null)
                    {
                        eTaskTeamComboBox1.Items.Add(team.TeamName);
                        eTaskTeamComboBox1.SelectedIndex = 0;
                    }
                }
                string stat = dvr.Cells[3].Value?.ToString() ?? string.Empty;
                if (stat.Equals("pending")){
                    pendingRadioButton.Checked = true;
                    completedRadioButton.Checked = false;
                }else if (stat.Equals("completed"))
                {
                    pendingRadioButton.Checked = false;
                    completedRadioButton.Checked = true;
                }
                


            }
        }

        private void eTaskSearchTextBox_Enter(object sender, EventArgs e)
        {
            eTaskSearchTextBox.Clear();
            eTaskSearchTextBox.ForeColor= System.Drawing.Color.Black;
        }

        private void eTaskSearchTextBox_Leave(object sender, EventArgs e)
        {
            eTaskSearchTextBox.Text = "Enter Task ID (e.g., T-123)";
        }
    }
}
