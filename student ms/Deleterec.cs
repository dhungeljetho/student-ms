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
    public partial class Deleterec : Form
    {
        public Deleterec()
        {
            InitializeComponent();

            this.Load += Deleterec_Load;
        }

        private void Deleterec_Load(object sender, EventArgs e)
        {
            Dabtn.Click += Dash_btn_Click;

            Viewbtn.Click += Viewbtn_Click;

            Deletebtn.Click += Deletebtn_Click;

            searchD.Click += SearchD_Click;
        }

        private void SearchD_Click(object sender, EventArgs e)
        {
            String connectionString = "Server=127.0.0.1;Port=3306;User ID=root;Password=;Database=Student_ms;";
            String querry = "SELECT * FROM Student_table WHERE ID = @id;";
             using (MySqlConnection conn = new MySqlConnection(connectionString)) {
                try
                {
                    conn.Open();
                     MessageBox.Show("connection successful");
                    using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", searchforD.Text);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Assuming you have columns named "Name" and "Age" in your Student_table
                                    string name = reader["Name"].ToString();
                                    string age = reader["Age"].ToString();
                                    // Display the retrieved data in a message box or any other control
                                    MessageBox.Show($"Name: {name}, Age: {age}");
                                }
                            } 
                            else
                            {
                                MessageBox.Show("No record found with the provided ID.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            //Deletebtn.
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
           var viewForm = new Viewrec();
            viewForm.Owner = this.Owner;
            viewForm.Show();
            this.Close();
        }

        private void Dash_btn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        
    }
}
