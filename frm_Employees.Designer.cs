namespace PayrollSytem
{
    partial class frm_Employees
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
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.id = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.GroupBox10 = new System.Windows.Forms.GroupBox();
            this.profemployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.managementemployee = new System.Windows.Forms.ComboBox();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.ComboBox();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.dtpdbirth = new System.Windows.Forms.DateTimePicker();
            this.Label22 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.TextBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.btnempsave = new System.Windows.Forms.Button();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage6.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.id);
            this.TabPage6.Controls.Add(this.Label20);
            this.TabPage6.Controls.Add(this.GroupBox10);
            this.TabPage6.Controls.Add(this.GroupBox9);
            this.TabPage6.Controls.Add(this.btnempsave);
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabPage6.Size = new System.Drawing.Size(839, 436);
            this.TabPage6.TabIndex = 0;
            this.TabPage6.Text = "Add Employee";
            this.TabPage6.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(517, 43);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(200, 20);
            this.id.TabIndex = 15;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(741, 43);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(67, 13);
            this.Label20.TabIndex = 16;
            this.Label20.Text = "תעודת זהות";
            this.Label20.UseWaitCursor = true;
            // 
            // GroupBox10
            // 
            this.GroupBox10.Controls.Add(this.profemployee);
            this.GroupBox10.Controls.Add(this.label1);
            this.GroupBox10.Controls.Add(this.managementemployee);
            this.GroupBox10.Controls.Add(this.Label35);
            this.GroupBox10.Controls.Add(this.Label34);
            this.GroupBox10.Controls.Add(this.department);
            this.GroupBox10.Location = new System.Drawing.Point(31, 187);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox10.Size = new System.Drawing.Size(785, 175);
            this.GroupBox10.TabIndex = 19;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "פרטי עבודה";
            this.GroupBox10.Enter += new System.EventHandler(this.GroupBox10_Enter);
            // 
            // profemployee
            // 
            this.profemployee.FormattingEnabled = true;
            this.profemployee.Items.AddRange(new object[] {
            "",
            "חובש",
            "פארמדיק ",
            "אחות",
            "אחות ראשית",
            "מיילדת",
            "מיילדת לידת עכוז",
            "רופא סטאזר",
            "רופא סטאזר ומיילד לידת עכוז",
            "רופא",
            "רופא בכיר",
            "רופא מומחה",
            "ס. מנהל מחלקה",
            "מנהל מחלקה"});
            this.profemployee.Location = new System.Drawing.Point(201, 115);
            this.profemployee.Name = "profemployee";
            this.profemployee.Size = new System.Drawing.Size(154, 21);
            this.profemployee.TabIndex = 10;
            this.profemployee.SelectedIndexChanged += new System.EventHandler(this.profemployee_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "סוג עובד מחלקת מקצועיים";
            // 
            // managementemployee
            // 
            this.managementemployee.FormattingEnabled = true;
            this.managementemployee.Items.AddRange(new object[] {
            "",
            "מנקה",
            "מנקה חומרים רעילים",
            "רב מנקים",
            "אחמש מנקים",
            "טבח",
            "עוזר שף",
            "שף",
            "מחלק מזון",
            "ראש מחלקת מנהלה"});
            this.managementemployee.Location = new System.Drawing.Point(201, 34);
            this.managementemployee.Name = "managementemployee";
            this.managementemployee.Size = new System.Drawing.Size(154, 21);
            this.managementemployee.TabIndex = 8;
            this.managementemployee.SelectedIndexChanged += new System.EventHandler(this.managementemployee_SelectedIndexChanged);
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Location = new System.Drawing.Point(378, 34);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(128, 13);
            this.Label35.TabIndex = 5;
            this.Label35.Text = "סוג עובד מחלקת הנהלה";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Location = new System.Drawing.Point(737, 31);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(42, 13);
            this.Label34.TabIndex = 4;
            this.Label34.Text = "מחלקה";
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "מחלקת הנהלה",
            "מחלקת עובדים מקצועיים"});
            this.department.Location = new System.Drawing.Point(547, 31);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(154, 21);
            this.department.TabIndex = 0;
            // 
            // GroupBox9
            // 
            this.GroupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox9.Controls.Add(this.dtpdbirth);
            this.GroupBox9.Controls.Add(this.Label22);
            this.GroupBox9.Controls.Add(this.fullname);
            this.GroupBox9.Controls.Add(this.Label26);
            this.GroupBox9.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.GroupBox9.Location = new System.Drawing.Point(25, 74);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox9.Size = new System.Drawing.Size(791, 96);
            this.GroupBox9.TabIndex = 18;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "פרטים אישיים";
            this.GroupBox9.UseWaitCursor = true;
            this.GroupBox9.Enter += new System.EventHandler(this.GroupBox9_Enter);
            // 
            // dtpdbirth
            // 
            this.dtpdbirth.CustomFormat = "yyyy-MM-dd";
            this.dtpdbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdbirth.Location = new System.Drawing.Point(571, 60);
            this.dtpdbirth.Name = "dtpdbirth";
            this.dtpdbirth.Size = new System.Drawing.Size(121, 20);
            this.dtpdbirth.TabIndex = 12;
            this.dtpdbirth.UseWaitCursor = true;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(719, 66);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(69, 13);
            this.Label22.TabIndex = 11;
            this.Label22.Text = "תאריך לידה";
            this.Label22.UseWaitCursor = true;
            // 
            // fullname
            // 
            this.fullname.Location = new System.Drawing.Point(522, 29);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(170, 20);
            this.fullname.TabIndex = 0;
            this.fullname.UseWaitCursor = true;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(737, 32);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(48, 13);
            this.Label26.TabIndex = 1;
            this.Label26.Text = "שם מלא";
            this.Label26.UseWaitCursor = true;
            this.Label26.Click += new System.EventHandler(this.Label26_Click);
            // 
            // btnempsave
            // 
            this.btnempsave.Location = new System.Drawing.Point(409, 368);
            this.btnempsave.Name = "btnempsave";
            this.btnempsave.Size = new System.Drawing.Size(75, 32);
            this.btnempsave.TabIndex = 16;
            this.btnempsave.Text = "הוסף עובד";
            this.btnempsave.UseVisualStyleBackColor = true;
            this.btnempsave.Click += new System.EventHandler(this.btnempsave_Click);
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage6);
            this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2.Location = new System.Drawing.Point(0, 0);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(847, 462);
            this.TabControl2.TabIndex = 2;
            // 
            // frm_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 462);
            this.Controls.Add(this.TabControl2);
            this.Name = "frm_Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployees";
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.TabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabPage TabPage6;
        internal System.Windows.Forms.TextBox id;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.GroupBox GroupBox10;
        internal System.Windows.Forms.ComboBox profemployee;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox managementemployee;
        internal System.Windows.Forms.Label Label35;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.ComboBox department;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.DateTimePicker dtpdbirth;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox fullname;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Button btnempsave;
        internal System.Windows.Forms.TabControl TabControl2;
    }
}