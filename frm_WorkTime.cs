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
    public partial class frm_WorkTime : Form
    {
        public frm_WorkTime()
        {
            InitializeComponent();
        }

        usableFunction funct = new usableFunction();
        private void btnsave_Click(object sender, EventArgs e)
        {
            bool flagEmployee = true;
            if (worktimeid.Text == "" ||
            worktimefullname.Text == "" )
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
                flagEmployee = false;
            }
            if (!int.TryParse(worktimeid.Text, out int number))
            {
                MessageBox.Show("ID must be number!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flagEmployee = false;
            }
            if (flagEmployee)
            {
                DateTime starttime = dateTimeFullStart.Value.Date + hourStart.Value.TimeOfDay;
                string start = starttime.ToString("dd/MM/yyyy HH:mm");
                DateTime endtime = dateTimeFullEnd.Value.Date + hourEnd.Value.TimeOfDay;
                string end = endtime.ToString("dd/MM/yyyy HH:mm");
                if (starttime > endtime)
                {
                    MessageBox.Show("End Time must be greater Start Time", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {


                    int stringId = int.Parse(worktimeid.Text.Trim());
                    string fullName = worktimefullname.Text.Trim();
                    InsertWorkTime work = new InsertWorkTime(stringId, fullName, start, end);
                    if (work._eror != "")
                    {
                        MessageBox.Show(work._eror, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        string show = String.Format("Kololololo new work time added to {0}.",
                                 fullName);
                        MessageBox.Show(show, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        btnempnew_Click(sender, e);
                    }
                }
            }
           
        }

        private void btnempnew_Click(object sender, EventArgs e)
        {
            funct.clearTxt(GroupBox11);
            funct.clearTxt(worktimefullname);

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label38_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
