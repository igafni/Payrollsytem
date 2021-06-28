namespace PayrollSytem
{
    partial class frm_WorkTime
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
            this.GroupBox11 = new System.Windows.Forms.GroupBox();
            this.Label38 = new System.Windows.Forms.Label();
            this.worktimeid = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.Label41 = new System.Windows.Forms.Label();
            this.worktimefullname = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.dateTimeFullStart = new System.Windows.Forms.DateTimePicker();
            this.hourStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFullEnd = new System.Windows.Forms.DateTimePicker();
            this.hourEnd = new System.Windows.Forms.DateTimePicker();
            this.GroupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox11
            // 
            this.GroupBox11.Controls.Add(this.hourEnd);
            this.GroupBox11.Controls.Add(this.dateTimeFullEnd);
            this.GroupBox11.Controls.Add(this.hourStart);
            this.GroupBox11.Controls.Add(this.dateTimeFullStart);
            this.GroupBox11.Controls.Add(this.Label38);
            this.GroupBox11.Controls.Add(this.worktimeid);
            this.GroupBox11.Controls.Add(this.end);
            this.GroupBox11.Controls.Add(this.start);
            this.GroupBox11.Controls.Add(this.Label41);
            this.GroupBox11.Controls.Add(this.worktimefullname);
            this.GroupBox11.Controls.Add(this.btnsave);
            this.GroupBox11.Controls.Add(this.lbl_id);
            this.GroupBox11.Location = new System.Drawing.Point(83, 23);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox11.Size = new System.Drawing.Size(483, 199);
            this.GroupBox11.TabIndex = 7;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "הוסף שעות עבודה לעובד";
            // 
            // Label38
            // 
            this.Label38.AutoSize = true;
            this.Label38.BackColor = System.Drawing.Color.Transparent;
            this.Label38.ForeColor = System.Drawing.Color.Black;
            this.Label38.Location = new System.Drawing.Point(400, 37);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(67, 13);
            this.Label38.TabIndex = 14;
            this.Label38.Text = "תעודת זהות";
            this.Label38.Click += new System.EventHandler(this.Label38_Click);
            // 
            // worktimeid
            // 
            this.worktimeid.Location = new System.Drawing.Point(94, 34);
            this.worktimeid.Name = "worktimeid";
            this.worktimeid.Size = new System.Drawing.Size(285, 20);
            this.worktimeid.TabIndex = 13;
            this.worktimeid.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.BackColor = System.Drawing.Color.Transparent;
            this.end.ForeColor = System.Drawing.Color.Black;
            this.end.Location = new System.Drawing.Point(410, 126);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(57, 13);
            this.end.TabIndex = 6;
            this.end.Text = "שעת סיום";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.ForeColor = System.Drawing.Color.Black;
            this.start.Location = new System.Drawing.Point(399, 94);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(68, 13);
            this.start.TabIndex = 4;
            this.start.Text = "שעת התחלה";
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.BackColor = System.Drawing.Color.Transparent;
            this.Label41.ForeColor = System.Drawing.Color.Black;
            this.Label41.Location = new System.Drawing.Point(416, 67);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(51, 13);
            this.Label41.TabIndex = 5;
            this.Label41.Text = "שם מלא ";
            // 
            // worktimefullname
            // 
            this.worktimefullname.Location = new System.Drawing.Point(94, 60);
            this.worktimefullname.Name = "worktimefullname";
            this.worktimefullname.Size = new System.Drawing.Size(285, 20);
            this.worktimefullname.TabIndex = 1;
            this.worktimefullname.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(219, 155);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(97, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "הוסף שעות עבודה";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(269, 63);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(15, 13);
            this.lbl_id.TabIndex = 12;
            this.lbl_id.Text = "id";
            // 
            // dateTimeFullStart
            // 
            this.dateTimeFullStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFullStart.Location = new System.Drawing.Point(94, 94);
            this.dateTimeFullStart.Name = "dateTimeFullStart";
            this.dateTimeFullStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFullStart.TabIndex = 16;
            this.dateTimeFullStart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // hourStart
            // 
            this.hourStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hourStart.Location = new System.Drawing.Point(300, 94);
            this.hourStart.Name = "hourStart";
            this.hourStart.ShowUpDown = true;
            this.hourStart.Size = new System.Drawing.Size(79, 20);
            this.hourStart.TabIndex = 17;
            this.hourStart.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimeFullEnd
            // 
            this.dateTimeFullEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFullEnd.Location = new System.Drawing.Point(94, 120);
            this.dateTimeFullEnd.Name = "dateTimeFullEnd";
            this.dateTimeFullEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFullEnd.TabIndex = 18;
            // 
            // hourEnd
            // 
            this.hourEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hourEnd.Location = new System.Drawing.Point(300, 119);
            this.hourEnd.Name = "hourEnd";
            this.hourEnd.ShowUpDown = true;
            this.hourEnd.Size = new System.Drawing.Size(79, 20);
            this.hourEnd.TabIndex = 19;
            // 
            // frm_WorkTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 443);
            this.Controls.Add(this.GroupBox11);
            this.Name = "frm_WorkTime";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddWorkTime";
            this.Load += new System.EventHandler(this.btnempnew_Click);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox11;
        internal System.Windows.Forms.Label Label38;
        internal System.Windows.Forms.TextBox worktimeid;
        internal System.Windows.Forms.Label Label41;
        internal System.Windows.Forms.TextBox worktimefullname;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.Label lbl_id;
        internal System.Windows.Forms.Label start;
        internal System.Windows.Forms.Label end;
        private System.Windows.Forms.DateTimePicker hourStart;
        private System.Windows.Forms.DateTimePicker dateTimeFullStart;
        private System.Windows.Forms.DateTimePicker hourEnd;
        private System.Windows.Forms.DateTimePicker dateTimeFullEnd;
    }
}