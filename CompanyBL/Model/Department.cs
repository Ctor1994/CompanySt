using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyBL.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department() { }

        public override string ToString()
        {
            return Name;
        }
    }
}
