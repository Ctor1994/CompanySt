using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyBL.Model
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public bool Bonus { get; set; }
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public Vacansy Vacansy { get; set; }
        public int VacansyId { get; set; }

        public BaseEmployee() { }
        public override string ToString()
        {
            return Name + " " + SecondName;
        }
    }
}