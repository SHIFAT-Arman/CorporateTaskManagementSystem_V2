using System;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class Department
    {
        private string deptId;
        private string deptName;
        private DateTime deptCreationDate;

        public string DeptId
        {
            get { return this.deptId; }
            set { this.deptId = value; }
        }

        public string DeptName
        {
            get { return this.deptName; }
            set { this.deptName = value; }
        }
        public DateTime DeptCreationDate
        {
            get { return this.deptCreationDate; }
            set { this.deptCreationDate = value; }
        }

        public Department()
        {

        }
        public Department(string deptId, string deptName, DateTime deptCreationDate)
        {
            this.deptId = deptId;
            this.deptName = deptName;
            DeptCreationDate = deptCreationDate;
        }
    }
}
