using CorporateTaskManagementSystem_V2.Controller;
using CorporateTaskManagementSystem_V2.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CorporateTaskManagementSystem_V2.View
{
    public partial class AdminDepartment : UserControl
    {
        public AdminDepartment()
        {
            InitializeComponent();
        }
        public void UpdateDeptId()
        {
            try
            {
                Departments depts = new Departments();
                string newDeptId = depts.AutoDeptId(deptIdTB.Text);
                if (newDeptId != null)
                {
                    deptIdTB.Text = newDeptId;
                }
                else
                {
                    MessageBox.Show("Failed to generate new Department ID. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating Department ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminDepartment_Load(object sender, System.EventArgs e)
        {
            UpdateDeptId();
            DepartmentController departmentController = new DepartmentController();
            List<Department> deptList = departmentController.GetAllDepartment();
            if (deptList != null && deptList.Count > 0)
            {
                DepartmentDataGridView.DataSource = deptList;
            }
            else
            {
                MessageBox.Show("No departments found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DepartmentDataGridView.DataSource = null; // Clear the DataGridView if no departments found
            }
            DepartmentDataGridView.Refresh();
            DepartmentDataGridView.ClearSelection();

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepartmentDataGridView.SelectedCells.Count > 0)
                {
                    MessageBox.Show("Please Reset the form before adding a new department.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string deptId = deptIdTB.Text.Trim();
                string deptName = deptNameTextBox.Text.Trim();
                if (string.IsNullOrEmpty(deptName))
                {
                    MessageBox.Show("Department Name cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime deptCreationDate = deptCreationDateTimePicker.Value.Date;
                if (deptCreationDate > DateTime.Now)
                {
                    MessageBox.Show("Department Creation Date cannot be in the future!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Department dept = new Department(deptId, deptName, deptCreationDate);
                DepartmentController deptController = new DepartmentController();
                deptController.AddDepartment(dept);

                MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                UpdateDeptId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the department: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ClearFields()
        {
            deptIdTB.Clear();
            deptNameTextBox.Clear();
            deptCreationDateTimePicker.Value = DateTime.Now;
            DepartmentDataGridView.Refresh();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string deptId = deptIdTB.Text.Trim();
                string deptName = deptNameTextBox.Text.Trim();
                if (string.IsNullOrEmpty(deptName))
                {
                    MessageBox.Show("Department Name cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime deptCreationDate = deptCreationDateTimePicker.Value.Date;
                if (deptCreationDate > DateTime.Now)
                {
                    MessageBox.Show("Department Creation Date cannot be in the future!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Department dept = new Department(deptId, deptName, deptCreationDate);
                DepartmentController deptController = new DepartmentController();
                deptController.UpdateDepartment(dept);

                MessageBox.Show("Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                UpdateDeptId();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the department: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string deptId = deptIdTB.Text.Trim();
                string deptName = deptNameTextBox.Text.Trim();
                if (string.IsNullOrEmpty(deptId) || string.IsNullOrEmpty(deptName))
                {
                    MessageBox.Show("Please select a department to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime deptCreationDate = deptCreationDateTimePicker.Value.Date;
                if (deptCreationDate > DateTime.Now)
                {
                    MessageBox.Show("Department Creation Date cannot be in the future!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DepartmentController deptController = new DepartmentController();
                deptController.DeleteDepartment(deptId);

                MessageBox.Show("Department deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                UpdateDeptId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the department: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchDeptName = SearchTextBox.Text.Trim();
                if (string.IsNullOrEmpty(searchDeptName))
                {
                    MessageBox.Show("Please enter a department name to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DepartmentController deptController = new DepartmentController();
                List<Department> deptList = deptController.GetAllDeptByDeptName(searchDeptName);
                if (deptList.Count > 0)
                {
                    DepartmentDataGridView.DataSource = deptList;
                }
                else
                {
                    MessageBox.Show("No departments found with the given name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DepartmentDataGridView.DataSource = null; // Clear the DataGridView if no results found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for the department: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            SearchTextBox.Text = "Search by Department Name";
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            DepartmentController departmentController = new DepartmentController();
            DepartmentDataGridView.DataSource = departmentController.GetAllDepartment();
            DepartmentDataGridView.Refresh();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            UpdateDeptId();
            DepartmentDataGridView.ClearSelection();
        }

        private void AdminDepartment_Click(object sender, EventArgs e)
        {
            DepartmentDataGridView.ClearSelection();
        }

        private void DepartmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < DepartmentDataGridView.Rows.Count)
            {
                DataGridViewRow row = DepartmentDataGridView.Rows[e.RowIndex];
                deptIdTB.Text = row.Cells["DeptId"].Value.ToString();
                deptNameTextBox.Text = row.Cells["DeptName"].Value.ToString();
                deptCreationDateTimePicker.Value = Convert.ToDateTime(row.Cells["DeptCreationDate"].Value);
            }
            else
            {
                MessageBox.Show("Please select a valid department.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
