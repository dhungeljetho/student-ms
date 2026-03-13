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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();

            this.Load += Payment_Load;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            Dabtn.Click += Dabtn_Click;

            SearchP.Click += SearchP_Click;

            paidbtn.Click += Paidbtn_Click;

            SearchforP.Click += SearchforP_Click;
        }

        private void Dabtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void ClearAllFields()
        {
            SearchforP.Clear();
            s_no.Clear();
            s_name.Clear();
            classes.Clear();
            p_name.Clear();
        }

        private void SearchforP_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void SearchP_Click(object sender, EventArgs e)
        {
            string searchValue = SearchforP.Text;
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a value to search.");
                return;
            }

            String connectionString = "Server=127.0.0.1;Port=3306;User ID=root;Password=;Database=Student_ms;";
            String query = "SELECT s.Student_Id," +
                "s.Class," +
                "s.Student_Name," +
                "s.Guardian_Name" +
                " From student_table As s " +
                "WHERE Student_Id =@id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", SearchforP.Text);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string studentId = reader["Student_Id"].ToString();
                                string studentName = reader["Student_Name"].ToString();
                                string guardianName = reader["Guardian_Name"].ToString();
                                string studentClass = reader["Class"].ToString();
                                s_no.Text = studentId;
                                s_name.Text = studentName;
                                p_name.Text = guardianName;
                                classes.Text = studentClass;
                            }
                            else
                            {
                                MessageBox.Show("No record found for the provided Student ID.");
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("An error occurred while connecting to the database. Please check your connection settings and try again.");
                }
            }

        }

        private void Paidbtn_Click(object sender, EventArgs e)
        {
            String connectionString = "Server=127.0.0.1; Port=3306;User ID=root;Password=;Database=Student_ms;";
            String query = "INSERT INTO payment_table (" +
                "Student_id," +
                "Amount," +
                "Payment_Month," +
                "Date_Paid," +
                "Payment_Method)" +
                " VALUES (@id,  @amount, @month, @datepaid, @method);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", s_no.Text);
                        command.Parameters.AddWithValue("@amount", Amount.Text);
                        command.Parameters.AddWithValue("@month", month.Text);
                        command.Parameters.AddWithValue("@datepaid", transdate.Value);
                        command.Parameters.AddWithValue("@method", paymet.Text);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment recorded successfully.");
                            ClearAllFields();
                            SearchforP.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Failed to record payment. Please try again.");
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("An error occurred while connecting to the database. Please check your connection settings and try again.");
                }
            }
        }
    }
}
