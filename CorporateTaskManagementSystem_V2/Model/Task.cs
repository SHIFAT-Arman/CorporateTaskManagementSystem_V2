using System;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class Task
    {
        private string taskId;
        private string taskName;
        private DateTime taskAssignedDate;
        private string taskStatus;
        private string teamId;

        public string TaskId
        {
            get { return this.taskId; }
            set { this.taskId = value; }
        }
        public string TaskName
        {
            get { return this.taskName; }
            set { this.taskName = value; }
        }
        public DateTime TaskAssignedDate
        {
            get { return this.taskAssignedDate; }
            set { this.taskAssignedDate = value; }
        }
        public string TaskStatus
        {
            get { return this.taskStatus; }
            set { this.taskStatus = value; }
        }
        public string TeamId
        {
            get { return this.teamId; }
            set { this.teamId = value; }
        }

        public Task(string taskId, string taskName, DateTime taskAssignedDate, string taskStatus, string teamId)
        {
            this.taskId = taskId;
            this.taskName = taskName;
            this.taskAssignedDate = taskAssignedDate;
            this.taskStatus = taskStatus;
            this.teamId = teamId;

        }
        public Task()
        {

        }
    }
}
