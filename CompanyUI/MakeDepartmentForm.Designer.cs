
namespace CompanyUI
{
    partial class MakeDepartmentForm
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
            this.txbDepName = new System.Windows.Forms.TextBox();
            this.btnOkDep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbDepName
            // 
            this.txbDepName.Location = new System.Drawing.Point(79, 63);
            this.txbDepName.Name = "txbDepName";
            this.txbDepName.Size = new System.Drawing.Size(333, 23);
            this.txbDepName.TabIndex = 0;
            // 
            // btnOkDep
            // 
            this.btnOkDep.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkDep.Location = new System.Drawing.Point(337, 251);
            this.btnOkDep.Name = "btnOkDep";
            this.btnOkDep.Size = new System.Drawing.Size(75, 23);
            this.btnOkDep.TabIndex = 1;
            this.btnOkDep.Text = "Make";
            this.btnOkDep.UseVisualStyleBackColor = true;
            this.btnOkDep.Click += new System.EventHandler(this.btnOkDep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Department Name";
            // 
            // MakeDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOkDep);
            this.Controls.Add(this.txbDepName);
            this.Name = "MakeDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeDepartmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.AcceptButton = this.btnOkDep;


        }

        #endregion

        private System.Windows.Forms.TextBox txbDepName;
        private System.Windows.Forms.Button btnOkDep;
        private System.Windows.Forms.Label label1;
    }
}