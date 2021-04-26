using CompanyBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyBL.Controller
{
    public class EmployeeController : BaseController
    {
        public EmployeeController() { }

        public void HireEmp(Employee employee, List<Skill> skills, Vacansy vacansy)
        {
            manager.HireEmp(employee, skills, vacansy);
        }

        public List<Employee> UpdateEmp()
        {
            return db.Employees.ToList();
        }

        public void Fire(Employee employee)
        {
            db.Employees.Remove(employee);
            db.SaveChanges();
        }
    }
}
