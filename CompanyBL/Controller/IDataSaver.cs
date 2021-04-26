using CompanyBL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyBL.Controller
{
    public interface IDataSaver
    {
        void MakeDep(Department department);
        void HireEmp(Employee employee, List<Skill> skills, Vacansy vacansy);
    }
}
