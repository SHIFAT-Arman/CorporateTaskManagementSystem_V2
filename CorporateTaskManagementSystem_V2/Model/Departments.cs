using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class Departments
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddDepartment(Department d)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Department VALUES(@deptId,@deptName,@deptCreationDate); ");
            cmd.Parameters.AddWithValue("@deptId", d.DeptId);
            cmd.Parameters.AddWithValue("@deptName", d.DeptName);
            cmd.Parameters.AddWithValue("@deptCreationDate", d.DeptCreationDate);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void UpdateDepartment(Department d)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Department SET deptName=@deptName, deptCreationDate=@deptCreationDate WHERE deptId=@deptId;");
            cmd.Parameters.AddWithValue("@deptId", d.DeptId);
            cmd.Parameters.AddWithValue("@deptName", d.DeptName);
            cmd.Parameters.AddWithValue("@deptCreationDate", d.DeptCreationDate);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void DeleteDepartment(string deptId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Department WHERE deptId=@deptId;");
            cmd.Parameters.AddWithValue("@deptId", deptId);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public List<Department> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Department> deptList = new List<Department>();

            using (reader)
            {
                while (reader.Read())
                {
                    Department d = new Department();
                    d.DeptId = reader.GetString(0);
                    d.DeptName = reader.GetString(1);
                    d.DeptCreationDate = reader.IsDBNull (2) ? DateTime.MinValue : reader.GetDateTime(2); // Handle null values

                    deptList.Add(d);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return deptList;
        }

        public List<Department> GetAllDept()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Department;");
            cmd.CommandType = CommandType.Text;
            List<Department> deptList = GetData(cmd);

            return deptList;
        }
        
        public List<Department> GetAllDept(string deptName)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Department WHERE deptName LIKE '%' + @deptName + '%';");
            cmd.Parameters.AddWithValue("@deptName", deptName);
            cmd.CommandType = CommandType.Text;
            List<Department> deptList = GetData(cmd);
            return deptList;
        }
        public Department SearchDept(string deptId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Department Where deptId=@deptId;");
            cmd.Parameters.AddWithValue("@deptId", deptId);
            cmd.CommandType = CommandType.Text;
            List<Department> deptList = GetData(cmd);
            if (deptList.Count > 0)
            {
                return deptList[0];
            }
            else
            {
                return null;
            }
        }
        public string AutoDeptId(string txt)
        {
            SqlCommand cmd = sda.GetQuery("SELECT MAX(deptId) FROM [Department]");

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();

            string maxId = Convert.ToString(cmd.ExecuteScalar());

            int nextId = 1; // Default to 1 if no employees exist

            if (!string.IsNullOrEmpty(maxId) && maxId.StartsWith("D-") && int.TryParse(maxId.Substring(2), out int currentMaxId))
            {
                nextId = currentMaxId + 1;
            }
            txt = "D-" + nextId.ToString("D3");

            cmd.Connection.Close();


            return txt;
        }
    }
}
