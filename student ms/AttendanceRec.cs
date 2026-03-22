using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace student_ms
{
    public partial class AttendanceRec : Form
    {
        public AttendanceRec()
        {
            InitializeComponent();

            this.Load += AttendanceRec_Load;
        }

        private void AttendanceRec_Load(object sender, EventArgs e)
        {
            Dabtn.Click += Dabtn_Click;
            Search_cl.Click += Search_cl_Click;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            saveAtt.Click += SaveAtt_Click;
        }
        private void SaveAtt_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1; Port=3306; Database=Student_ms; User ID=root; password=;";

            // 1. Get the values from your TEXTBOXES above the grid
            string dateValue = todate.Text;      // Your yyyy-MM-dd textbox
            string classValue = claassrec.Text;   // Your Class textbox

            string query = @"INSERT INTO Attendance_table (StudentId, St_Class, Attendance_Date, Status) 
                     VALUES (@Id, @stclass, @todate, @status) 
                     ON DUPLICATE KEY UPDATE Status = @status";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (!DateTime.TryParse(todate.Text, out _))
                    {
                        MessageBox.Show("Please enter a valid date in yyyy-MM-dd format.");
                        return;
                    }
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Pre-define parameters outside the loop for speed
                        command.Parameters.Add("@Id", MySqlDbType.Int32);
                        command.Parameters.Add("@stclass", MySqlDbType.Int32);
                        command.Parameters.Add("@todate", MySqlDbType.Date);
                        command.Parameters.Add("@status", MySqlDbType.VarChar);

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;

                            // 2. CHECK THE GRID NAMES:
                            // Ensure the (Name) property of your columns matches these strings
                            if (row.Cells["Student_Id"].Value == null) continue;

                            // A. ID and STATUS come from the Grid
                            command.Parameters["@Id"].Value = row.Cells["Student_Id"].Value;
                            command.Parameters["@status"].Value = row.Cells["Status"].Value ?? "Absent";

                            // B. CLASS and DATE come from your Textboxes (Shared for every row)
                            command.Parameters["@stclass"].Value = classValue;
                            command.Parameters["@todate"].Value = dateValue; // Directly use the string since it's yyyy-MM-dd

                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show($"Attendance for Class {classValue} on {dateValue} saved!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save Error: " + ex.Message);
                }
            }
        }
        private void Search_cl_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1; Port=3306; Database=Student_ms; User ID=root; password=;";

            // We use YOUR working column names: s.Student_Id
            string query = @"SELECT 
                        s.Student_Id, 
                        s.Student_Name, 
                        s.Roll_No, 
                        @targetDate AS Attendance_Date,
                        IFNULL(a.Status, 'Pending') AS Status
                     FROM student_table AS s
                     LEFT JOIN Attendance_table AS a 
                        ON s.Student_Id = a.StudentId 
                        AND a.Attendance_Date = @targetDate
                     WHERE s.Class = @classes";

            dataGridView1.AutoGenerateColumns = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@classes", claassrec.Text);

                        // We add the date back so we only see TODAY'S attendance status
                        string today = DateTime.Now.ToString("yyyy-MM-dd");
                        command.Parameters.AddWithValue("@targetDate", today);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid row and specifically on the 'viewa' button column
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "viewa")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Safety check to prevent crashes if cells are empty
                string id = row.Cells["Student_Id"].Value?.ToString() ?? "N/A";
                string name = row.Cells["Student_Name"].Value?.ToString() ?? "N/A";
                string roll = row.Cells["Roll_No"].Value?.ToString() ?? "N/A";
                string status = row.Cells["Status"].Value?.ToString() ?? "Pending";

                MessageBox.Show($"[STUDENT INFO]\nID: {id}\nName: {name}\nRoll No: {roll}\nToday's Status: {status}");
            }
        }


        private void Dabtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
                this.Close();
        }
    }
}
