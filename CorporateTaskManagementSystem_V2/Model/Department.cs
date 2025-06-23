using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class Department
    {
        private string deptId;
        private string deptName;

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

        public Department()
        {

        }
        public Department(string deptId,string deptName)
        {
            this.deptId = deptId;
            this.deptName = deptName;
        }
    }
}
