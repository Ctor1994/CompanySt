using CompanyBL.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CompanyBL.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CompanyUI
{
    public partial class Main : Form 
    {

        CompanyContext db;
        public Main()
        {
            InitializeComponent();
            db = new CompanyContext();
            UpdateAll();
        }

        private void UpdateAll()
        {
            UpdateDep();
            UpdateEmp();
            UpdateVac();
        }
        private void UpdateVac()
        {
            var vac = db.Vacansies.ToList();
            lblVac.Text = vac.Count.ToString();
            foreach (var item in vac)
            {
                if (!cboVacancy.Items.Contains(item))
                {
                    cboVacancy.Items.Add(item);
                }
            }
        }
        private void UpdateDep()
        {
            var departs = departmentController.UpdateDep();
            lblDepCount.Text = departs.Count.ToString();
            foreach (var item in departs)
            {
                if (!cboDeparts.Items.Contains(item))
                {
                    cboDeparts.Items.Add(item);
                }
            }
        }

        private void UpdateEmp()
        {
            var emplys = db.Employees.ToList();
            lblEmplys.Text = emplys.Count.ToString();
            foreach (var item in emplys)
            {
                if (!cboEmpleys.Items.Contains(item))
                {
                    cboEmpleys.Items.Add(item);
                }
            }
        }

        DepartmentController departmentController = new DepartmentController();
        public static Department Dep { get; set; }
        private void btnMakeDep_Click(object sender, EventArgs e)
        {
            
            var form = new MakeDepartmentForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                departmentController.MakeDep(form.Department);
                MessageBox.Show(form.Department.Name + ": was made");
            }
             
            UpdateDep();
        }

        List<Skill> SkillsTemp = new List<Skill>();
        public static Department DepartmentTemp { get; set; }

        EmployeeController employeeController = new EmployeeController();

        private void Hire()
        {
            if (cboDeparts.SelectedItem != null)
            {
                DepartmentTemp = cboDeparts.SelectedItem as Department;
                
                var form = new HireEmploee();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SkillsTemp = form.skills33;
                    if (form.Position == "Employee")
                    {
                        employeeController.HireEmp(form.Employee, form.skills33);
                        MessageBox.Show(form.Employee.Name + ": was hired");
                    }
                }
            }
            else
            {
                MessageBox.Show("Department not selected!");
            }
        }

        private void btnHireEmp_Click(object sender, EventArgs e)
        {
            Hire();
            UpdateEmp();
        }

        private void Fire()
        {
            var empl = cboEmpleys.SelectedItem as Employee;
            db.Employees.Remove(empl);
            db.SaveChanges();
            cboEmpleys.Items.Remove(empl);
            MessageBox.Show(empl.Name + ": was fired");
        }

        private void CloseDep()
        {
            var dep = cboDeparts.SelectedItem as Department;
            db.Departments.Remove(dep);
            db.SaveChanges();
            cboDeparts.Items.Remove(dep);
            MessageBox.Show(dep.Name + ": was closed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fire();
            UpdateEmp();
        }

        private void btnCloseDep_Click(object sender, EventArgs e)
        {
            CloseDep();
            UpdateDep();
        }


        // TODO: Empl привязать к Vacansy, а Vacansy привязать к Departms если юзера создаём вакансия удаляется

        VacansyController vacansyController = new VacansyController();

        private void MakeVac()
        {
            if (cboDeparts.SelectedItem != null)
            {
                DepartmentTemp = cboDeparts.SelectedItem as Department;

                var form = new MakeVacancyForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    vacansyController.MakeVac(form.Vacansy);

                    MessageBox.Show(form.Vacansy.Name + ": was made");
                }
            }
            else
            {
                MessageBox.Show("Department not selected!");
            }
        }



        private void btnMakeVac_Click(object sender, EventArgs e)
        {
            MakeVac();
            UpdateVac();
        }
    }
}
