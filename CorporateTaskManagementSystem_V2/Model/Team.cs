using System;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class Team
    {
        private string teamId;
        private string teamName;
        private DateTime teamCreationDate;
        private string deptId;

        public string TeamId
        {
            get { return this.teamId; }
            set { this.teamId = value; }
        }
        public string TeamName
        {
            get { return this.teamName; }
            set { this.teamName = value; }
        }
        public DateTime TeamCreationDate
        {
            get { return this.teamCreationDate; }
            set { this.teamCreationDate = value; }
        }
        public string DeptId
        {
            get { return this.deptId; }
            set { this.deptId = value; }
        }

        public Team()
        {

        }
        public Team(string teamId, string teamName, DateTime teamCreationDate, string deptId)
        {
            this.teamId = teamId;
            this.teamName = teamName;
            this.teamCreationDate = teamCreationDate;
            this.deptId = deptId;
        }
    }
}
