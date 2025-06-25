using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class Employees
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();
        public void AddEmployee(Employee employee)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Employee (empId, empFirstName, empLastName, empEmail, empPassword, empDOB, empJoinDate, empPfp, empPosition, empSalary, teamId,deptId) VALUES (@empId, @empFirstName, @empLastName, @empEmail, @empPassword, @empDOB, @empJoinDate, @empPfp, @empPosition, @empSalary, @teamId,@deptId);");
            cmd.Parameters.AddWithValue("@empId", employee.EmpId);
            cmd.Parameters.AddWithValue("@empFirstName", employee.EmpFirstName);
            cmd.Parameters.AddWithValue("@empLastName", employee.EmpLastName);
            cmd.Parameters.AddWithValue("@empEmail", employee.EmpEmail);
            cmd.Parameters.AddWithValue("@empPassword", employee.EmpPassword);
            cmd.Parameters.AddWithValue("@empDOB", employee.EmpDOB);
            cmd.Parameters.AddWithValue("@empJoinDate", employee.EmpJoinDate);
            if (employee.EmpPfp == null)
            {
                employee.EmpPfp = new byte[0]; // Initialize to an empty byte array if null

                cmd.Parameters.AddWithValue("@empPfp", employee.EmpPfp); // Handle null profile picture

            }
            else
            {
                cmd.Parameters.AddWithValue("@empPfp", employee.EmpPfp);
            }
            cmd.Parameters.AddWithValue("@empPosition", employee.EmpPosition);
            cmd.Parameters.AddWithValue("@empSalary", employee.EmpSalary);
            if (string.IsNullOrEmpty(employee.TeamId))
            {
                cmd.Parameters.AddWithValue("@teamId", DBNull.Value); // Handle null team ID
            }
            else
            {
                cmd.Parameters.AddWithValue("@teamId", employee.TeamId);
            }
            if (string.IsNullOrEmpty(employee.DeptId))
            {
                cmd.Parameters.AddWithValue("@deptId", DBNull.Value); // Handle null team ID
            }
            else
            {
                cmd.Parameters.AddWithValue("@deptId", employee.DeptId);
            }
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void UpdateEmployee(Employee employee)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Employee SET  empFirstName=@empFirstName, empLastName=@empLastName, empEmail=@empEmail, empPassword=@empPassword, empDOB=@empDOB, empJoinDate=@empJoinDate, empPfp=@empPfp, empPosition=@empPosition, empSalary=@empSalary, teamId=@teamId, deptId=@deptId WHERE empId=@empId;");


            cmd.Parameters.AddWithValue("@empFirstName", employee.EmpFirstName);
            cmd.Parameters.AddWithValue("@empLastName", employee.EmpLastName);
            cmd.Parameters.AddWithValue("@empEmail", employee.EmpEmail);
            cmd.Parameters.AddWithValue("@empPassword", employee.EmpPassword);
            cmd.Parameters.AddWithValue("@empDOB", employee.EmpDOB);
            cmd.Parameters.AddWithValue("@empJoinDate", employee.EmpJoinDate);
            if (employee.EmpPfp == null)
            {
                employee.EmpPfp = new byte[0]; // Initialize to an empty byte array if null
                cmd.Parameters.AddWithValue("@empPfp", employee.EmpPfp); // Handle null profile picture
            }
            else
            {
                cmd.Parameters.AddWithValue("@empPfp", employee.EmpPfp);
            }
            cmd.Parameters.AddWithValue("@empPosition", employee.EmpPosition);
            cmd.Parameters.AddWithValue("@empSalary", employee.EmpSalary);
            if (string.IsNullOrEmpty(employee.TeamId))
            {
                cmd.Parameters.AddWithValue("@teamId", DBNull.Value); // Handle null team ID
            }
            else
            {
                cmd.Parameters.AddWithValue("@teamId", employee.TeamId);
            }
            if (string.IsNullOrEmpty(employee.DeptId))
            {
                cmd.Parameters.AddWithValue("@deptId", DBNull.Value); // Handle null team ID
            }
            else
            {
                cmd.Parameters.AddWithValue("@deptId", employee.DeptId);
            }
            cmd.Parameters.AddWithValue("@empId", employee.EmpId);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void DeleteEmployee(string empId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Employee WHERE empId=@empId;");
            cmd.Parameters.AddWithValue("@empId", empId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public List<Employee> GetAllEmployees()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Employee;");
            cmd.CommandType = CommandType.Text;
            return GetData(cmd);
        }
        public List<Employee> SearchEmployee(string empFirstName)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Employee WHERE empFirstName=@empFirstName;");
            cmd.Parameters.AddWithValue("@empFirstName", empFirstName);
            cmd.CommandType = CommandType.Text;
            return GetData(cmd);
        }
        public List<Employee> GetDataFromLogin(string empId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Employee WHERE empId=@empId;");
            cmd.Parameters.AddWithValue("@empId", empId);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Employee> list = new List<Employee>();

            using (reader)
            {
                while (reader.Read())
                {
                    byte[] imageData = null;
                    if (!reader.IsDBNull(7)) // Check if empPfp is not null
                    {
                        byte[] imageBytes = (byte[])reader[7];
                        imageData = imageBytes.Length > 0 ? imageBytes : null; // Handle empty byte array
                    }
                    Employee emp = new Employee();
                    emp.EmpId = reader.GetString(0);
                    emp.EmpFirstName = reader.GetString(1);
                    emp.EmpLastName = reader.GetString(2);
                    emp.EmpEmail = reader.GetString(3);
                    emp.EmpPassword = reader.GetString(4);
                    emp.EmpDOB = reader.GetDateTime(5);
                    emp.EmpJoinDate = reader.GetDateTime(6);
                    emp.EmpPfp = imageData; // Assign the image data
                    emp.EmpPosition = reader.GetString(8);
                    emp.EmpSalary = (float)reader.GetDouble(9);
                    emp.TeamId = reader.IsDBNull(10) ? null : reader.GetString(10); // Handle null teamId
                    emp.DeptId = reader.IsDBNull(11) ? null : reader.GetString(11); // Handle null deptId
                    list.Add(emp);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return list;
        }
        public List<Employee> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            List<Employee> list = new List<Employee>();
            //byte[] imageData = cmd.ExecuteScalar() as byte[];
            using (reader)
            {
                while (reader.Read())
                {
                    byte[] imageData = null;
                    if (!reader.IsDBNull(7)) // Check if empPfp is not null
                    {
                        byte[] imageBytes = (byte[])reader[7];
                        imageData = imageBytes.Length > 0 ? imageBytes : null; // Handle empty byte array
                    }
                    Employee emp = new Employee();
                    emp.EmpId = reader.GetString(0);
                    emp.EmpFirstName = reader.GetString(1);
                    emp.EmpLastName = reader.GetString(2);
                    emp.EmpEmail = reader.GetString(3);
                    emp.EmpPassword = reader.GetString(4);
                    emp.EmpDOB = reader.GetDateTime(5);
                    emp.EmpJoinDate = reader.GetDateTime(6);
                    emp.EmpPfp = imageData; // Assign the image data
                    emp.EmpPosition = reader.GetString(8);
                    emp.EmpSalary = (float)reader.GetDouble(9);
                    emp.TeamId = reader.IsDBNull(10) ? null : reader.GetString(10); // Handle null teamId
                    list.Add(emp);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return list;
        }
        public string AutoEmpId(string txt)
        {
            SqlCommand cmd = sda.GetQuery("SELECT MAX(empId) FROM [Employee]");

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();

            string maxId = Convert.ToString(cmd.ExecuteScalar());

            int nextId = 1; // Default to 1 if no employees exist

            if (!string.IsNullOrEmpty(maxId) && maxId.StartsWith("E-") && int.TryParse(maxId.Substring(2), out int currentMaxId))
            {
                nextId = currentMaxId + 1;
            }
            txt = "E-" + nextId.ToString("D3");

            cmd.Connection.Close();


            return txt;
        }
    }
}
