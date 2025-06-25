using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class Teams
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();


        public void AddTeam(Team te)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO TEAM VALUES(@teamId,@teamName,@teamCreationDate,@deptId);");
            cmd.Parameters.AddWithValue("teamId", te.TeamId);
            cmd.Parameters.AddWithValue("teamName", te.TeamName);
            cmd.Parameters.AddWithValue("teamCreationDate", te.TeamCreationDate);
            cmd.Parameters.AddWithValue("deptId", te.DeptId);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void UpdateTeam(Team te)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Team SET teamName=@teamName, teamCreationDate=@teamCreationDate,deptId=@deptId WHERE teamId=@teamId;");
            cmd.Parameters.AddWithValue("teamId", te.TeamId);
            cmd.Parameters.AddWithValue("teamName", te.TeamName);
            cmd.Parameters.AddWithValue("teamCreationDate", te.TeamCreationDate);
            cmd.Parameters.AddWithValue("deptId", te.DeptId);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void DeleteTeam(string teamId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Team WHERE teamId=@teamId;");
            cmd.Parameters.AddWithValue("@teamId", teamId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public List<Team> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Team> teamList = new List<Team>();

            using (reader)
            {
                while (reader.Read())
                {
                    Team te = new Team();
                    /* te.TeamId = reader.GetString(0);
                     te.TeamName = reader.GetString(1);
                     te.TeamCreationDate = reader.GetDateTime(2);
                     te.DeptId = reader.GetString(3); */

                    te.TeamId = reader["teamId"].ToString();
                    te.TeamName = reader["teamName"].ToString();
                    te.TeamCreationDate = Convert.ToDateTime(reader["teamCreationDate"]);
                    te.DeptId = reader["deptId"].ToString();

                    teamList.Add(te);
                }
                cmd.Connection.Close();
            }
            return teamList;
        }
        public List<Team> GetAllTeamByDeptId(string deptId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Team where deptId=@deptId;");
            cmd.Parameters.AddWithValue("@deptId", deptId);
            cmd.CommandType = CommandType.Text;
            List<Team> teamList = GetData(cmd);
            return teamList;
        }
        public List<Team> GetTeamByDeptName(string deptName)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Team WHERE deptId IN (SELECT deptId FROM Department WHERE deptName=@deptName);");
            cmd.Parameters.AddWithValue("@deptName", deptName);
            cmd.CommandType = CommandType.Text;
            List<Team> teamList = GetData(cmd);
            return teamList;
        }
        public List<Team> GetAllTeam()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Team;");
            cmd.CommandType = CommandType.Text;
            List<Team> teamList = GetData(cmd);
            return teamList;
        }
        public List<Team> GetAllTeamByTeamName(string teamName)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Team WHERE teamName LIKE '%' + @teamName + '%'");
            cmd.Parameters.AddWithValue("@teamName", teamName );
            cmd.CommandType = CommandType.Text;
            List<Team> teamList = GetData(cmd);
            return teamList;
        }
        public Team SearchTeam(string teamId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Team where teamId=@teamId;");
            cmd.Parameters.AddWithValue("@teamId", teamId);
            List<Team> teamList = GetData(cmd);
            if (teamList.Count > 0)
            {
                return teamList[0];
            }
            else
            {
                return null;
            }
        }
        public string AutoTeamId(string txt)
        {
            SqlCommand cmd = sda.GetQuery("SELECT MAX(teamId) FROM [Team]");

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();

            string maxId = Convert.ToString(cmd.ExecuteScalar());

            int nextId = 1; // Default to 1 if no employees exist

            if (!string.IsNullOrEmpty(maxId) && maxId.StartsWith("TE-") && int.TryParse(maxId.Substring(3), out int currentMaxId))
            {
                nextId = currentMaxId + 1;
            }
            txt = "TE-" + nextId.ToString("D3");

            cmd.Connection.Close();


            return txt;
        }
    }
}
