using CorporateTaskManagementSystem_V2.Controller;
using CorporateTaskManagementSystem_V2.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CorporateTaskManagementSystem_V2.View
{
    public partial class AdminEmployee : UserControl
    {
        public AdminEmployee()
        {
            InitializeComponent();
        }

        public bool DeleteBtnVisibility
        {
            get { return deleteBtn.Visible; }
            set { deleteBtn.Visible = value; }
        }

        public bool UpdateBtnVisibility
        {
            get { return updateBtn.Visible; }
            set { updateBtn.Visible = value; }
        }

        public bool AddBtnVisibility
        {
            get { return AddBtn.Visible; }
            set { AddBtn.Visible = value; }
        }

        public bool ResetBtnVisibility
        {
            get { return resetBtn.Visible; }
            set { resetBtn.Visible = value; }
        }

        public bool chooseDeptComboBoxEnabled
        {
            get { return chooseDeptComboBox.Enabled; }
            set { chooseDeptComboBox.Enabled = value; }
        }
        public bool deptHeadRadioButtonEnabled
        {
            get { return deptHeadRadioButton.Enabled; }
            set { deptHeadRadioButton.Enabled = value; }
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                MailAddress addr = new MailAddress(email);
                // Check if the email address is in a valid format
                if (addr.Address == email)
                {
                    if (email.Contains("emp") || email.Contains("dept") || email.Contains("admin"))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidName(string name)
        {
            Regex regex = new Regex(@"([A-Z][a-zA-Z]*$)");
            return regex.IsMatch(name);
        }
        private bool IsValidPassword(string password)
        {
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            return regex.IsMatch(password);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeDataGridView.SelectedCells.Count > 0)
                {
                    MessageBox.Show("Please RESET the form before adding a new one.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string empId = empIdTB.Text.Trim();
                    string empFirstName = firstNameTB.Text.Trim();
                    if (!IsValidName(empFirstName)) // Validate first name
                    {
                        firstNameErrorLabel.Text = "First name must start with a capital letter and contain only letters and no spaces.";
                        firstNameErrorLabel.Visible = true;
                        return;
                    }
                    string empLastName = lastNameTB.Text.Trim();
                    if (!IsValidName(empLastName)) // Validate last name
                    {
                        lastNameErrorLabel.Text = "Last name must start with a capital letter and contain only letters and no spaces.";
                        lastNameErrorLabel.Visible = true;
                        return;
                    }
                    string empEmail = emailTB.Text.Trim();
                    if (!IsValidEmail(empEmail)) // Validate email format
                    {
                        MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        passInfoToolTip.Show("Email must contain 'emp', 'dept', or 'admin'.", emailTB, 5000);
                        return;
                    }
                    string empPassword = passwordTB.Text.Trim();
                    if (!IsValidPassword(empPassword)) // Validate password
                    {
                        passInfoToolTip.Show("Password must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, one digit, and one special character.", passInfoLabel, 2000);
                        return;
                    }


                    // DOB validation
                    DateTime empDOB = DOBDateTimePicker.Value.Date;
                    if (empDOB > DateTime.Now)
                    {
                        MessageBox.Show("Date of Birth cannot be in the future.", "Invalid Date of Birth", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    var empJoinDate = joinDateDateTimePicker.Value.Date;
                    string empPosition = ""; // Initialize empPosition variable
                    if (regularEmpRadioButton.Checked)
                    {
                        empPosition = "Regular Employee";
                    }
                    else if (deptHeadRadioButton.Checked)
                    {
                        empPosition = "Department Head";
                    }
                    else if (teamLeadRadioButton.Checked)
                    {
                        empPosition = "Team Lead";
                    }
                    else if (adminRadioButton.Checked)
                    {
                        empPosition = "Admin";
                    }
                    else
                    {
                        MessageBox.Show("Please select a position for the employee.", "Position Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Console.WriteLine(empPosition);

                    byte[] empPfp = InsertImage(pfpFileNameTextBox.Text); // profile picture file
                    string teamId = chooseTeamComboBox.SelectedValue?.ToString(); // Get the selected team ID from the combo box

                    // Initialize empSalary 
                    float empSalary = (float)salaryNumericUpDown.Value;
                    Console.WriteLine(empId + " " + empFirstName + " " + empLastName + " " + empEmail + " " + empPassword + " " + empDOB + " " + empJoinDate + " " + empPosition + " " + empSalary + " " + empPfp, teamId);

                    string deptId = chooseDeptComboBox.SelectedValue?.ToString(); // Get the selected department ID from the combo box

                    EmployeeController empController = new EmployeeController();
                    Employee employee = new Employee(empId, empFirstName, empLastName, empEmail, empPassword, empDOB, empJoinDate, empPfp, empPosition, empSalary, teamId, deptId);

                    // Save info to Login Table
                    LoginController loginController = new LoginController();
                    Login login = new Login(empId, empEmail, empPassword, empPosition);

                    empController.AddEmployee(employee);
                    loginController.AddLogin(login);

                    MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ClearFields();
                    UpdateEmpId();
                    refreshBtn_Click(sender, e); // Refresh the DataGridView after adding an employee

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearFields()
        {
            firstNameTB.Clear();
            firstNameErrorLabel.Visible = false;
            lastNameTB.Clear();
            lastNameErrorLabel.Visible = false;
            emailTB.Clear();
            passwordTB.Clear();
            DOBDateTimePicker.Value = DateTime.Now;
            joinDateDateTimePicker.Value = DateTime.Now;
            profilePictureBox.Image = defaultPictureBox.Image;
            pfpFileNameTextBox.Clear();
            salaryNumericUpDown.Value = 0;
            regularEmpRadioButton.Checked = false;
            deptHeadRadioButton.Checked = false;
            teamLeadRadioButton.Checked = false;
            chooseDeptComboBox.Enabled = false;
            chooseDeptComboBox.DataSource = null; // Clear the combo box data source
            chooseDeptComboBox.Items.Clear();
            chooseTeamComboBox.Enabled = false;
            chooseTeamComboBox.DataSource = null; // Clear the combo box data source
            chooseTeamComboBox.Items.Clear();
            SearchTextBox.Text = "Search by First Name";
            EmployeeDataGridView.Refresh();

        }

        public void UpdateEmpId()
        {
            try
            {
                Employees emp = new Employees();
                string empId = emp.AutoEmpId(empIdTB.Text);
                empIdTB.Text = empId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating Employee ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public byte[] InsertImage(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
            {
                return null;
            }
            try
            {
                byte[] imageBytes = File.ReadAllBytes(imagePath);
                return imageBytes;
                // Here you can save the imageBytes to your database or perform any other operation
                // For example, you can call a method in your EmployeeController to save the employee with the image
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading the image file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void AdminEmployee_Load(object sender, EventArgs e)
        {
            UpdateEmpId();
            EmployeeController empController = new EmployeeController();
            EmployeeDataGridView.DataSource = empController.GetAllEmployees();
            EmployeeDataGridView.Refresh();

            EmployeeDataGridView.ClearSelection();

        }

        private void firstNameTB_MouseClick(object sender, MouseEventArgs e)
        {
            firstNameErrorLabel.Visible = false;
            EmployeeDataGridView.ClearSelection();
        }
        private void lastNameTB_MouseClick(object sender, MouseEventArgs e)
        {
            lastNameErrorLabel.Visible = false;
        }

        private void showLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (showLinkLabel.Text == "Show")
            {
                passwordTB.PasswordChar = '\0';
                showLinkLabel.Text = "Hide";
            }
            else
            {
                passwordTB.PasswordChar = '*';
                showLinkLabel.Text = "Show";
            }
        }

        private void deptHeadRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            chooseDeptComboBox.Enabled = true;
            chooseTeamComboBox.Enabled = false;

            // Load departments into the combo box
            DepartmentController deptController = new DepartmentController();
            chooseDeptComboBox.DataSource = deptController.GetAllDepartment();
            chooseDeptComboBox.DisplayMember = "DeptName"; // Assuming DeptName is the property to display
            chooseDeptComboBox.ValueMember = "DeptId"; // Assuming DeptId is the property to use as value
        }

        private void teamLeadRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            chooseDeptComboBox.Enabled = true;
            chooseTeamComboBox.Enabled = true;

            // Load departments into the combo box
            DepartmentController deptController = new DepartmentController();
            chooseDeptComboBox.DataSource = deptController.GetAllDepartment();
            chooseDeptComboBox.DisplayMember = "DeptName"; // Assuming DeptName is the property to display
            chooseDeptComboBox.ValueMember = "DeptId"; // Assuming DeptId is the property to use as value

            string deptId = chooseDeptComboBox.SelectedValue?.ToString();
            TeamController teamController = new TeamController();
            chooseTeamComboBox.DataSource = teamController.GetAllTeamByDeptId(deptId);
            chooseTeamComboBox.DisplayMember = "TeamName"; // Assuming TeamName is the property to display
            chooseTeamComboBox.ValueMember = "TeamId"; // Assuming TeamId is the property to use as value
        }

        private void regularEmpRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            chooseDeptComboBox.Enabled = true;
            chooseTeamComboBox.Enabled = true;

            // Load departments into the combo box
            DepartmentController deptController = new DepartmentController();
            chooseDeptComboBox.DataSource = deptController.GetAllDepartment();
            chooseDeptComboBox.DisplayMember = "DeptName"; // Assuming DeptName is the property to display
            chooseDeptComboBox.ValueMember = "DeptId"; // Assuming DeptId is the property to use as value

            string deptId = chooseDeptComboBox.SelectedValue?.ToString();
            TeamController teamController = new TeamController();
            chooseTeamComboBox.DataSource = teamController.GetAllTeamByDeptId(deptId);
            chooseTeamComboBox.DisplayMember = "TeamName"; // Assuming TeamName is the property to display
            chooseTeamComboBox.ValueMember = "TeamId"; // Assuming TeamId is the property to use as value
        }

        private void adminRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            chooseDeptComboBox.Enabled = false;
            chooseTeamComboBox.Enabled = false;

            //clear combobox selection
            chooseDeptComboBox.DataSource = null; // Clear the combo box data source
            chooseDeptComboBox.Items.Clear();
            chooseTeamComboBox.Items.Clear();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    pfpFileNameTextBox.Text = imagePath;

                    // To avoid file Lock issues, we can read the file into a MemoryStream
                    using (var stream = new MemoryStream(File.ReadAllBytes(imagePath)))
                    {
                        profilePictureBox.Image = Image.FromStream(stream);
                    }

                }
            }
        }

        private void EmployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < EmployeeDataGridView.Rows.Count)
            {
                DataGridViewRow row = EmployeeDataGridView.Rows[e.RowIndex];
                empIdTB.Text = row.Cells["EmpId"].Value.ToString();
                firstNameTB.Text = row.Cells["EmpFirstName"].Value.ToString();
                lastNameTB.Text = row.Cells["EmpLastName"].Value.ToString();
                emailTB.Text = row.Cells["EmpEmail"].Value.ToString();
                passwordTB.Text = row.Cells["EmpPassword"].Value.ToString();
                DOBDateTimePicker.Value = Convert.ToDateTime(row.Cells["EmpDOB"].Value);
                joinDateDateTimePicker.Value = Convert.ToDateTime(row.Cells["EmpJoinDate"].Value);

                // Load profile picture
                byte[] empPfp = (byte[])row.Cells["EmpPfp"].Value;
                if (empPfp != null && empPfp.Length > 0)
                {
                    //using(FileStream fs = new FileStream(pfpFileNameTextBox.Text, FileMode.Open, FileAccess.Read))
                    //{
                    //    profilePictureBox.Image = Image.FromStream(fs);
                    //}
                    using (var stream = new MemoryStream(empPfp))
                    {
                        profilePictureBox.Image = Image.FromStream(stream);
                        //Console.WriteLine(SavePhoto()); 
                    }
                }
                else
                {
                    profilePictureBox.Image = null;
                }
                string empPosition = row.Cells["EmpPosition"].Value.ToString();
                if (empPosition == "Regular Employee")
                {
                    regularEmpRadioButton.Checked = true;
                }
                else if (empPosition == "Department Head")
                {
                    deptHeadRadioButton.Checked = true;
                }
                else if (empPosition == "Team Lead")
                {
                    teamLeadRadioButton.Checked = true;
                }
                else if (empPosition == "Admin")
                {
                    adminRadioButton.Checked = true;
                }
                salaryNumericUpDown.Value = Convert.ToDecimal(row.Cells["EmpSalary"].Value);
            }

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            EmployeeController empController = new EmployeeController();
            EmployeeDataGridView.DataSource = empController.GetAllEmployees();
            EmployeeDataGridView.ClearSelection();
            EmployeeDataGridView.Refresh();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            UpdateEmpId();
            EmployeeDataGridView.ClearSelection(); // Clear the selection in the DataGridView
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string empId = empIdTB.Text.Trim();
                if (empId != string.Empty && firstNameTB.Text != string.Empty)
                {
                    // Delete From Login Table then Employee Table
                    LoginController loginController = new LoginController();
                    loginController.DeleteLogin(empId);

                    EmployeeController empController = new EmployeeController();
                    empController.DeleteEmployee(empId);


                    MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    resetBtn_Click(sender, e); // Reset fields after deletion
                }
                else
                {
                    MessageBox.Show("Please select an employee to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ClearFields();
                refreshBtn_Click(sender, e); // Refresh the DataGridView after deleting an employee
            }
        }

        private byte[] SavePhoto()
        {

            if (profilePictureBox.Image == null)
            {
                return null; // Return null if no image is set
            }
            using (MemoryStream ms = new MemoryStream())
            {
                profilePictureBox.Image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string empId = empIdTB.Text.Trim();
                string empFirstName = firstNameTB.Text.Trim();
                if (!IsValidName(empFirstName)) // Validate first name
                {
                    firstNameErrorLabel.Text = "First name must start with a capital letter and contain only letters and no spaces.";
                    firstNameErrorLabel.Visible = true;
                    return;
                }
                string empLastName = lastNameTB.Text.Trim();
                if (!IsValidName(empLastName)) // Validate last name
                {
                    lastNameErrorLabel.Text = "Last name must start with a capital letter and contain only letters and no spaces.";
                    lastNameErrorLabel.Visible = true;
                    return;
                }
                string empEmail = emailTB.Text.Trim();
                if (!IsValidEmail(empEmail)) // Validate email format
                {
                    MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string empPassword = passwordTB.Text.Trim();
                if (!IsValidPassword(empPassword)) // Validate password
                {
                    passInfoToolTip.Show("Password must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, one digit, and one special character.", passInfoLabel, 2000);
                    return;
                }

                // DOB validation
                DateTime empDOB = DOBDateTimePicker.Value.Date;
                if (empDOB > DateTime.Now)
                {
                    MessageBox.Show("Date of Birth cannot be in the future.", "Invalid Date of Birth", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var empJoinDate = joinDateDateTimePicker.Value.Date;
                string empPosition = ""; // Initialize empPosition variable
                if (regularEmpRadioButton.Checked)
                {
                    empPosition = "Regular Employee";
                }
                else if (deptHeadRadioButton.Checked)
                {
                    empPosition = "Department Head";
                }
                else if (teamLeadRadioButton.Checked)
                {
                    empPosition = "Team Lead";
                }
                else if (adminRadioButton.Checked)
                {
                    empPosition = "Admin";
                }
                else
                {
                    MessageBox.Show("Please select a position for the employee.", "Position Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Console.WriteLine(empPosition);

                // Load profile picture
                byte[] empPfp = SavePhoto();

                // Initialize empSalary 
                float empSalary = (float)salaryNumericUpDown.Value;
                Console.WriteLine(empId + " " + empFirstName + " " + empLastName + " " + empEmail + " " + empPassword + " " + empDOB + " " + empJoinDate + " " + empPosition + " " + empSalary + " " + empPfp);

                string teamId = chooseTeamComboBox.SelectedValue?.ToString(); // Get the selected team ID from the combo box

                string deptId = chooseDeptComboBox.SelectedValue?.ToString(); // Get the selected department ID from the combo box

                EmployeeController empController = new EmployeeController();
                Employee employee = new Employee(empId, empFirstName, empLastName, empEmail, empPassword, empDOB, empJoinDate, empPfp, empPosition, empSalary, teamId, deptId);

                empController.UpdateEmployee(employee);

                LoginController loginController = new LoginController();
                Login login = new Login(empId, empEmail, empPassword, empPosition);
                loginController.UpdateLogin(login);

                MessageBox.Show("Employee Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ClearFields();
                UpdateEmpId();
                refreshBtn_Click(sender, e); // Refresh the DataGridView after adding an employee

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void AdminEmployee_Click(object sender, EventArgs e)
        {
            EmployeeDataGridView.ClearSelection();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string firstName = SearchTextBox.Text.Trim();
            EmployeeController empController = new EmployeeController();
            List<Employee> employees = empController.SearchEmployee(firstName);
            if (employees.Count > 0)
            {
                EmployeeDataGridView.DataSource = employees;
                EmployeeDataGridView.Refresh();
            }
            else
            {
                MessageBox.Show("No employee found with the given name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmployeeDataGridView.DataSource = null; // Clear the DataGridView if no results found
            }
        }

        private void chooseTeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseDeptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string deptId = chooseDeptComboBox.SelectedValue?.ToString();
            TeamController teamController = new TeamController();
            if (deptId != null && chooseTeamComboBox.Enabled != false)
            {
                List<Team> teams = teamController.GetAllTeamByDeptId(deptId);
                if (teams.Count > 0)
                {
                    chooseTeamComboBox.DataSource = teamController.GetAllTeamByDeptId(deptId);
                    chooseTeamComboBox.DisplayMember = "TeamName"; // Assuming TeamName is the property to display
                    chooseTeamComboBox.ValueMember = "TeamId"; // Assuming TeamId is the property to use as value
                    chooseTeamComboBox.Refresh(); // Refresh the combo box to show updated data
                }
                else
                {
                    chooseTeamComboBox.DataSource = null; // Clear the combo box if no teams found
                    chooseTeamComboBox.Items.Clear();
                    chooseTeamComboBox.DisplayMember = null;

                }
            }
            else
            {
                chooseTeamComboBox.DataSource = null; // Clear the combo box if no department is selected
                chooseTeamComboBox.Items.Clear();
            }
        }

        private void emailTB_MouseHover(object sender, EventArgs e)
        {
            passInfoToolTip.Show("Format must be either of three:\r\n<email>.emp@gmail.com\r\n<email>.dept@gmail.com\r\n<email>.admin@gmail.com", emailTB, 5000);
        }

        private void emailTB_Enter(object sender, EventArgs e)
        {
            passInfoToolTip.Show("Format must be either of three:\r\n<email>.emp@gmail.com\r\n<email>.dept@gmail.com\r\n<email>.admin@gmail.com", emailTB, 5000);
        }
    }
}
