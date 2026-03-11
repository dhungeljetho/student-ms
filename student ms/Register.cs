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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            //this.Load += Register_Load;
        }

        //private void Register_Load(object sender, EventArgs e)
        //{
        //     Regis_btn.Click += Regis_btn_Click;

        //     loginlabel.Click += Loginlabel_Click;
        //}

        //private void Loginlabel_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Login login = new Login();
        //    login.ShowDialog();
        //    this.Close();
        //}

        //private void Regis_btn_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Dashboard dash = new Dashboard();
        //    dash.ShowDialog();
        //    this.Close();
        //}
    }
}
