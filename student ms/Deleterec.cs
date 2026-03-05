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
    public partial class Deleterec : Form
    {
        public Deleterec()
        {
            InitializeComponent();
        }

        private void Dabtn_Click(object sender, EventArgs e)
        {
            var dash = new Dashboard();
            this.Hide();
            dash.ShowDialog();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            var newrec = new AddStudent();
            this.Hide();
            newrec.ShowDialog();
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            var view = new Viewrec();
            this.Hide();
            view.ShowDialog();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            var update = new Updaterecord();
            this.Hide();
            update.ShowDialog();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            var login1 = new Form1();
            this.Hide();
            login1.ShowDialog();
        }
    }
}
