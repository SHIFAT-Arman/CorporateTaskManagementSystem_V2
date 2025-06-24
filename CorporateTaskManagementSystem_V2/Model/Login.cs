namespace CorporateTaskManagementSystem_V2.Model
{
    public class Login
    {
        private string empId;
        private string empEmail;
        private string empPassword;
        private string empPosition;

        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
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
        public string EmpPosition
        {
            get { return empPosition; }
            set { empPosition = value; }
        }

        public Login(string empId, string empEmail, string empPassword, string empPosition)
        {
            this.empId = empId;
            this.empEmail = empEmail;
            this.empPassword = empPassword;
            this.empPosition = empPosition;
        }

        public Login()
        {
        }
    }
}
