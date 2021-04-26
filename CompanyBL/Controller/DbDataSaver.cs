using CompanyBL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyBL.Controller
{
    public class DbDataSaver : IDataSaver
    {

        public void MakeDep(Department department)
        {
            using (var db = new CompanyContext())
            {
                db.Departments.Add(department);
                db.SaveChanges();
            }
        }
        public void HireEmp(Employee employee, List<Skill> skills, Vacansy vacansy)
        {
            using (var db = new CompanyContext())
            {
                db.Employees.Add(employee);

                List<Skill> skills1 = new List<Skill>();
                skills1 = skills;

                employee.Skills.AddRange(skills1);
                //employee.Vacansies.Add(vacansy);
                db.SaveChanges();
            }
        }
    }
}
