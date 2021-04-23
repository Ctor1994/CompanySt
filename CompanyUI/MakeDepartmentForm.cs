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
    public partial class MakeDepartmentForm : Form
    {
        public Department Department { get; set; }
        int countDep = 0;
        public MakeDepartmentForm()
        {

            InitializeComponent();
        }

        private void btnOkDep_Click(object sender, EventArgs e)
        {
            Department = new Department
            {
                Name = txbDepName.Text,
                Id = countDep
            };
            countDep++;
            Close();
        }
    }
}
