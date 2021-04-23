using CompanyBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyBL.Controller
{
    public class ManagerController : BaseController
    {

        CompanyContext db;
        public ManagerController()
        {
            db = new CompanyContext();
        }

        public void HireManager(Manager manager, List<Skill> skills)
        {
            db.Managers.Add(manager);

            List<Skill> skills1 = new List<Skill>();
            skills1 = skills;

            manager.Skills.AddRange(skills1);
            db.SaveChanges();
        }
        public List<Manager> UpdateMan()
        {
            return db.Managers.ToList();
        }
    }
}
