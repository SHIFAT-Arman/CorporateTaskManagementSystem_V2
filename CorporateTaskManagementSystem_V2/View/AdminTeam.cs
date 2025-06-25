using CorporateTaskManagementSystem_V2.Controller;
using CorporateTaskManagementSystem_V2.Model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CorporateTaskManagementSystem_V2.View
{
    public partial class AdminTeam : UserControl
    {
        public AdminTeam()
        {
            InitializeComponent();
        }

        public void UpdateTeamId()
        {
            try
            {
                Teams teams = new Teams();
                string teamId = teams.AutoTeamId(TeamIdTB.Text);

                if (teamId != null)
                {
                    TeamIdTB.Text = teamId;
                }
                else
                {
                    MessageBox.Show("Failed to generate Team ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("An error occurred while generating Team ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsValidTeamName(string teamName)
        {
            if (string.IsNullOrWhiteSpace(teamName) || teamName.Length < 2)
                return false;

            // Pattern: letters and spaces, optionally followed by numbers at the end
            Regex regex = new Regex(@"^[a-zA-Z\s]+[0-9]*$");
            return regex.IsMatch(teamName);
        }

        private void AddBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (TeamsDataGridView.SelectedCells.Count > 0)
                {
                    MessageBox.Show("Please reset the form before adding a new team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string teamName = teamNameTextBox.Text.Trim();

                string deptId = chooseDeptComboBox.SelectedValue.ToString();
                if(deptId == null || deptId == string.Empty)
                {
                    MessageBox.Show("Please select a department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!IsValidTeamName(teamName))
                {
                    MessageBox.Show("Team name can only contain letters and spaces with optional numeric at the end.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string teamId = TeamIdTB.Text.Trim();
                DateTime teamCreationDate = CreationDateTimePicker.Value;
                if (teamCreationDate > DateTime.Now)
                {
                    MessageBox.Show("Team creation date cannot be in the future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TeamController teamController = new TeamController();
                Team team = new Team(teamId, teamName, teamCreationDate, deptId);
                teamController.AddTeam(team);

                MessageBox.Show("Team added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                UpdateTeamId();
                refreshBtn.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the team: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ClearFields()
        {
            teamNameTextBox.Clear();
            chooseDeptComboBox.SelectedIndex = -1;
            CreationDateTimePicker.Value = DateTime.Now;
            TeamsDataGridView.ClearSelection();
        }

        private void AdminTeam_Load(object sender, EventArgs e)
        {
            UpdateTeamId();
            TeamsDataGridView.ClearSelection();
            TeamController teamController = new TeamController();
            TeamsDataGridView.DataSource = teamController.GetAllTeams();
            TeamsDataGridView.Refresh();

            chooseDeptComboBox_MouseClick(sender, null);
            refreshBtn.PerformClick();
        }

        private void chooseDeptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseDeptComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            DepartmentController departmentController = new DepartmentController();
            chooseDeptComboBox.DataSource = departmentController.GetAllDepartment();
            chooseDeptComboBox.DisplayMember = "DeptName";
            chooseDeptComboBox.ValueMember = "DeptId";
        }

        private void teamNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AdminTeam_Click(object sender, EventArgs e)
        {
            TeamsDataGridView.ClearSelection();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            TeamController teamController = new TeamController();
            TeamsDataGridView.DataSource = teamController.GetAllTeams();
            TeamsDataGridView.Refresh();
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            SearchTextBox.Text = string.Empty;
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == string.Empty)
            {
                SearchTextBox.Text = "Search by First Name";
            }
            else
            {
                SearchTextBox.Text = SearchTextBox.Text.Trim();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string teamId = TeamIdTB.Text.Trim();
                string teamName = teamNameTextBox.Text.Trim();
                if (teamName == string.Empty)
                {
                    MessageBox.Show("Please enter a team name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string deptId = chooseDeptComboBox.SelectedValue.ToString();

                if (string.IsNullOrEmpty(deptId))
                {
                    MessageBox.Show("Please select a department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime teamCreationDate = CreationDateTimePicker.Value;
                if (teamCreationDate > DateTime.Now)
                {
                    MessageBox.Show("Team creation date cannot be in the future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TeamController teamController = new TeamController();
                Team team = new Team(teamId, teamName, teamCreationDate, deptId);
                teamController.UpdateTeam(team);

                MessageBox.Show("Team updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateTeamId();
                ClearFields();
                refreshBtn.PerformClick();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the team: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string teamId = TeamIdTB.Text.Trim();
                if (string.IsNullOrEmpty(teamId))
                {
                    MessageBox.Show("Please select a team to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TeamController teamController = new TeamController();
                teamController.DeleteTeam(teamId);

                MessageBox.Show("Team deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateTeamId();
                ClearFields();
                refreshBtn.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the team: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string teamName = SearchTextBox.Text.Trim();
                if (string.IsNullOrEmpty(teamName) || teamName == "Search by First Name")
                {
                    MessageBox.Show("Please enter a team name to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TeamController teamController = new TeamController();
                List<Team> team = teamController.GetAllTeamByTeamName(teamName);
                if (team.Count > 0)
                {
                    TeamsDataGridView.DataSource = team;
                    TeamsDataGridView.Refresh();
                }
                else
                {
                    MessageBox.Show("No teams found with the specified name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TeamsDataGridView.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for the team: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            UpdateTeamId();
            TeamsDataGridView.ClearSelection(); // Clear the selection in the DataGridView
        }

        private void TeamsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < TeamsDataGridView.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = TeamsDataGridView.Rows[e.RowIndex];
                    TeamIdTB.Text = row.Cells["TeamId"].Value.ToString();
                    teamNameTextBox.Text = row.Cells["TeamName"].Value.ToString();
                    CreationDateTimePicker.Value = Convert.ToDateTime(row.Cells["TeamCreationDate"].Value);

                    DepartmentController departmentController = new DepartmentController();
                    string deptId = row.Cells["DeptId"].Value.ToString();
                    Department dept = departmentController.SearchDept(deptId);
                    if(dept != null)
                    {
                        chooseDeptComboBox.DisplayMember = dept.DeptName;
                        chooseDeptComboBox.SelectedValue = dept.DeptId;
                        chooseDeptComboBox.SelectedItem = dept.DeptName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while selecting the team: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void teamNameTextBox_Enter(object sender, EventArgs e)
        {
            TeamsDataGridView.ClearSelection();
        }
    }
}
