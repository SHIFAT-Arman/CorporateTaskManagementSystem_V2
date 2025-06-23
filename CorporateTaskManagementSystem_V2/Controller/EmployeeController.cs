using CorporateTaskManagementSystem_V2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateTaskManagementSystem_V2.Controller
{
    public class EmployeeController
    {
        public void AddEmployee(Employee employee)
        {
            Employees employees = new Employees();
            employees.AddEmployee(employee);
        }
        public List<Employee> GetAllEmployees()
        {
            Employees employees = new Employees();
            return employees.GetAllEmployees();
        }
    }
}
