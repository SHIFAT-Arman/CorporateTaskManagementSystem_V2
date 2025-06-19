using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class Login
    {
        private string empEmail;
        private string empPassword;
        private string empPosition;

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
        public string EmpPosition
        {
            get { return empPosition; }
            set { empPosition = value; }
        }

        public Login(string empEmail, string empPassword, string empPosition)
        {
            this.empEmail = empEmail;
            this.empPassword = empPassword;
            this.empPosition = empPosition;
        }

        public Login()
        {
        }
    }
}
