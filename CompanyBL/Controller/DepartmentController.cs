using CompanyBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyBL.Controller
{
    public class DepartmentController
    {
        CompanyContext db;
        
        public DepartmentController()
        {
            db = new CompanyContext();
        }
        public void MakeDep(Department department)
        {
            using (var db = new CompanyContext())
            {
                db.Departments.Add(department);
                db.SaveChanges();
            }
        }

        public List<Department> UpdateDep()
        {
            return db.Departments.ToList();
        }

        public void CloseDep(Department department)
        {
            db.Departments.Remove(department);
            db.SaveChanges();
        }
    }
}
