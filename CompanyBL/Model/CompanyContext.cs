using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyBL.Model
{
    public class CompanyContext : DbContext
    {
        public CompanyContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=N105124;Database=exDb;Trusted_Connection=True;");
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vacansy> Vacansies { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
