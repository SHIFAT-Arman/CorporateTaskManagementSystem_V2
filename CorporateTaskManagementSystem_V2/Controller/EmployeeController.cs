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
        public void UpdateEmployee(Employee employee)
        {
            Employees employees = new Employees();
            employees.UpdateEmployee(employee);
        }
        public void DeleteEmployee(string empId)
        {
            Employees employees = new Employees();
            employees.DeleteEmployee(empId);
        }
        public List<Employee> SearchEmployee(string empId)
        {
            Employees employees = new Employees();
            return employees.SearchEmployee(empId);
        }
        public List<Employee> GetAllEmployees()
        {
            Employees employees = new Employees();
            return employees.GetAllEmployees();
        }
    }
}
