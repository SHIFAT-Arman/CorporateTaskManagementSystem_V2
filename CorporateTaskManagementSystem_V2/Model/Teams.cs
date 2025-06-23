using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorporateTaskManagementSystem_V2.Model;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class Teams
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();


        public void AddTask(Team te)
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
            SqlCommand cmd = sda.GetQuery("UPDATE Team SET teamName=@teamName, teamCreationDate=@teamCreationDate,deptId=@deptId;");
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
            cmd.Parameters.AddWithValue("@teamId",teamId);
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
                    te.TeamId = reader.GetString(0);
                    te.TeamName = reader.GetString(1);
                    te.TeamCreationDate = reader.GetDateTime(2);
                    te.DeptId = reader.GetString(3);

                    teamList.Add(te);
                }
                cmd.Connection.Close();
            }
            return teamList;
        }
        public List<Team> GetAllTeam()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Team;");
            cmd.CommandType = CommandType.Text;
            List<Team> teamList = GetData(cmd);
            return teamList;
        }
        public Team SearchTeam(string teamId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Team where teamId=@teamId;");
            cmd.Parameters.AddWithValue("@teamId", teamId);
            List<Team> teamList = new List<Team>();
            if (teamList.Count > 0)
            {
                return teamList[0];
            }
            else
            {
                return null;
            }
      }
    }
}
