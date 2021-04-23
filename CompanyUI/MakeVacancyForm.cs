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
    public partial class MakeVacancyForm : Form
    {

        public Vacansy Vacansy { get; set; }
        int countVac = 0;
        public MakeVacancyForm()
        {
            InitializeComponent();
        }

        private void btnOkDep_Click(object sender, EventArgs e)
        {
            Vacansy = new Vacansy()
            {
                Id = countVac,
                Name = txbVacName.Text,
                Salary = nudSalary.Value,
            };
            countVac++;
        }
    }
}