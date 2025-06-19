using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CorporateTaskManagementSystem_V2.Model;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class Logins
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddLogin(Login login)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Logins (empEmail, empPassword) VALUES (@empEmail, @empPassword);");
            cmd.Parameters.AddWithValue("@empEmail", login.EmpEmail);
            cmd.Parameters.AddWithValue("@empPassword", login.EmpPassword);

            if (login.EmpEmail.Contains("admin"))
            {
                cmd.Parameters.AddWithValue("empPosition", "Admin");
            }
            else if (login.EmpEmail.Contains("dept"))
            {
                cmd.Parameters.AddWithValue("empPosition", "Department Head");
                
            }
            else if (login.EmpEmail.Contains("emp"))
            {
                cmd.Parameters.AddWithValue("empPosition", "Regular Employee");
                
            }

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void UpdateLogin(Login login)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Login SET empPassword = @empPassword WHERE empEmail = @empEmail;");
            cmd.Parameters.AddWithValue("@empPassword", login.EmpPassword);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void DeleteLogin(string empEmail)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Logins WHERE empEmail = @empEmail;");
            cmd.Parameters.AddWithValue("@empEmail", empEmail);
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
                    login.EmpEmail = reader.GetString(0);
                    login.EmpPassword = reader.GetString(1);

                    loginList.Add(login);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return loginList;
        }
        public Login SearchLogin(string empEmail)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Login WHERE empEmail = @empEmail;");
            cmd.Parameters.AddWithValue("@empEmail", empEmail);

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
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Logins;");
            cmd.CommandType = CommandType.Text;
            return GetData(cmd);
        }
    }
}
