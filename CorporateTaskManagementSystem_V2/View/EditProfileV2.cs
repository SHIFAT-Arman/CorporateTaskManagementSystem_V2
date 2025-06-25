using CorporateTaskManagementSystem_V2.Controller;
using CorporateTaskManagementSystem_V2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorporateTaskManagementSystem_V2.View
{
    public partial class EditProfileV2 : UserControl
    {
        public EditProfileV2()
        {
            InitializeComponent();
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
        private void uploadBtn_Click(object sender, EventArgs e)
        {

        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            EditProfileV2_Load(sender, e);
        }
        private byte[] SavePhoto()
        {
            
            if (profilePictureBox.Image == null)
            {
                return null; // Return null if no image is set
            }
            using(MemoryStream ms = new MemoryStream())
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

                string teamId = chooseTeamComboBox.SelectedValue?.ToString(); // Get the selected team ID from the combo box
                string deptId = chooseDeptComboBox.SelectedValue?.ToString(); // Get the selected department ID from the combo box

                EmployeeController empController = new EmployeeController();
                Employee employee = new Employee(empId, empFirstName, empLastName, empEmail, empPassword, empDOB, empJoinDate, empPfp, empPosition, empSalary, teamId, deptId);

                empController.UpdateEmployee(employee);

                LoginController loginController = new LoginController();
                Login login = new Login(empId, empEmail, empPassword, empPosition);
                loginController.UpdateLogin(login);

                MessageBox.Show("Employee Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            resetBtn_Click(sender, e);
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

        public void EditProfileV2_Load(object sender, EventArgs e)
        {
            try
            {
                EmployeeController employeeController = new EmployeeController();
                List<Employee> list = employeeController.GetDataFromLogin(Session.LoggedInEmpId);
                empIdTB.Text = list[0].EmpId;
                firstNameTB.Text = list[0].EmpFirstName;
                lastNameTB.Text = list[0].EmpLastName;
                emailTB.Text = list[0].EmpEmail;
                passwordTB.Text = list[0].EmpPassword;
                DOBDateTimePicker.Value = list[0].EmpDOB;
                joinDateDateTimePicker.Value = list[0].EmpJoinDate;
                if (list[0].EmpPfp != null)
                {
                    using (MemoryStream ms = new MemoryStream(list[0].EmpPfp))
                    {
                        profilePictureBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    profilePictureBox.Image = defaultPictureBox.Image;
                }

                if (list[0].EmpPosition.Contains("Admin"))
                {
                    adminRadioButton.Checked = true;
                }
                else if (list[0].EmpPosition.Contains("Department Head"))
                {
                    deptHeadRadioButton.Checked = true;
                }
                else if (list[0].EmpPosition.Contains("Regular Employee"))
                {
                    regularEmpRadioButton.Checked = true;
                }
                else if (list[0].EmpPosition.Contains("Team Lead"))
                {
                    teamLeadRadioButton.Checked = true;
                }
                else
                {
                    regularEmpRadioButton.Checked = false;
                    adminRadioButton.Checked = false;
                    deptHeadRadioButton.Checked = false;
                    teamLeadRadioButton.Checked = false;
                }
                salaryNumericUpDown.Value = (decimal)list[0].EmpSalary;

                if (list[0].TeamId == null)
                {
                    chooseTeamComboBox.DataSource = null; // Clear the combo box if no team is associated
                }
                else
                {
                    TeamController teamController = new TeamController();
                    Team t = teamController.SearchTeam(list[0].TeamId);
                    if (t != null)
                    {
                        chooseTeamComboBox.DataSource = new List<Team> { t }; // Set the combo box data source to a list containing the found team
                        chooseTeamComboBox.DisplayMember = "TeamName"; // Assuming TeamName is the property to display
                        chooseTeamComboBox.ValueMember = "TeamId"; // Assuming TeamId is the property to use as value
                    }
                    else
                    {
                        chooseTeamComboBox.DataSource = null; // Clear the combo box if no team found
                        chooseTeamComboBox.Items.Clear();
                    }
                }
                if (list[0].DeptId == null)
                {
                    chooseDeptComboBox.DataSource = null;
                }
                else 
                {
                    DepartmentController departmentController = new DepartmentController();
                    Department department = departmentController.SearchDept(list[0].DeptId);
                    if (department != null)
                    {
                        chooseDeptComboBox.DataSource = new List<Department> { department }; // Set the combo box data source to a list containing the found department
                        chooseDeptComboBox.DisplayMember = "DeptName"; // Assuming DeptName is the property to display
                        chooseDeptComboBox.ValueMember = "DeptId"; // Assuming DeptId is the property to use as value
                    }
                    else
                    {
                        chooseDeptComboBox.DataSource = null; // Clear the combo box if no department found
                        chooseDeptComboBox.Items.Clear();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the login information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void uploadBtn_Click_1(object sender, EventArgs e)
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

        private void UpdateBtn_Click_1(object sender, EventArgs e)
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
                
                string teamId = chooseTeamComboBox.SelectedValue?.ToString(); // Get the selected team ID from the combo box
                if(chooseTeamComboBox.SelectedValue == null)
                {
                    teamId = null; // If no team is selected, set teamId to null
                }
                string deptId = chooseDeptComboBox.SelectedValue?.ToString(); // Get the selected department ID from the combo box
                if(chooseDeptComboBox.SelectedValue == null)
                {
                    deptId = null; // If no department is selected, set deptId to null
                }
                EmployeeController empController = new EmployeeController();
                Employee employee = new Employee(empId, empFirstName, empLastName, empEmail, empPassword, empDOB, empJoinDate, empPfp, empPosition, empSalary, teamId, deptId);

                empController.UpdateEmployee(employee);

                LoginController loginController = new LoginController();
                Login login = new Login(empId, empEmail, empPassword, empPosition);
                loginController.UpdateLogin(login);

                MessageBox.Show("Employee Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            resetBtn_Click(sender, e);
        }

        private void uploadBtn_MouseHover(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click_1(object sender, EventArgs e)
        {
            EditProfileV2_Load(sender, e);
        }

        private void showLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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
    }
}
