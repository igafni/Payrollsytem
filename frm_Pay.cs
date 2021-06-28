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
    public partial class frm_Pay : Form
    {
        public frm_Pay()
        {
            InitializeComponent();
        }

        usableFunction funct = new usableFunction();
        public string print{ get; set; }


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

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void Label35_Click(object sender, EventArgs e)
        {

        }
        private void btnempnew_Click(object sender, EventArgs e)
        {

            id.Clear();
            fullname.Clear();


        }
        private void print_Click(object sender, EventArgs e)
        {
            bool flagEmployee = true;
            if (fullname.Text == "" || id.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flagEmployee = false;
            }
            if (!int.TryParse(id.Text, out int number))
            {
                MessageBox.Show("ID must be number!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flagEmployee = false;
            }
            if (flagEmployee)
            {
                int stringId = int.Parse(id.Text.Trim());
                string month = monthname.Value.ToString("MMMM");
                GetSalary g = new GetSalary(stringId, fullname.Text.Trim(), month);
                if (g._ErorSalary == "")
                {

                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)

                    {
                        btnempnew_Click(sender, e);
                        printDocument1.Print();
                    }
                }
                else
                {
                    MessageBox.Show(g._ErorSalary, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int stringId = int.Parse(id.Text.Trim());
            string month = monthname.Value.ToString("MMMM");
            GetSalary g = new GetSalary(stringId, fullname.Text.Trim(), month);
            
                if (g.Department == "מחלקת עובדים מקצועיים")
                    print = g.PrintProfessionalDepartmentSalaryReport();
                else
                    print = g.PrintManagementDepartmentSalaryReport();
                e.Graphics.DrawString(print, new Font("Time New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            }
           
        }
    }

