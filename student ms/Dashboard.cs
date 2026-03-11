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

            this.Load += Dashboard_Load;
            //foreach (Control ctrl in this.Controls)
            //{
            //    if (ctrl is Button btn)
            //    {
            //        btn.FlatStyle = FlatStyle.Flat;
            //        btn.FlatAppearance.BorderSize = 0;

            //        btn.MouseEnter += Button_MouseEnter;
            //        btn.MouseLeave += Button_MouseLeave;
            //    }
            //}
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Addbtn.Click += Addbtn_Click;

            Logoutbtn.Click += Logoutbtn_Click;

            Viewbtn.Click += Viewbtn_Click; ;

            Updatebtn.Click += Updatebtn_Click;

            Deletebtn.Click += Deletebtn_Click;

            Attenbtn.Click += Attenbtn_Click;

            Paymentbtn.Click += Payment_btn_Click;

        }

        private void Payment_btn_Click(object sender, EventArgs e)
        {
            var payment = new Payment();
            payment.Owner = this;
            this.Hide();
            payment.ShowDialog();
            this.Show();
        }

        private void Attenbtn_Click(object sender, EventArgs e)
        {
            var attend = new AttendanceRec();
            attend.Owner = this;
            this.Hide();
            attend.ShowDialog();
            this.Show();
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            var view = new Viewrec();
            view.Owner = this;
            this.Hide();
            view.ShowDialog();
            this.Show();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            var add = new AddStudent();
            add.Owner = this;
            this.Hide();
            add.ShowDialog();
            this.Show();

        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show(); 
                this.Close();      
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var del = new Deleterec();
            del.Owner = this;
            this.Hide();
            del.ShowDialog();
            this.Show();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            var update = new Updaterecord();
            update.Owner = this;
            this.Hide();
            update.ShowDialog();
            this.Show();
        }


    }
}
