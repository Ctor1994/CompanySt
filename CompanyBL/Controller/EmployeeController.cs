using CompanyBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyBL.Controller
{
    public class EmployeeController
    {
        CompanyContext db;
        public EmployeeController()
        {
            db = new CompanyContext();
        }


        public void HireEmp(Employee employee, List<Skill> skills)
        {
            using (var db = new CompanyContext())
            {
                db.Employees.Add(employee);

                List<Skill> skills1 = new List<Skill>();
                skills1 = skills;

                employee.Skills.AddRange(skills1);
                db.SaveChanges();
            }
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
