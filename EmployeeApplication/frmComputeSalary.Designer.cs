namespace EmployeeApplication
{
    partial class frmComputeSalary
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
            this.FirstNameTXT = new System.Windows.Forms.TextBox();
            this.LastNameTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DepartmentTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.JobTitleTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RatePerHourTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalHoursWorkedTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComputeSalaryBTN = new System.Windows.Forms.Button();
            this.Fname = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.Bsalary = new System.Windows.Forms.Label();
            this.BasicSalaryLBL = new System.Windows.Forms.Label();
            this.LastNameLBL = new System.Windows.Forms.Label();
            this.FirstNameLBL = new System.Windows.Forms.Label();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DepartmentLBL = new System.Windows.Forms.Label();
            this.JobTitleLBL = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SubmitBTN = new System.Windows.Forms.Button();
            this.EditBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // FirstNameTXT
            // 
            this.FirstNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTXT.Location = new System.Drawing.Point(12, 37);
            this.FirstNameTXT.Name = "FirstNameTXT";
            this.FirstNameTXT.Size = new System.Drawing.Size(212, 26);
            this.FirstNameTXT.TabIndex = 1;
            this.FirstNameTXT.TextChanged += new System.EventHandler(this.FirstNameTXT_TextChanged);
            // 
            // LastNameTXT
            // 
            this.LastNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTXT.Location = new System.Drawing.Point(230, 37);
            this.LastNameTXT.Name = "LastNameTXT";
            this.LastNameTXT.Size = new System.Drawing.Size(212, 26);
            this.LastNameTXT.TabIndex = 3;
            this.LastNameTXT.TextChanged += new System.EventHandler(this.LastNameTXT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name";
            // 
            // DepartmentTXT
            // 
            this.DepartmentTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentTXT.Location = new System.Drawing.Point(12, 90);
            this.DepartmentTXT.Name = "DepartmentTXT";
            this.DepartmentTXT.Size = new System.Drawing.Size(212, 26);
            this.DepartmentTXT.TabIndex = 5;
            this.DepartmentTXT.TextChanged += new System.EventHandler(this.DepartmentTXT_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department";
            // 
            // JobTitleTXT
            // 
            this.JobTitleTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobTitleTXT.Location = new System.Drawing.Point(230, 90);
            this.JobTitleTXT.Name = "JobTitleTXT";
            this.JobTitleTXT.Size = new System.Drawing.Size(212, 26);
            this.JobTitleTXT.TabIndex = 7;
            this.JobTitleTXT.TextChanged += new System.EventHandler(this.JobTitleTXT_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Job title";
            // 
            // RatePerHourTXT
            // 
            this.RatePerHourTXT.Enabled = false;
            this.RatePerHourTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatePerHourTXT.Location = new System.Drawing.Point(12, 204);
            this.RatePerHourTXT.Name = "RatePerHourTXT";
            this.RatePerHourTXT.Size = new System.Drawing.Size(212, 26);
            this.RatePerHourTXT.TabIndex = 9;
            this.RatePerHourTXT.TextChanged += new System.EventHandler(this.RatePerHourTXT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rate per hour";
            // 
            // TotalHoursWorkedTXT
            // 
            this.TotalHoursWorkedTXT.Enabled = false;
            this.TotalHoursWorkedTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHoursWorkedTXT.Location = new System.Drawing.Point(230, 204);
            this.TotalHoursWorkedTXT.Name = "TotalHoursWorkedTXT";
            this.TotalHoursWorkedTXT.Size = new System.Drawing.Size(212, 26);
            this.TotalHoursWorkedTXT.TabIndex = 11;
            this.TotalHoursWorkedTXT.TextChanged += new System.EventHandler(this.TotalHoursWorkedTXT_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total hours worked";
            // 
            // ComputeSalaryBTN
            // 
            this.ComputeSalaryBTN.Enabled = false;
            this.ComputeSalaryBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeSalaryBTN.Location = new System.Drawing.Point(157, 236);
            this.ComputeSalaryBTN.Name = "ComputeSalaryBTN";
            this.ComputeSalaryBTN.Size = new System.Drawing.Size(140, 33);
            this.ComputeSalaryBTN.TabIndex = 12;
            this.ComputeSalaryBTN.Text = "Compute Salary";
            this.ComputeSalaryBTN.UseVisualStyleBackColor = true;
            this.ComputeSalaryBTN.Click += new System.EventHandler(this.ComputeSalaryBTN_Click);
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(12, 287);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(88, 20);
            this.Fname.TabIndex = 13;
            this.Fname.Text = "First name:";
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(12, 318);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(88, 20);
            this.Lname.TabIndex = 14;
            this.Lname.Text = "Last name:";
            // 
            // Bsalary
            // 
            this.Bsalary.AutoSize = true;
            this.Bsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsalary.Location = new System.Drawing.Point(12, 348);
            this.Bsalary.Name = "Bsalary";
            this.Bsalary.Size = new System.Drawing.Size(100, 20);
            this.Bsalary.TabIndex = 15;
            this.Bsalary.Text = "Basic Salary:";
            // 
            // BasicSalaryLBL
            // 
            this.BasicSalaryLBL.AutoSize = true;
            this.BasicSalaryLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicSalaryLBL.Location = new System.Drawing.Point(106, 348);
            this.BasicSalaryLBL.Name = "BasicSalaryLBL";
            this.BasicSalaryLBL.Size = new System.Drawing.Size(49, 20);
            this.BasicSalaryLBL.TabIndex = 16;
            this.BasicSalaryLBL.Text = "00.00";
            // 
            // LastNameLBL
            // 
            this.LastNameLBL.AutoSize = true;
            this.LastNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLBL.Location = new System.Drawing.Point(106, 318);
            this.LastNameLBL.Name = "LastNameLBL";
            this.LastNameLBL.Size = new System.Drawing.Size(132, 20);
            this.LastNameLBL.TabIndex = 17;
            this.LastNameLBL.Text = "<last name here>";
            // 
            // FirstNameLBL
            // 
            this.FirstNameLBL.AutoSize = true;
            this.FirstNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLBL.Location = new System.Drawing.Point(106, 287);
            this.FirstNameLBL.Name = "FirstNameLBL";
            this.FirstNameLBL.Size = new System.Drawing.Size(133, 20);
            this.FirstNameLBL.TabIndex = 18;
            this.FirstNameLBL.Text = "<first name here>";
            // 
            // ClearBTN
            // 
            this.ClearBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBTN.Location = new System.Drawing.Point(157, 236);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(140, 33);
            this.ClearBTN.TabIndex = 19;
            this.ClearBTN.Text = "Clear";
            this.ClearBTN.UseVisualStyleBackColor = true;
            this.ClearBTN.Visible = false;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(202, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Department:";
            // 
            // DepartmentLBL
            // 
            this.DepartmentLBL.AutoSize = true;
            this.DepartmentLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLBL.Location = new System.Drawing.Point(296, 287);
            this.DepartmentLBL.Name = "DepartmentLBL";
            this.DepartmentLBL.Size = new System.Drawing.Size(133, 20);
            this.DepartmentLBL.TabIndex = 21;
            this.DepartmentLBL.Text = "<first name here>";
            // 
            // JobTitleLBL
            // 
            this.JobTitleLBL.AutoSize = true;
            this.JobTitleLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobTitleLBL.Location = new System.Drawing.Point(296, 318);
            this.JobTitleLBL.Name = "JobTitleLBL";
            this.JobTitleLBL.Size = new System.Drawing.Size(133, 20);
            this.JobTitleLBL.TabIndex = 23;
            this.JobTitleLBL.Text = "<first name here>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(228, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Job Title:";
            // 
            // SubmitBTN
            // 
            this.SubmitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBTN.Location = new System.Drawing.Point(157, 122);
            this.SubmitBTN.Name = "SubmitBTN";
            this.SubmitBTN.Size = new System.Drawing.Size(140, 33);
            this.SubmitBTN.TabIndex = 24;
            this.SubmitBTN.Text = "Submit";
            this.SubmitBTN.UseVisualStyleBackColor = true;
            this.SubmitBTN.Visible = false;
            this.SubmitBTN.Click += new System.EventHandler(this.SubmitBTN_Click);
            // 
            // EditBTN
            // 
            this.EditBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBTN.Location = new System.Drawing.Point(157, 236);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(140, 33);
            this.EditBTN.TabIndex = 25;
            this.EditBTN.Text = "Edit";
            this.EditBTN.UseVisualStyleBackColor = true;
            this.EditBTN.Visible = false;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 384);
            this.Controls.Add(this.SubmitBTN);
            this.Controls.Add(this.JobTitleLBL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DepartmentLBL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FirstNameLBL);
            this.Controls.Add(this.LastNameLBL);
            this.Controls.Add(this.BasicSalaryLBL);
            this.Controls.Add(this.Bsalary);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.ComputeSalaryBTN);
            this.Controls.Add(this.TotalHoursWorkedTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RatePerHourTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.JobTitleTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DepartmentTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearBTN);
            this.Controls.Add(this.EditBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmComputeSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Salary Calculator";
            this.Load += new System.EventHandler(this.frmComputeSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTXT;
        private System.Windows.Forms.TextBox LastNameTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DepartmentTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox JobTitleTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RatePerHourTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalHoursWorkedTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ComputeSalaryBTN;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Bsalary;
        private System.Windows.Forms.Label BasicSalaryLBL;
        private System.Windows.Forms.Label LastNameLBL;
        private System.Windows.Forms.Label FirstNameLBL;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DepartmentLBL;
        private System.Windows.Forms.Label JobTitleLBL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SubmitBTN;
        private System.Windows.Forms.Button EditBTN;
    }
}

