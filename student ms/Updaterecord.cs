using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace student_ms
{
    public partial class Updaterecord : Form
    {
        public Updaterecord()
        {
            InitializeComponent();


            this.Load += Updaterecord_Load;


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

        private void Updaterecord_Load(object sender, EventArgs e)
        {
            Dabtn.Click += Dabtn_Click;

            view_btn.Click += View_btn_Click;

            //Reset_btn.Click += Reset_btn_Click;

            Update_btn.Click += Update_btn_Click;

            searchU.Click += SearchU_btn_Click;
        }

        private void SearchU_btn_Click(object sender, EventArgs e)
        {
           
            String connectionString = "Server=127.0.0.1;Port=3306;User ID=root;Password=;Database=Student_ms;";
            String querry = "SELECT * FROM Student_table WHERE Student_Id = @id;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", SearchforU.Text);
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
                                    s_name.Text = name.ToString();
                                    sc_name.Text = school_name.ToString();
                                    classes0.Text = classes.ToString();
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

        private void Update_btn_Click(object sender, EventArgs e)
        {
            string selectedGender = rbMale.Checked ? "Male" : "Female";

            String connectionString = "Server=127.0.0.1;Port=3306;User ID=root;Password=;Database=Student_ms;";

            String querry = "UPDATE Student_table SET " +
                "Roll_No = @rollno," +
                "Student_Name = @studentName," +
                "Class = @class," +
                "Section = @section," +
                "School_Name = @schoolName," +
                "Guardian_Name = @guardianName," +
                "Phone_Number = @phoneNumber," +
                "Gender = @gender," +
                "Address = @address1" +
                " WHERE Student_Id = @id ";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", SearchforU.Text);
                        cmd.Parameters.AddWithValue("@rollno", rollval.Text);
                        cmd.Parameters.AddWithValue("@studentName", s_name.Text);
                        cmd.Parameters.AddWithValue("@class", classes0.Text);
                        cmd.Parameters.AddWithValue("@section", sec.Text);
                        cmd.Parameters.AddWithValue("@schoolName", sc_name.Text);
                        cmd.Parameters.AddWithValue("@guardianName", p_name.Text);
                        cmd.Parameters.AddWithValue("@phoneNumber", p_no.Text);
                        cmd.Parameters.AddWithValue("@gender", selectedGender);
                        cmd.Parameters.AddWithValue("@address1", address1.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student updated successfully!");

                            s_no.Clear();
                            rollval.Clear();
                            s_name.Clear();
                            classes0.Clear();
                            sec.Clear();
                            sc_name.Clear();
                            p_name.Clear();
                            rbFemale.Checked = true;
                            p_no.Clear();
                            address1.Clear();
                            SearchforU.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No record found with that ID. Update failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void Dabtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void View_btn_Click(object sender, EventArgs e)
        {
            var viewForm = new Viewrec();
            viewForm.Owner = this.Owner;
            viewForm.Show();
            this.Close();
        }
    }
}
