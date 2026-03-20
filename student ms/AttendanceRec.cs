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
            String connectionString = "Server=127.0.0.1; Port=3306; Database=Student_ms; User ID=root; password=;";
            String querry = "SELECT s.Student_Id," +
                "s.Student_Name," +
                "s.Roll_No " +
                "FROM student_table AS s" +
                " WHERE s.Class = @classes;";

            dataGridView1.AutoGenerateColumns = false;
        }

        private void Search_cl_Click(object sender, EventArgs e)
        {
            String connectionString = "Server=127.0.0.1; Port=3306; Database=Student_ms; User ID=root; password=;";
            String querry = "SELECT s.Student_Id," +
                "s.Student_Name," +
                "s.Roll_No " +
                "FROM student_table AS s" +
                " WHERE s.Class = @classes;";

            dataGridView1.AutoGenerateColumns = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
             {
                try {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(querry, connection))
                    {
                        command.Parameters.AddWithValue("@classes", claassrec.Text);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dataTable = new DataTable();
                                dataTable.Load(reader);
                                dataGridView1.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No records found for the provided class.");
                                dataGridView1.DataSource = null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return;
                }


            }
        }

       private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string studentId = row.Cells["Student_Id"].Value.ToString();
                string studentName = row.Cells["Student_Name"].Value.ToString();
                string rollNo = row.Cells["Roll_No"].Value.ToString();
                MessageBox.Show($"Student ID: {studentId}\nStudent Name: {studentName}\nRoll No: {rollNo}");
            }
        }


        private void Dabtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
                this.Close();
        }
    }
}
