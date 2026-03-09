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
    public partial class AddStudent : Form
    {

        public AddStudent()
        {
            InitializeComponent();

            this.Load += AddStudent_Load;

           // mouse movement
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

        //private void Button_MouseEnter(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    btn.BackColor = Color.SteelBlue;
        //    btn.ForeColor = Color.White;
        //}

        //private void Button_MouseLeave(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    btn.BackColor = SystemColors.Control;
        //    btn.ForeColor = Color.Black;
        //}

        private void AddStudent_Load(object sender, EventArgs e)
        {
            rbFemale.Checked = true;

            Dash_btn.Click += Dash_btn_Click;

            Save_btn.Click += Save_btn_Click;

            Delete_btn.Click += Delete_btn_Click;

            Update_btn.Click += Update_btn_Click;

            View_btn.Click += View_btn_Click;

            Reset_btn.Click += Reset_btn_Click;
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            roll.Clear();
            name.Clear();
            class0.Clear();
            section0.Clear();
            school.Clear();
            pname.Clear();
            rbFemale.Checked = true;
            pno.Clear();
            address.Clear();
        }
        private void View_btn_Click(object sender, EventArgs e)
        {
            var viewStudent = new Viewrec();
            viewStudent.ShowDialog();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            var updateStudent = new Updaterecord();
            updateStudent.ShowDialog();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            Deleterec deleterec = new Deleterec();
            deleterec.ShowDialog();
        }

        private void Dash_btn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        //Whole code related to Database connection and setup
        //Database connection

        private void Save_btn_Click(object sender, EventArgs e)
        {
            //for radio button
            string selectedGender= rbFemale.Checked?"Female":"Male";


            String connectionString = "Server=127.0.0.1;Port=3306;User ID=root;Password=;Database=Student_ms;";
            String querry = "INSERT INTO  Student_table (" +
                "Roll_No ," +
                "Student_Name," +
                "Class," +
                "Section," +
                "School_Name," +
                "Guardian_Name," +
                "Phone_Number ," +
                "Gender," +
                "Address ) " +

                "VALUES (" +
                "@rollNo ," +
                "@studentName," +
                "@class," +
                "@section," +
                "@schoolName," +
                "@guardianName," +
                "@phoneNumber ," +
                "@gender," +
                "@address );";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                    {
                        cmd.Parameters.AddWithValue("@rollNo", roll.Text);
                        cmd.Parameters.AddWithValue("@studentName", name.Text);
                        cmd.Parameters.AddWithValue("@class", class0.Text);
                        cmd.Parameters.AddWithValue("@section", section0.Text);
                        cmd.Parameters.AddWithValue("@schoolName", school.Text);
                        cmd.Parameters.AddWithValue("@guardianName", pname.Text);
                        cmd.Parameters.AddWithValue("@phoneNumber", pno.Text);
                        cmd.Parameters.AddWithValue("@gender", selectedGender);
                        cmd.Parameters.AddWithValue("@address", address.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student added successfully!");
                            // Clear input fields after successful insertion
                            roll.Clear();
                            name.Clear();
                            class0.Clear();
                            section0.Clear();
                            school.Clear();
                            pname.Clear();
                            rbFemale.Checked = true;
                            pno.Clear();
                            address.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add student. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }


        }
    }
}