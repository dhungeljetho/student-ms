using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

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

            delbtn.Click += delbtn_Click;

            searchD.Click += SearchD_Click;
        }

        private void SearchD_Click(object sender, EventArgs e)
        {
            String connectionString = "Server=127.0.0.1;Port=3306;User ID=root;Password=;Database=Student_ms;";
            String querry = "SELECT * FROM Student_table WHERE Student_Id = @id;";
             using (MySqlConnection conn = new MySqlConnection(connectionString)) {
                try
                {
                    conn.Open();
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
                                    sname.Text = name.ToString();
                                    school1.Text = school_name.ToString();
                                    class1.Text = classes.ToString();
                                    section1.Text = section.ToString();
                                    pname1.Text = guardian_name.ToString();
                                    pno1.Text = phone_number.ToString();
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

        //private void delbtn_Click(object sender, EventArgs e)
        //{
        //     DialogResult res =MessageBox.Show("Are you sure you want to delete this record.", "Warning", MessageBoxButtons.YesNo);
        //    if (res == DialogResult.Yes)
        //    {
        //        String connectionString = "Server=127.0.0.1;Port=3306;User ID=root;Password=;Database=Student_ms;";
        //        String querry = "DELETE FROM Student_table WHERE Student_Id = @id;";
        //        using (MySqlConnection conn = new MySqlConnection(connectionString))
        //        {
        //            try
        //            {
        //                conn.Open();

        //                using (MySqlCommand cmd = new MySqlCommand(querry, conn))
        //                {
        //                    cmd.Parameters.AddWithValue("@id", searchforD.Text);

        //                    int rowsAffected = cmd.ExecuteNonQuery();

        //                    if (rowsAffected > 0)
        //                    {
        //                        MessageBox.Show("Student Record Deleted!");
        //                        searchforD.Clear(); 
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("No student found with that ID.");
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"An error occurred: {ex.Message}");
        //            }
        //        }
        //    }
        //}

        private void delbtn_Click(object sender, EventArgs e)
        {
            // 1. Check if the box is empty first!
            if (string.IsNullOrWhiteSpace(searchforD.Text))
            {
                MessageBox.Show("Please enter an ID to delete.");
                return; 
            }

            DialogResult res = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                String connectionString = "Server=127.0.0.1;Port=3306;User ID=root;Password=;Database=Student_ms;";
                String querry = "DELETE FROM Student_table WHERE Student_Id = @id;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        

                        using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", searchforD.Text);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Student Record Deleted!");
                                searchforD.Clear();
                                s_no.Clear();
                                rollval.Clear(); 
                                sname.Clear(); ;
                                school1.Clear(); 
                                class1.Clear();
                                section1.Clear(); 
                                pname1.Clear(); 
                                pno1.Clear(); 
                                address1.Clear(); 
                            }
                            else
                            {
                                MessageBox.Show("No student found with that ID.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
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
