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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attenbtn = new System.Windows.Forms.Button();
            this.Dabtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attendance});
            this.dataGridView1.Location = new System.Drawing.Point(208, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // Attendance
            // 
            this.Attendance.HeaderText = "Attendance";
            this.Attendance.Name = "Attendance";
            this.Attendance.ReadOnly = true;
            // 
            // Attenbtn
            // 
            this.Attenbtn.BackColor = System.Drawing.Color.Azure;
            this.Attenbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attenbtn.Location = new System.Drawing.Point(23, 175);
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
            this.Dabtn.Location = new System.Drawing.Point(23, 134);
            this.Dabtn.Name = "Dabtn";
            this.Dabtn.Size = new System.Drawing.Size(123, 35);
            this.Dabtn.TabIndex = 62;
            this.Dabtn.Text = "Dashboard";
            this.Dabtn.UseVisualStyleBackColor = false;
            // 
            // AttendanceRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Attenbtn);
            this.Controls.Add(this.Dabtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AttendanceRec";
            this.Text = "AttendanceRec";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance;
        private System.Windows.Forms.Button Attenbtn;
        private System.Windows.Forms.Button Dabtn;
    }
}