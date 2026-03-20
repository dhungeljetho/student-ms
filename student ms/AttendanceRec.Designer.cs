namespace student_ms
{
    partial class AttendanceRec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Attenbtn = new System.Windows.Forms.Button();
            this.Dabtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveAtt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.claassrec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transdate = new System.Windows.Forms.DateTimePicker();
            this.Search_cl = new System.Windows.Forms.Button();
            this.Student_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.viewa = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Attenbtn
            // 
            this.Attenbtn.BackColor = System.Drawing.Color.Azure;
            this.Attenbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attenbtn.Location = new System.Drawing.Point(28, 223);
            this.Attenbtn.Name = "Attenbtn";
            this.Attenbtn.Size = new System.Drawing.Size(123, 35);
            this.Attenbtn.TabIndex = 63;
            this.Attenbtn.Text = "Attendance";
            this.Attenbtn.UseVisualStyleBackColor = false;
            // 
            // Dabtn
            // 
            this.Dabtn.BackColor = System.Drawing.Color.Azure;
            this.Dabtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dabtn.Location = new System.Drawing.Point(28, 182);
            this.Dabtn.Name = "Dabtn";
            this.Dabtn.Size = new System.Drawing.Size(123, 35);
            this.Dabtn.TabIndex = 62;
            this.Dabtn.Text = "Dashboard";
            this.Dabtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_No,
            this.Roll_No,
            this.Student_Name,
            this.Attend,
            this.viewa});
            this.dataGridView1.Location = new System.Drawing.Point(198, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(590, 326);
            this.dataGridView1.TabIndex = 64;
            // 
            // saveAtt
            // 
            this.saveAtt.BackColor = System.Drawing.Color.Azure;
            this.saveAtt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAtt.Location = new System.Drawing.Point(654, 467);
            this.saveAtt.Name = "saveAtt";
            this.saveAtt.Size = new System.Drawing.Size(123, 35);
            this.saveAtt.TabIndex = 65;
            this.saveAtt.Text = "Save";
            this.saveAtt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "Date:";
            // 
            // claassrec
            // 
            this.claassrec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claassrec.Location = new System.Drawing.Point(512, 78);
            this.claassrec.Name = "claassrec";
            this.claassrec.Size = new System.Drawing.Size(132, 29);
            this.claassrec.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.TabIndex = 69;
            this.label3.Text = "Attendance Record";
            // 
            // transdate
            // 
            this.transdate.CustomFormat = "yyyy-MMM-dd";
            this.transdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.transdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.transdate.Location = new System.Drawing.Point(240, 81);
            this.transdate.Name = "transdate";
            this.transdate.Size = new System.Drawing.Size(165, 29);
            this.transdate.TabIndex = 70;
            // 
            // Search_cl
            // 
            this.Search_cl.BackColor = System.Drawing.Color.Blue;
            this.Search_cl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_cl.Location = new System.Drawing.Point(645, 79);
            this.Search_cl.Name = "Search_cl";
            this.Search_cl.Size = new System.Drawing.Size(90, 28);
            this.Search_cl.TabIndex = 71;
            this.Search_cl.Text = "Search Class";
            this.Search_cl.UseVisualStyleBackColor = false;
            // 
            // Student_No
            // 
            this.Student_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Student_No.DataPropertyName = "Student_Id";
            this.Student_No.HeaderText = "Student No.";
            this.Student_No.Name = "Student_No";
            this.Student_No.ReadOnly = true;
            this.Student_No.Width = 89;
            // 
            // Roll_No
            // 
            this.Roll_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Roll_No.DataPropertyName = "Roll_No";
            this.Roll_No.HeaderText = "Roll No.";
            this.Roll_No.MinimumWidth = 80;
            this.Roll_No.Name = "Roll_No";
            this.Roll_No.ReadOnly = true;
            this.Roll_No.Width = 80;
            // 
            // Student_Name
            // 
            this.Student_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student_Name.DataPropertyName = "Student_Name";
            this.Student_Name.FillWeight = 221.0526F;
            this.Student_Name.HeaderText = "Student Name";
            this.Student_Name.MinimumWidth = 150;
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.ReadOnly = true;
            // 
            // Attend
            // 
            this.Attend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Attend.FillWeight = 39.47369F;
            this.Attend.HeaderText = "Present";
            this.Attend.Name = "Attend";
            // 
            // viewa
            // 
            this.viewa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumBlue;
            this.viewa.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewa.FillWeight = 39.47369F;
            this.viewa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewa.HeaderText = "View";
            this.viewa.MinimumWidth = 60;
            this.viewa.Name = "viewa";
            this.viewa.Text = "View";
            this.viewa.UseColumnTextForButtonValue = true;
            // 
            // AttendanceRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.Search_cl);
            this.Controls.Add(this.transdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.claassrec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveAtt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Attenbtn);
            this.Controls.Add(this.Dabtn);
            this.Name = "AttendanceRec";
            this.Text = "AttendanceRec";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Attenbtn;
        private System.Windows.Forms.Button Dabtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveAtt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox claassrec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker transdate;
        private System.Windows.Forms.Button Search_cl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Attend;
        private System.Windows.Forms.DataGridViewButtonColumn viewa;
    }
}