using CorporateTaskManagementSystem_V2.Model;
using System.Collections.Generic;

namespace CorporateTaskManagementSystem_V2.Controller
{
    public class DepartmentController
    {
        public void AddDepartment(Department d)
        {
            Departments dd = new Departments();
            dd.AddDepartment(d);
        }

        public void UpdateDepartment(Department d)
        {
            Departments dd = new Departments();
            dd.UpdateDepartment(d);
        }

        public void DeleteDepartment(string deptId)
        {
            Departments dd = new Departments();
            dd.DeleteDepartment(deptId);
        }
        public Department SearchDept(string deptId)
        {
            Departments dd = new Departments();
            Department d = dd.SearchDept(deptId);
            return d;
        }
        public List<Department> GetAllDepartment()
        {
            Departments dd = new Departments();
            List<Department> deptList = dd.GetAllDept();
            return deptList;
        }
        public List<Department> GetAllDepartment(string deptName)
        {
            Departments dd = new Departments();
            List<Department> dList = dd.GetAllDept(deptName);
            return dList;
        }
    }
}
