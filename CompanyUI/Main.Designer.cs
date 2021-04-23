
namespace CompanyUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMakeDep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDepCount = new System.Windows.Forms.Label();
            this.cboDeparts = new System.Windows.Forms.ComboBox();
            this.lblStatstiv = new System.Windows.Forms.Label();
            this.cboEmpleys = new System.Windows.Forms.ComboBox();
            this.lblEmplys = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHireEmp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCloseDep = new System.Windows.Forms.Button();
            this.btnMakeVac = new System.Windows.Forms.Button();
            this.cboVacancy = new System.Windows.Forms.ComboBox();
            this.lblVac = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMakeDep
            // 
            this.btnMakeDep.Location = new System.Drawing.Point(582, 79);
            this.btnMakeDep.Name = "btnMakeDep";
            this.btnMakeDep.Size = new System.Drawing.Size(150, 23);
            this.btnMakeDep.TabIndex = 0;
            this.btnMakeDep.Text = "Open Department";
            this.btnMakeDep.UseVisualStyleBackColor = true;
            this.btnMakeDep.Click += new System.EventHandler(this.btnMakeDep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount Department:";
            // 
            // lblDepCount
            // 
            this.lblDepCount.AutoSize = true;
            this.lblDepCount.Location = new System.Drawing.Point(182, 83);
            this.lblDepCount.Name = "lblDepCount";
            this.lblDepCount.Size = new System.Drawing.Size(13, 15);
            this.lblDepCount.TabIndex = 2;
            this.lblDepCount.Text = "0";
            // 
            // cboDeparts
            // 
            this.cboDeparts.FormattingEnabled = true;
            this.cboDeparts.Location = new System.Drawing.Point(43, 102);
            this.cboDeparts.Name = "cboDeparts";
            this.cboDeparts.Size = new System.Drawing.Size(152, 23);
            this.cboDeparts.TabIndex = 3;
            // 
            // lblStatstiv
            // 
            this.lblStatstiv.AutoSize = true;
            this.lblStatstiv.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatstiv.Location = new System.Drawing.Point(267, 20);
            this.lblStatstiv.Name = "lblStatstiv";
            this.lblStatstiv.Size = new System.Drawing.Size(247, 25);
            this.lblStatstiv.TabIndex = 4;
            this.lblStatstiv.Text = "Common company statistics";
            // 
            // cboEmpleys
            // 
            this.cboEmpleys.FormattingEnabled = true;
            this.cboEmpleys.Location = new System.Drawing.Point(43, 169);
            this.cboEmpleys.Name = "cboEmpleys";
            this.cboEmpleys.Size = new System.Drawing.Size(152, 23);
            this.cboEmpleys.TabIndex = 7;
            // 
            // lblEmplys
            // 
            this.lblEmplys.AutoSize = true;
            this.lblEmplys.Location = new System.Drawing.Point(182, 150);
            this.lblEmplys.Name = "lblEmplys";
            this.lblEmplys.Size = new System.Drawing.Size(13, 15);
            this.lblEmplys.TabIndex = 6;
            this.lblEmplys.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount Employees";
            // 
            // btnHireEmp
            // 
            this.btnHireEmp.Location = new System.Drawing.Point(582, 156);
            this.btnHireEmp.Name = "btnHireEmp";
            this.btnHireEmp.Size = new System.Drawing.Size(150, 23);
            this.btnHireEmp.TabIndex = 8;
            this.btnHireEmp.Text = "Hire employee";
            this.btnHireEmp.UseVisualStyleBackColor = true;
            this.btnHireEmp.Click += new System.EventHandler(this.btnHireEmp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Fire employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCloseDep
            // 
            this.btnCloseDep.Location = new System.Drawing.Point(582, 108);
            this.btnCloseDep.Name = "btnCloseDep";
            this.btnCloseDep.Size = new System.Drawing.Size(150, 23);
            this.btnCloseDep.TabIndex = 10;
            this.btnCloseDep.Text = "Close Department";
            this.btnCloseDep.UseVisualStyleBackColor = true;
            this.btnCloseDep.Click += new System.EventHandler(this.btnCloseDep_Click);
            // 
            // btnMakeVac
            // 
            this.btnMakeVac.Location = new System.Drawing.Point(582, 228);
            this.btnMakeVac.Name = "btnMakeVac";
            this.btnMakeVac.Size = new System.Drawing.Size(150, 23);
            this.btnMakeVac.TabIndex = 11;
            this.btnMakeVac.Text = "Make vacancy";
            this.btnMakeVac.UseVisualStyleBackColor = true;
            this.btnMakeVac.Click += new System.EventHandler(this.btnMakeVac_Click);
            // 
            // cboVacancy
            // 
            this.cboVacancy.FormattingEnabled = true;
            this.cboVacancy.Location = new System.Drawing.Point(43, 229);
            this.cboVacancy.Name = "cboVacancy";
            this.cboVacancy.Size = new System.Drawing.Size(152, 23);
            this.cboVacancy.TabIndex = 14;
            // 
            // lblVac
            // 
            this.lblVac.AutoSize = true;
            this.lblVac.Location = new System.Drawing.Point(182, 208);
            this.lblVac.Name = "lblVac";
            this.lblVac.Size = new System.Drawing.Size(13, 15);
            this.lblVac.TabIndex = 13;
            this.lblVac.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount Vacancy";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboVacancy);
            this.Controls.Add(this.lblVac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMakeVac);
            this.Controls.Add(this.btnCloseDep);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHireEmp);
            this.Controls.Add(this.cboEmpleys);
            this.Controls.Add(this.lblEmplys);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatstiv);
            this.Controls.Add(this.cboDeparts);
            this.Controls.Add(this.lblDepCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMakeDep);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDepCount;
        private System.Windows.Forms.ComboBox cboDeparts;
        private System.Windows.Forms.Label lblStatstiv;
        private System.Windows.Forms.ComboBox cboEmpleys;
        private System.Windows.Forms.Label lblEmplys;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHireEmp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCloseDep;
        private System.Windows.Forms.Button btnMakeVac;
        private System.Windows.Forms.ComboBox cboVacancy;
        private System.Windows.Forms.Label lblVac;
        private System.Windows.Forms.Label label4;
    }
}