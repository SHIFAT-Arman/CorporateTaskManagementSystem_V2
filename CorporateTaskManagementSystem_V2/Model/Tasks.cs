using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CorporateTaskManagementSystem_V2.Model;
using System.Runtime.Remoting.Messaging;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class Tasks
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();
        private const string DefaultTaskId = "T-100";
        

        public void AddTask(Task task)
        {

            task.TaskId = GetNextTaskId();

            SqlCommand cmd = sda.GetQuery("INSERT INTO Task VALUES (@taskId, @taskName, @taskAssignedDate, @taskStatus, @teamId);");
            cmd.Parameters.AddWithValue("@taskId", task.TaskId);
            cmd.Parameters.AddWithValue("@taskName", task.TaskName);
            cmd.Parameters.AddWithValue("@taskAssignedDate", task.TaskAssignedDate);
            cmd.Parameters.AddWithValue("@taskStatus", task.TaskStatus);
           // cmd.Parameters.AddWithValue("@teamId", (task.TeamId) );
            if (string.IsNullOrEmpty(task.TeamId))
            {
                cmd.Parameters.AddWithValue("@teamId", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@teamId", task.TeamId);
            }
            

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        private string GetNextTaskId()
        {
            var lastId = DefaultTaskId;
            var query = "SELECT TOP 1 taskId FROM Task ORDER BY taskId DESC";

            using (var cmd = sda.GetQuery(query))
            {
                cmd.Connection.Open();
                using (var reader = cmd.ExecuteReader()){
                    if (reader.Read())
                    {
                        lastId = reader["taskId"].ToString();
                    }
                }
                cmd.Connection.Close();

                if(lastId.StartsWith("T-")&&int.TryParse(lastId.Substring(2),out var number))
                {
                    return $"T-{number + 1}";

                }
                return DefaultTaskId;

            }
        }

        public void UpdateTask(Task task)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Task SET  taskName=@taskName,taskAssignedDate=@taskAssignedDate, taskStatus=@taskStatus, teamId=@teamId WHERE taskId=@taskId;");
           cmd.Parameters.AddWithValue("@taskId", task.TaskId);
            cmd.Parameters.AddWithValue("@taskName", task.TaskName);
            cmd.Parameters.AddWithValue("@taskAssignedDate", task.TaskAssignedDate);
            cmd.Parameters.AddWithValue("@taskStatus", task.TaskStatus ?? "Pending");
            cmd.Parameters.AddWithValue("@teamId", task.TeamId ?? string.Empty);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeleteTask(string taskId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Task WHERE taskId=@taskId;");
            cmd.Parameters.AddWithValue("@taskId", taskId);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public List<Task> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Task> taskList = new List<Task>();

            using (reader)
            {
                while (reader.Read())
                {
                    Task t = new Task();
                    t.TaskId = reader.GetString(0);
                    t.TaskName = reader.GetString(1);
                    t.TaskAssignedDate = reader.GetDateTime(2);
                    t.TaskStatus = reader.GetString(3);
                    //t.TeamId = reader.GetString(4) as string;
                    t.TeamId = reader.IsDBNull(4) ? null:reader.GetString(4) ;

                    taskList.Add(t);

                }
                cmd.Connection.Close();

                return taskList;
            }
                 
        }


        public List<Task> GetAllTask()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Task;");
            cmd.CommandType = CommandType.Text;
            List<Task> taskList = GetData(cmd);

            return taskList;
        }

        public Task Search(string taskId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Task where taskId=@taskId;");
            cmd.Parameters.AddWithValue("@taskId", taskId);
            List<Task> taskList = GetData(cmd);

            if (taskList.Count > 0)
            {
                return taskList[0];
            }
            else
            {
                return null;
            }

        }
       
    }
}
