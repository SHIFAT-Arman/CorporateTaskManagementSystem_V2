using CorporateTaskManagementSystem_V2.Model;
using System.Collections.Generic;

namespace CorporateTaskManagementSystem_V2.Controller
{
    public class LoginController
    {
        public void AddLogin(Login login)
        {
            Logins logins = new Logins();
            logins.AddLogin(login);
        }
        public void UpdateLogin(Login login)
        {
            Logins logins = new Logins();
            logins.UpdateLogin(login);
        }
        public void DeleteLogin(string empEmail)
        {
            Logins logins = new Logins();
            logins.DeleteLogin(empEmail);
        }
        public Login SearchLogin(string empId)
        {
            Logins logins = new Logins();
            Login login = logins.SearchLogin(empId);
            return login;
        }

        public List<Login> GetAllLogins()
        {
            Logins logins = new Logins();
            List<Login> loginList = logins.GetAllLogins();
            return loginList;
        }
    }
}
