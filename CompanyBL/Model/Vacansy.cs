using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyBL.Model
{
    public class Vacansy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public List<Skill> Skills { get; set; }

        public Employee Employee { get; set; }

        public Vacansy() { }

        public override string ToString()
        {
            return Name;
        }
    }
}