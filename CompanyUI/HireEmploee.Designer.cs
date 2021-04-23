
namespace CompanyUI
{
    partial class HireEmploee
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHire = new System.Windows.Forms.Button();
            this.txbEmplName = new System.Windows.Forms.TextBox();
            this.txbSecName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSkillSet = new System.Windows.Forms.ComboBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAddSkill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBSkills = new System.Windows.Forms.ListBox();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input Employee Name";
            // 
            // btnHire
            // 
            this.btnHire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHire.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnHire.Location = new System.Drawing.Point(395, 308);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(75, 23);
            this.btnHire.TabIndex = 4;
            this.btnHire.Text = "Hire";
            this.btnHire.UseVisualStyleBackColor = true;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // txbEmplName
            // 
            this.txbEmplName.Location = new System.Drawing.Point(218, 28);
            this.txbEmplName.Name = "txbEmplName";
            this.txbEmplName.Size = new System.Drawing.Size(125, 23);
            this.txbEmplName.TabIndex = 3;
            // 
            // txbSecName
            // 
            this.txbSecName.Location = new System.Drawing.Point(218, 67);
            this.txbSecName.Name = "txbSecName";
            this.txbSecName.Size = new System.Drawing.Size(125, 23);
            this.txbSecName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Input Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Select skill set";
            // 
            // cboSkillSet
            // 
            this.cboSkillSet.FormattingEnabled = true;
            this.cboSkillSet.Location = new System.Drawing.Point(218, 191);
            this.cboSkillSet.Name = "cboSkillSet";
            this.cboSkillSet.Size = new System.Drawing.Size(125, 23);
            this.cboSkillSet.TabIndex = 14;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(218, 106);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(125, 23);
            this.dtpBirth.TabIndex = 15;
            // 
            // btnAddSkill
            // 
            this.btnAddSkill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSkill.Location = new System.Drawing.Point(218, 268);
            this.btnAddSkill.Name = "btnAddSkill";
            this.btnAddSkill.Size = new System.Drawing.Size(125, 23);
            this.btnAddSkill.TabIndex = 16;
            this.btnAddSkill.Text = "Add skill";
            this.btnAddSkill.UseVisualStyleBackColor = true;
            this.btnAddSkill.Click += new System.EventHandler(this.btnAddSkill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input Second Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "List of skills";
            // 
            // LBSkills
            // 
            this.LBSkills.FormattingEnabled = true;
            this.LBSkills.ItemHeight = 15;
            this.LBSkills.Location = new System.Drawing.Point(375, 67);
            this.LBSkills.Name = "LBSkills";
            this.LBSkills.Size = new System.Drawing.Size(120, 94);
            this.LBSkills.TabIndex = 19;
            // 
            // nudSalary
            // 
            this.nudSalary.DecimalPlaces = 2;
            this.nudSalary.Location = new System.Drawing.Point(218, 145);
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.Size = new System.Drawing.Size(125, 23);
            this.nudSalary.TabIndex = 20;
            // 
            // cboPosition
            // 
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(218, 228);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(125, 23);
            this.cboPosition.TabIndex = 22;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(61, 236);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(54, 15);
            this.lblPosition.TabIndex = 21;
            this.lblPosition.Text = "Posotion";
            // 
            // HireEmploee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 390);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.nudSalary);
            this.Controls.Add(this.LBSkills);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddSkill);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.cboSkillSet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSecName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.txbEmplName);
            this.Name = "HireEmploee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HireEmploee";
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.TextBox txbEmplName;
        private System.Windows.Forms.TextBox txbSecName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSkillSet;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Button btnAddSkill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox LBSkills;
        private System.Windows.Forms.NumericUpDown nudSalary;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.Label lblPosition;
    }
}