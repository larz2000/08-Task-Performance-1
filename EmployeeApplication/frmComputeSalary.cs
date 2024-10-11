using EmployeeApplication;
using EmployeeInterface;
using EmployeeNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        Regex reg1 = new Regex("(^\\d+\\.?\\d+$)|(^\\.?\\d+$)");
        Regex reg2 = new Regex("^[0-9]+$");

        public frmComputeSalary()
        {
            InitializeComponent();
        }

        //count the number of dots
        public bool countDot(string text)
        {
            int count = 0;
            bool a = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    count++;
                }
            }
            if (count > 1)
            {
                a = false;
            }
            return a;
        }

        //disable specific texboxes
        public void DisableInformation() 
        {
            FirstNameTXT.Enabled = false;
            LastNameTXT.Enabled = false;
            DepartmentTXT.Enabled = false;
            JobTitleTXT.Enabled = false;
        }

        //enable specific textboxes
        public void EnableInformation() 
        {
            FirstNameTXT.Enabled = true;
            LastNameTXT.Enabled = true;
            DepartmentTXT.Enabled = true;
            JobTitleTXT.Enabled = true;
        }

        private void ComputeSalaryBTN_Click(object sender, EventArgs e)
        {
            //check if all textboxes is not empty
            if (!FirstNameTXT.Text.Equals("") && !LastNameTXT.Text.Equals("") && !DepartmentTXT.Text.Equals("") &&
                !JobTitleTXT.Text.Equals("") && !RatePerHourTXT.Text.Equals("") && !TotalHoursWorkedTXT.Text.Equals(""))
            {
                PartTimeEmployee pte = new PartTimeEmployee(FirstNameTXT.Text, LastNameTXT.Text, DepartmentTXT.Text, JobTitleTXT.Text);
                pte.computeSalary(Convert.ToInt32(TotalHoursWorkedTXT.Text), Convert.ToDouble(RatePerHourTXT.Text));
                FirstNameLBL.Text = pte.FirstName;
                LastNameLBL.Text = pte.LastName;
                BasicSalaryLBL.Text = "PHP "+pte.getSalary().ToString("#,##0.00");
                DepartmentLBL.Text = pte.Department;
                JobTitleLBL.Text = pte.JobTitle;
                this.Size = new Size(472, 423);
                ComputeSalaryBTN.Visible = false;
                EditBTN.Location = new Point(84, 236);
                EditBTN.Visible = true;
                ClearBTN.Location = new Point(230, 236);
                ClearBTN.Visible = true;
                RatePerHourTXT.Enabled = false;
                TotalHoursWorkedTXT.Enabled = false;
            }
            else 
            {
                MessageBox.Show("Complete the information!");
            }
  
        }

        private void frmComputeSalary_Load(object sender, EventArgs e)
        {
            this.Size = new Size(472, 320);
        }

        //reset
        private void ClearBTN_Click(object sender, EventArgs e)
        {
            FirstNameTXT.Clear();
            LastNameTXT.Clear();
            DepartmentTXT.Clear();
            JobTitleTXT.Clear();
            RatePerHourTXT.Clear();
            TotalHoursWorkedTXT.Clear();
            RatePerHourTXT.Enabled = false;
            TotalHoursWorkedTXT.Enabled = false;
            EnableInformation();
            FirstNameLBL.Text = "";
            LastNameLBL.Text = "";
            DepartmentLBL.Text = "";
            JobTitleLBL.Text = "";

            //hide output
            this.Size = new Size(472, 320);
            ComputeSalaryBTN.Visible = true;
            ClearBTN.Visible = false;
            EditBTN.Visible = false;

        }

        private void RatePerHourTXT_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;//sender store reference to the variable

            //check if inputs are decimal numbers or numbers only
            if (countDot(txt.Text) && (reg1.IsMatch(txt.Text) || reg2.IsMatch(txt.Text)) && reg2.IsMatch(TotalHoursWorkedTXT.Text))
            {
                ComputeSalaryBTN.Enabled = true;// compute button will be enabled
            }
            else 
            {
                ComputeSalaryBTN.Enabled = false;// compute button will be disabled
                ComputeSalaryBTN.Visible = true;
                ClearBTN.Visible = false;
            }
        }

        private void TotalHoursWorkedTXT_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;//sender store reference to the variable

            //check if inputs are only numbers
            if (countDot(txt.Text) && reg2.IsMatch(txt.Text) && (reg1.IsMatch(RatePerHourTXT.Text)||reg2.IsMatch(RatePerHourTXT.Text)))
            {
                ComputeSalaryBTN.Enabled = true;// compute button will be enabled
            }
            else
            {
                ComputeSalaryBTN.Enabled = false;// compute button will be disabled
                ComputeSalaryBTN.Visible = true;
                ClearBTN.Visible = false;
            }
        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            if (!FirstNameTXT.Text.Equals("") && !LastNameTXT.Text.Equals("") && !DepartmentTXT.Text.Equals("") &&
                !JobTitleTXT.Text.Equals("")) 
            {
                DisableInformation();
                RatePerHourTXT.Enabled = true;
                TotalHoursWorkedTXT.Enabled = true;
                ComputeSalaryBTN.Enabled = true;
                SubmitBTN.Visible = false;
            }
        }

        private void FirstNameTXT_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!txt.Text.Equals("") && !LastNameTXT.Text.Equals("") && !DepartmentTXT.Text.Equals("") &&
                !JobTitleTXT.Text.Equals(""))
            {
                SubmitBTN.Visible = true;
            }
        }

        private void LastNameTXT_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!FirstNameTXT.Text.Equals("") && !txt.Text.Equals("") && !DepartmentTXT.Text.Equals("") &&
                !JobTitleTXT.Text.Equals(""))
            {
                SubmitBTN.Visible = true;
            }

        }

        private void DepartmentTXT_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!FirstNameTXT.Text.Equals("") && !LastNameTXT.Text.Equals("") && !txt.Text.Equals("") &&
                !JobTitleTXT.Text.Equals(""))
            {
                SubmitBTN.Visible = true;
            }
        }

        private void JobTitleTXT_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!FirstNameTXT.Text.Equals("") && !LastNameTXT.Text.Equals("") && !DepartmentTXT.Text.Equals("") &&
                !txt.Text.Equals(""))
            {
                SubmitBTN.Visible = true;
            }
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            RatePerHourTXT.Enabled = true;
            TotalHoursWorkedTXT.Enabled = true;
            ClearBTN.Visible = false;
            ComputeSalaryBTN.Visible = true;
            EditBTN.Visible = false;
        }
    }
}

namespace EmployeeInterface 
{
    public interface IEmployee
    {
        string FirstName {  get; set; }
        string LastName { get; set; }   
        string Department { get; set; }
        string JobTitle {  get; set; }
        double BasicSalary { get; set; }

        void computeSalary(int hoursWorked, double ratePerHour);
    }
}

namespace EmployeeNamespace 
{
    public class PartTimeEmployee:IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;

        public string FirstName 
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string LastName 
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string Department 
        {
            get { return department; }
            set { department = value; }
        }

        public string JobTitle 
        {
            get { return job_title; }
            set { job_title = value; }
        }

        public double BasicSalary 
        {
            get { return basic_salary; }
            set { basic_salary = value; }
        }

        public PartTimeEmployee(string FName, string LName, string dept, string job) 
        {
            FirstName = FName;
            LastName = LName;
            Department = dept;
            JobTitle = job;
        }

        public void computeSalary(int hoursWorked, double ratePerHour) 
        {
            BasicSalary = hoursWorked * ratePerHour;
        }

        public double getSalary() 
        {
            return basic_salary;
        }



    }
}
