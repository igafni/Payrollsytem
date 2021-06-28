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
    public partial class frm_login : Form
    {
        private Form1 frm;
        public frm_login(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text == "gafni" && txt_password.Text == "king" )
            { 
                frm.enable_menu();
                this.Close();
            }
            else
            {
                MessageBox.Show("Accounts does not exist! please contact Itay Gafni The Lord Of The Seven Kingdoms","login failed",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
