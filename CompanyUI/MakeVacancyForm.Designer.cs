
namespace CompanyUI
{
    partial class MakeVacancyForm
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
            this.btnOkVac = new System.Windows.Forms.Button();
            this.txbVacName = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input Vacansy Name";
            // 
            // btnOkVac
            // 
            this.btnOkVac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkVac.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkVac.Location = new System.Drawing.Point(346, 259);
            this.btnOkVac.Name = "btnOkVac";
            this.btnOkVac.Size = new System.Drawing.Size(75, 23);
            this.btnOkVac.TabIndex = 4;
            this.btnOkVac.Text = "Make";
            this.btnOkVac.UseVisualStyleBackColor = true;
            this.btnOkVac.Click += new System.EventHandler(this.btnOkDep_Click);
            // 
            // txbVacName
            // 
            this.txbVacName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbVacName.Location = new System.Drawing.Point(55, 73);
            this.txbVacName.Name = "txbVacName";
            this.txbVacName.Size = new System.Drawing.Size(366, 23);
            this.txbVacName.TabIndex = 3;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(55, 121);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(69, 15);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "Input Salary";
            // 
            // nudSalary
            // 
            this.nudSalary.DecimalPlaces = 2;
            this.nudSalary.Location = new System.Drawing.Point(55, 156);
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.Size = new System.Drawing.Size(177, 23);
            this.nudSalary.TabIndex = 8;
            // 
            // MakeVacancyForm
            // 
            this.AcceptButton = this.btnOkVac;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 360);
            this.Controls.Add(this.nudSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOkVac);
            this.Controls.Add(this.txbVacName);
            this.Name = "MakeVacancyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeVacancyForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.AcceptButton = this.btnOkVac;

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOkVac;
        private System.Windows.Forms.TextBox txbVacName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.NumericUpDown nudSalary;
    }
}