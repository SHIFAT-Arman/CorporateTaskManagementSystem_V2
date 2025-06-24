using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class Logins
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddLogin(Login login)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Login (empId, empEmail, empPassword, empPosition) VALUES (@empId, @empEmail, @empPassword, @empPosition);");
            cmd.Parameters.AddWithValue("@empId", login.EmpId);
            cmd.Parameters.AddWithValue("@empEmail", login.EmpEmail);
            cmd.Parameters.AddWithValue("@empPassword", login.EmpPassword);

            if (login.EmpEmail.Contains("admin"))
            {
                cmd.Parameters.AddWithValue("@empPosition", login.EmpPosition);
            }
            else if (login.EmpEmail.Contains("dept"))
            {
                cmd.Parameters.AddWithValue("@empPosition", login.EmpPosition);

            }
            else if (login.EmpEmail.Contains("emp"))
            {
                cmd.Parameters.AddWithValue("@empPosition", login.EmpPosition);
            }

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void UpdateLogin(Login login)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Login SET empEmail=@empEmail, empPassword = @empPassword WHERE empId = @empId;");
            cmd.Parameters.AddWithValue("@empId", login.EmpId);
            cmd.Parameters.AddWithValue("@empEmail", login.EmpEmail);
            cmd.Parameters.AddWithValue("@empPassword", login.EmpPassword);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void DeleteLogin(string empId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Login WHERE empId=@empId;");
            cmd.Parameters.AddWithValue("@empId", empId);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public List<Login> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Login> loginList = new List<Login>();

            using (reader)
            {
                while (reader.Read())
                {
                    Login login = new Login();
                    login.EmpId = reader.GetString(0);
                    login.EmpEmail = reader.GetString(1);
                    login.EmpPassword = reader.GetString(2);
                    login.EmpPosition = reader.GetString(3);

                    loginList.Add(login);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return loginList;
        }
        public Login SearchLogin(string empId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Login WHERE empId=@empId;");
            cmd.Parameters.AddWithValue("@empId", empId);

            cmd.CommandType = CommandType.Text;
            List<Login> loginList = GetData(cmd);

            if (loginList.Count > 0)
            {
                return loginList[0];
            }
            else
            {
                return null;
            }
        }
        public List<Login> GetAllLogins()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Login;");
            cmd.CommandType = CommandType.Text;
            return GetData(cmd);
        }
    }
}
