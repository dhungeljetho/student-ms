using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_ms
{
    public partial class Viewrec : Form
    {
        public Viewrec()
        {
            InitializeComponent();

            this.Load += Viewrec_Load;


            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    //btn.MouseEnter += Button_MouseEnter;
                    //btn.MouseLeave += Button_MouseLeave;
                }
            }
        }

        private void Viewrec_Load(object sender, EventArgs e)
        {
            Dabtn.Click += Dabtn_Click;

            SearchV.Click += SearchV_Click;

            SearchforV.Click += SearchforV_Click;
        }

        private void SearchforV_Click(object sender, EventArgs e)
        {
           ClearAllFields();
        }

        private void ClearAllFields()
        {
            SearchforV.Clear();
            s_no.Clear();
            s_name.Clear();
            rollval.Clear();
            classes1.Clear();
            sec.Clear();
            sc_name.Clear();
            p_name.Clear();
            p_no.Clear();
            address1.Clear();
            rbFemale.Checked = false;
            rbMale.Checked = false;
        }
        private void SearchV_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(SearchforV.Text))
            {
                MessageBox.Show("Please enter a Student ID to search.");
                return;
            }

            String connectionString = "Server=127.0.0.1;Port=3306;User ID=root;Password=;Database=Student_ms;";
            String querry = "SELECT * FROM Student_table WHERE Student_Id = @id;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", SearchforV.Text);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int studentId = Convert.ToInt32(reader["Student_Id"]);
                                    int rollno = Convert.ToInt32(reader["Roll_No"]);
                                    string name = reader["Student_Name"].ToString();
                                    string gender = reader["Gender"].ToString();
                                    string school_name = reader["School_Name"].ToString();
                                    int classes = Convert.ToInt32(reader["Class"]);
                                    string section = reader["Section"].ToString();
                                    string guardian_name = reader["Guardian_Name"].ToString();
                                    string phone_number = reader["Phone_Number"].ToString();
                                    string address = reader["Address"].ToString();

                                    // Display the retrieved data in a text box

                                    s_no.Text = studentId.ToString();
                                    rollval.Text = rollno.ToString();
                                    s_name.Text = name.ToString();
                                    sc_name.Text = school_name.ToString();
                                    classes1.Text = classes.ToString();
                                    sec.Text = section.ToString();
                                    p_name.Text = guardian_name.ToString();
                                    p_no.Text = phone_number.ToString();
                                    address1.Text = address.ToString();

                                    //for gender issue to check in radio button

                                    if (gender == "Male")
                                    {
                                        rbMale.Checked = true;
                                    }
                                    else if (gender == "Female")
                                    {
                                        rbFemale.Checked = true;
                                    }

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

        private void Dabtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
