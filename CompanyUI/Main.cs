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
        VacansyController vacansyController = new VacansyController();
        DepartmentController departmentController = new DepartmentController();
        EmployeeController employeeController = new EmployeeController();
        ManagerController managerController = new ManagerController();
        public static Department DepartmentTemp { get; set; }
        public static Vacansy VacansyTemp { get; set; }
        List<Skill> SkillsTemp = new List<Skill>();

        public Main()
        {
            InitializeComponent();
            UpdateAll();
        }

        private void btnMakeDep_Click(object sender, EventArgs e)
        {
            var form = new MakeDepartmentForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                departmentController.MakeDep(form.Department);
                UpdateDep();
                MessageBox.Show(form.Department + ": was made");
            }

        }
        private void btnHireEmp_Click(object sender, EventArgs e)
        {
            Hire();
            UpdateAll();
        }

        private void btnMakeVac_Click(object sender, EventArgs e)
        {
            MakeVac();
            UpdateAll();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            Fire();
            UpdateAll();
        }
        private void btnCloseDep_Click(object sender, EventArgs e)
        {
            CloseDep();
            UpdateAll();
        }

        private void Hire()
        {
            //if ((cboDeparts.SelectedItem != null) && (cboVacancy.SelectedItem != null))
            if ((cboDeparts.SelectedItem != null))
            {
                DepartmentTemp = cboDeparts.SelectedItem as Department;
                VacansyTemp = cboVacancy.SelectedItem as Vacansy;
                var form = new HireEmploee(VacansyTemp);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SkillsTemp = form.skillsTepm;
                    if (form.Position == "Employee")
                    {
                        employeeController.HireEmp(form.Employee, form.skillsTepm, VacansyTemp);
                        MessageBox.Show(form.Employee + ": was hired");
                    }
                    if (form.Position == "Manager")
                    {
                        managerController.HireManager(form.Manager, form.skillsTepm);
                        MessageBox.Show(form.Manager + ": was hired");
                    }
                }
            }
            else
            {
                MessageBox.Show("Department not selected!");
            }
        }
        private void MakeVac()
        {
            if (cboDeparts.SelectedItem != null)
            {
                DepartmentTemp = cboDeparts.SelectedItem as Department;

                var form = new MakeVacancyForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    vacansyController.MakeVac(form.Vacansy1);

                    MessageBox.Show(form.Vacansy1 + ": was made");
                }
            }
            else
            {
                MessageBox.Show("Department not selected!");
            }
        }
        private void Fire()
        {
            var empl = cboEmpleys.SelectedItem as Employee;
            employeeController.Fire(empl);
            cboEmpleys.Items.Remove(empl);
            MessageBox.Show(empl + ": was fired");
        }

        private void CloseDep()
        {
            var dep = cboDeparts.SelectedItem as Department;
            departmentController.CloseDep(dep);
            cboDeparts.Items.Remove(dep);
            MessageBox.Show(dep + ": was closed");
        }

        #region Update
        private void UpdateAll()
        
        {
            UpdateDep();
            UpdateEmp();
            UpdateVac();
            vacansyController.UpdateМVac();
        }


        private void UpdateVac()
        {
            var vac = vacansyController.UpdateМVac();

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
            var emplys = employeeController.UpdateEmp();
            var mana = managerController.UpdateMan();
            List<BaseEmployee> baseEmployees = new List<BaseEmployee>();
            baseEmployees.AddRange(emplys);
            baseEmployees.AddRange(mana);
            lblEmplys.Text = baseEmployees.Count.ToString();
            foreach (var item in baseEmployees)
            {
                if (!cboEmpleys.Items.Contains(item))
                {
                    cboEmpleys.Items.Add(item);
                }
            }
        }
        #endregion

    }
}
