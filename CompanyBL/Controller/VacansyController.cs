using CompanyBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyBL.Controller
{
    public class VacansyController
    {
        CompanyContext db;

        public VacansyController()
        {
            db = new CompanyContext();
        }
        public void MakeVac(Vacansy vacansy)
        {
            using (var db = new CompanyContext())
            {
                db.Vacansies.Add(vacansy);
                db.SaveChanges();
            }
        }
        public List<Vacansy> UpdateDep()
        {
            var vacans = db.Vacansies.ToList();
            return vacans;
        }
    }
}
