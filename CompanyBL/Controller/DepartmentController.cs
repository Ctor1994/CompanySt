using CompanyBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyBL.Controller
{
    public class DepartmentController : BaseController
    {
        public DepartmentController() { }

        public void MakeDep(Department department)
        {
            manager.MakeDep(department);
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
