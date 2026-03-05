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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    btn.MouseEnter += Button_MouseEnter;
                    btn.MouseLeave += Button_MouseLeave;
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.SteelBlue;
            btn.ForeColor = Color.White;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.Control;
            btn.ForeColor = Color.Black;
        }


        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            var login1 = new Form1();
            this.Hide();
            login1.ShowDialog();
            this.Show();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            var newrec = new AddStudent();
            this.Hide();
            newrec.ShowDialog();
            this.Show();
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            var view = new Viewrec();
            this.Hide();
            view.ShowDialog();
            this.Show();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            var update = new Updaterecord();
            this.Hide();
            update.ShowDialog();
            this.Show();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var delete = new Deleterec();
            this.Hide();
            delete.ShowDialog();
            this.Show();
        }
    }
}
