using CompanyBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CompanyUI
{
    public partial class HireEmploee : Form
    {
        public Employee Employee { get; set; }
        public Manager Manager { get; set; }
        int countEmp = 0;
        int countManag = 0;
        public string Position { get; set; }
        public List<Skill> skillsTepm;
        private readonly List<string> SkillsList = new List<string>() { "English", "C#", "Java", "Excel", "Make Coffee", "MS SQL", "Java Script", "Asp.net core", "WPF", "WCF", "WinForm" };
        private readonly List<string> Positions = new List<string>() {"Employee", "Manager"};
        public HireEmploee()
        {
            InitializeComponent();
            cboSkillSet.Items.AddRange(SkillsList.ToArray());
            cboPosition.Items.AddRange(Positions.ToArray());
        }
        private void btnHire_Click(object sender, EventArgs e)
        {
            Position = cboPosition.SelectedItem.ToString();
            if (Position == "Employee")
            {
                Employee = new Employee()
                {
                    Id = countEmp,
                    Name = txbEmplName.Text,
                    SecondName = txbSecName.Text,
                    BirthDate = dtpBirth.Value,
                    Salary = nudSalary.Value,
                    Bonus = false
                };
                countEmp++;
                SelectSkills();
            }
            else if (Position == "Manager")
            {
                Manager = new Manager()
                {
                    Id = countManag,
                    Name = txbEmplName.Text,
                    SecondName = txbSecName.Text,
                    BirthDate = dtpBirth.Value,
                    Salary = nudSalary.Value,
                    Bonus = false,
                    //employees = new List<Employee>()
                };
                countManag++;
                SelectSkills();
            }
        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            if (cboSkillSet.Items.Count != 0)
            {
                if (!LBSkills.Items.Contains(cboSkillSet.SelectedItem))
                {
                    LBSkills.Items.Add(cboSkillSet.SelectedItem.ToString());
                }
            }
        }
        public List<Skill> SelectSkills()
        {
            skillsTepm = new List<Skill>();
            foreach (var item in LBSkills.Items)
            {
                skillsTepm.Add
                (
                    new Skill { Name = item.ToString() }
                );
            }
            return skillsTepm;
        }
    }
}
