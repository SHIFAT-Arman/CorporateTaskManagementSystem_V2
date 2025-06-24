using CorporateTaskManagementSystem_V2.Model;
using System.Collections.Generic;


namespace CorporateTaskManagementSystem_V2.Controller
{
    class TaskController
    {
        public void AddTask(Model.Task t)
        {
            Tasks tt = new Tasks();
            tt.AddTask(t);
        }

        public void UpdateTask(Model.Task t)
        {
            Tasks tt = new Tasks();
            tt.UpdateTask(t);
        }

        public void DeleteTask(string taskId)
        {
            Tasks tt = new Tasks();
            tt.DeleteTask(taskId);
        }

        public Model.Task Search(string taskId)
        {
            Tasks tt = new Tasks();
            Model.Task t = tt.Search(taskId);
            return t;
        }

        public List<Model.Task> GetAllTask()
        {
            Tasks tt = new Tasks();
            List<Model.Task> taskList = tt.GetAllTask();
            return taskList;
        }
    }
}
