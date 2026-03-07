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
             Dashboard dash = new Dashboard();
             dash.Owner= this;
            dash.Show();
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}


