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

            //Viewbtn.Click += Viewbtn_Click;

            //Updatebtn.Click += Updatebtn_Click;

            //Deletebtn.Click += Deletebtn_Click;

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            var add = new AddStudent();
            add.Owner = this;
            this.Hide();
            add.ShowDialog();
            
        }

       

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

    }
}
