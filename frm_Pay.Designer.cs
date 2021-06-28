namespace PayrollSytem
{
    partial class frm_Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pay));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.GroupBox10 = new System.Windows.Forms.GroupBox();
            this.hidenprint = new System.Windows.Forms.Label();
            this.monthname = new System.Windows.Forms.DateTimePicker();
            this.Label35 = new System.Windows.Forms.Label();
            this.printSalary = new System.Windows.Forms.Button();
            this.Label34 = new System.Windows.Forms.Label();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.TextBox();
            this.fullname = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage6.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.GroupBox10);
            this.TabPage6.Controls.Add(this.GroupBox9);
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabPage6.Size = new System.Drawing.Size(839, 436);
            this.TabPage6.TabIndex = 0;
            this.TabPage6.Text = "Create PayRoll";
            this.TabPage6.UseVisualStyleBackColor = true;
            // 
            // GroupBox10
            // 
            this.GroupBox10.Controls.Add(this.hidenprint);
            this.GroupBox10.Controls.Add(this.monthname);
            this.GroupBox10.Controls.Add(this.Label35);
            this.GroupBox10.Controls.Add(this.printSalary);
            this.GroupBox10.Controls.Add(this.Label34);
            this.GroupBox10.Location = new System.Drawing.Point(31, 167);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox10.Size = new System.Drawing.Size(785, 195);
            this.GroupBox10.TabIndex = 19;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "משכורת";
            // 
            // hidenprint
            // 
            this.hidenprint.AutoSize = true;
            this.hidenprint.Location = new System.Drawing.Point(95, 134);
            this.hidenprint.Name = "hidenprint";
            this.hidenprint.Size = new System.Drawing.Size(0, 13);
            this.hidenprint.TabIndex = 17;
            this.hidenprint.Visible = false;
            // 
            // monthname
            // 
            this.monthname.CustomFormat = "MMMM";
            this.monthname.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthname.Location = new System.Drawing.Point(579, 78);
            this.monthname.Name = "monthname";
            this.monthname.Size = new System.Drawing.Size(200, 20);
            this.monthname.TabIndex = 6;
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Location = new System.Drawing.Point(718, 62);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(58, 13);
            this.Label35.TabIndex = 5;
            this.Label35.Text = "בחר חודש";
            this.Label35.Click += new System.EventHandler(this.Label35_Click);
            // 
            // printSalary
            // 
            this.printSalary.Location = new System.Drawing.Point(612, 143);
            this.printSalary.Name = "printSalary";
            this.printSalary.Size = new System.Drawing.Size(167, 32);
            this.printSalary.TabIndex = 16;
            this.printSalary.Text = "הדפס משכורת חודשית";
            this.printSalary.UseVisualStyleBackColor = true;
            this.printSalary.Click += new System.EventHandler(this.print_Click);
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Location = new System.Drawing.Point(451, 21);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(328, 13);
            this.Label34.TabIndex = 4;
            this.Label34.Text = "*אם לא ייבחר חודש המערכת תחשב משכורת לפי החודש הנוכחי";
            // 
            // GroupBox9
            // 
            this.GroupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox9.Controls.Add(this.id);
            this.GroupBox9.Controls.Add(this.fullname);
            this.GroupBox9.Controls.Add(this.Label20);
            this.GroupBox9.Controls.Add(this.Label26);
            this.GroupBox9.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.GroupBox9.Location = new System.Drawing.Point(31, 31);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox9.Size = new System.Drawing.Size(791, 96);
            this.GroupBox9.TabIndex = 18;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "פרטי עובד";
            this.GroupBox9.UseWaitCursor = true;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(507, 19);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(200, 20);
            this.id.TabIndex = 15;
            this.id.UseWaitCursor = true;
            // 
            // fullname
            // 
            this.fullname.Location = new System.Drawing.Point(507, 56);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(200, 20);
            this.fullname.TabIndex = 0;
            this.fullname.UseWaitCursor = true;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(718, 32);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(67, 13);
            this.Label20.TabIndex = 16;
            this.Label20.Text = "תעודת זהות";
            this.Label20.UseWaitCursor = true;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(731, 63);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(48, 13);
            this.Label26.TabIndex = 1;
            this.Label26.Text = "שם מלא";
            this.Label26.UseWaitCursor = true;
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage6);
            this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2.Location = new System.Drawing.Point(0, 0);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(847, 462);
            this.TabControl2.TabIndex = 4;
            // 
            // frm_Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 462);
            this.Controls.Add(this.TabControl2);
            this.Name = "frm_Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployees";
            this.TabPage6.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.TabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        internal System.Windows.Forms.TabPage TabPage6;
        internal System.Windows.Forms.GroupBox GroupBox10;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.TextBox fullname;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Button printSalary;
        internal System.Windows.Forms.TabControl TabControl2;
        internal System.Windows.Forms.TextBox id;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label35;
        internal System.Windows.Forms.Label Label34;
        private System.Windows.Forms.DateTimePicker monthname;
        private System.Windows.Forms.Label hidenprint;
    }
}