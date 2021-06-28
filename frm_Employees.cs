using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollSytem.Includes;



namespace PayrollSytem
{
    public partial class frm_Employees : Form
    {
        public frm_Employees()
        {
            InitializeComponent();
        }

        usableFunction funct = new usableFunction();
        string rdo;
        private void btnempsave_Click(object sender, EventArgs e)
        {
            bool flagEmployee = true;
            if (id.Text == "" || fullname.Text == "" || department.Text == "" || (managementemployee.Text == "" & profemployee.Text == ""))
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flagEmployee = false;
            }
            if (!int.TryParse(id.Text, out int number))
            {
                MessageBox.Show("ID must be number!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flagEmployee = false;
            }
            if (managementemployee.Text != "" & profemployee.Text != "")
            {
                MessageBox.Show("You can't enter Both Management role and Proffesional role.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flagEmployee = false;
            }
            else
            {
                if (managementemployee.Text != "" & department.Text == "מחלקת עובדים מקצועיים")
                {
                    MessageBox.Show("You can't create Management role in Proffesional Department", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    flagEmployee = false;
                }
                if (profemployee.Text != "" & department.Text == "מחלקת הנהלה")
                {
                    MessageBox.Show("You can't create Proffesional role in Management Department", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    flagEmployee = false;
                }
            }
            if (flagEmployee)
            {
                string stringDtpdbirth = dtpdbirth.Value.Date.ToString("dd/MM/yyyy");
                int stringId = int.Parse(id.Text.Trim());
                string fullName = fullname.Text.Trim();
                string employeeDepartment = department.Text;
                Registration RegistrationEmp;
                string message = "Kololololo new employee created";
                if (managementemployee.Text != "")
                {
                    RegistrationEmp = new Registration(stringId, fullName, stringDtpdbirth, employeeDepartment, managementemployee.Text);

                }
                else
                {
                    RegistrationEmp = new Registration(stringId, fullName, stringDtpdbirth, employeeDepartment, profemployee.Text);
                }
                if (RegistrationEmp.exist)
                {
                    message = "Employee is already in the system";

                }
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnempnew_Click(sender, e);
            
        



            }
        }


        private void btnempnew_Click(object sender, EventArgs e)
        {
            funct.clearTxt(GroupBox10);
            funct.clearTxt(GroupBox9);

            btnempsave.Enabled = true;
            id.Clear();
            


        }

        private void Label26_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void profemployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void managementemployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
