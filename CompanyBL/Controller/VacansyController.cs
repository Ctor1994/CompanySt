using CompanyBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyBL.Controller
{
    public class VacansyController : BaseController
    {
        public VacansyController() { }
        public void MakeVac(Vacansy vacansy)
        {
            using (var db = new CompanyContext())
            {
                db.Vacansies.Add(vacansy);
                db.SaveChanges();
            }
        }
        public List<Vacansy> UpdateМVac()
        {
            List<Vacansy> AllVacansies = new List<Vacansy>();
            List<Vacansy> NeededVacansies = new List<Vacansy>();

            AllVacansies.AddRange(db.Vacansies);
            var report = from vacancy in db.Vacansies
                          join employee in db.Employees on vacancy.Id equals employee.VacansyId
                          select vacancy;
            foreach (var item in AllVacansies)
            {
                if (!report.Contains(item))
                {
                    NeededVacansies.Add(item);
                }
            }
            return NeededVacansies;
        }
    }
}
