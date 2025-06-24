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
            SqlCommand cmd = sda.GetQuery("INSERT INTO Department VALUES(@deptId,@deptName); ");
            cmd.Parameters.AddWithValue("@deptId", d.DeptId);
            cmd.Parameters.AddWithValue("@deptName", d.DeptName);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void UpdateDepartment(Department d)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Department SET deptName=@deptName WHERE deptId=@deptId;");
            cmd.Parameters.AddWithValue("@deptId", d.DeptId);
            cmd.Parameters.AddWithValue("@deptName", d.DeptName);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void DeleteDepartment(string deptId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Department WHERE deptId=@deptId;");
            cmd.Parameters.AddWithValue("@deptId", deptId);
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

        // search department by deptId from Team and Department table
        public Department GetDepartmentByTeamId(string teamId)
        {
            SqlCommand cmd = sda.GetQuery(@" SELECT d.* FROM Department d JOIN Team t ON d. deptId = t.deptId WHERE t.teamId = @teamId;");
            cmd.Parameters.AddWithValue("@teamId", teamId);
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
    }
}
