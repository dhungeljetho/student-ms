using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace student_ms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginbtn.Click += Loginbtn_Click;
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {

            String connectionString = "Server=127.0.0.1;Port=3306;User ID=root;Password=;Database=Student_ms;";
            //String querry = "SELECT * FROM Login_table WHERE (Username ==@Username && Password == @Password);";

            using (MySqlConnection conn = new MySqlConnection(connectionString)) {
                try
                {
                    conn.Open();
                    MessageBox.Show("connection successful");
                    Dashboard dash = new Dashboard();
                    dash.Owner = this;
                    dash.Show();
                    this.Hide();

                } catch (Exception ex) {
                    MessageBox.Show("connection failed:" + ex.Message);
                }
            }
        } 

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}


