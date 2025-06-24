using System;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class Employee
    {
        private string empId;
        private string empFirstName;
        private string empLastName;
        private string empEmail;
        private string empPassword;
        private DateTime empDOB;
        private DateTime empJoinDate;
        private byte[] empPfp;
        private string empPosition;
        private float empSalary;
        private string teamId;
        private string deptId;

        public Employee()
        {
        }

        public Employee(string empId, string empFirstName, string empLastName, string empEmail, string empPassword, DateTime empDOB, DateTime empJoinDate, byte[] empPfp, string empPosition, float empSalary, string teamId, string deptId)
        {
            this.empId = empId;
            this.empFirstName = empFirstName;
            this.empLastName = empLastName;
            this.empEmail = empEmail;
            this.empPassword = empPassword;
            this.empDOB = empDOB;
            this.empJoinDate = empJoinDate;
            this.empPfp = empPfp;
            this.empPosition = empPosition;
            this.empSalary = empSalary;
            this.teamId = teamId;
            this.deptId = deptId;
        }

        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        public string EmpFirstName
        {
            get { return empFirstName; }
            set { empFirstName = value; }
        }
        public string EmpLastName
        {
            get { return empLastName; }
            set { empLastName = value; }
        }
        public string EmpEmail
        {
            get { return empEmail; }
            set { empEmail = value; }
        }
        public string EmpPassword
        {
            get { return empPassword; }
            set { empPassword = value; }
        }
        public DateTime EmpDOB
        {
            get { return empDOB; }
            set { empDOB = value; }
        }
        public DateTime EmpJoinDate
        {
            get { return empJoinDate; }
            set { empJoinDate = value; }
        }
        public byte[] EmpPfp
        {
            get { return empPfp; }
            set { empPfp = value; }
        }
        public string EmpPosition
        {
            get { return empPosition; }
            set { empPosition = value; }
        }
        public float EmpSalary
        {
            get { return empSalary; }
            set { empSalary = value; }
        }
        public string TeamId
        {
            get { return teamId; }
            set { teamId = value; }
        }
        public string DeptId
        {
            get { return deptId; }
            set { deptId = value; }
        }
    }
}
