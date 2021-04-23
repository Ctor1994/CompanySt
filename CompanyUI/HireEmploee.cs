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
        int countEmp = 0;

        List<string> SkillsList = new List<string>() { "English", "C#", "Java", "Excel", "Make Coffee", "MS SQL", "Java Script", "Asp.net core", "WPF", "WCF", "WinForm" };
        List<string> Positions = new List<string>() {"Employee", "Manager"};
        public HireEmploee()
        {
            InitializeComponent();
            cboSkillSet.Items.AddRange(SkillsList.ToArray());
            cboPosition.Items.AddRange(Positions.ToArray());
        }
        public List<Skill> skills33;
        public List<Skill> SelectSkills()
        {
            skills33 = new List<Skill>();
            foreach (var item in LBSkills.Items)
            {
                skills33.Add
                (
                    new Skill { Name = item.ToString() }
                );
            }
            return skills33;
        }
        public string Position { get; set; }
        private void btnHire_Click(object sender, EventArgs e)
        {
            Position = cboPosition.SelectedItem.ToString();
            if (cboPosition.SelectedItem.ToString() == "Employee")
            {
                Employee = new Employee()
                {
                    Id = countEmp,
                    Name = txbEmplName.Text,
                    SecondName = txbSecName.Text,
                    BirthDate = dtpBirth.Value,
                    Salary = nudSalary.Value,
                    //Department = Main.DepartmentTemp,
                    Bonus = false
                };
                countEmp++;
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
    }
}
