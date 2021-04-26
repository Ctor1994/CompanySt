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

        public static Vacansy Vacansy { get; set; }
        public Vacansy Vacansy1 { get; set; }
        int countVac = 0;
        public MakeVacancyForm()
        {
            InitializeComponent();
        }

        private void btnOkDep_Click(object sender, EventArgs e)
        {
            Vacansy1 = new Vacansy()
            {
                //Id = countVac,
                Name = txbVacName.Text,
                Salary = nudSalary.Value,
            };
            Vacansy = Vacansy1;
            //countVac++;
        }
    }
}