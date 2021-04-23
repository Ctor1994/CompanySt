using CompanyBL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyBL.Controller
{
    public class EmployeeController
    {
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
        public EmployeeController()
        {

        }
    }
}
