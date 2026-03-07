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

            this.Load += Deleterec_Load;
        }

        private void Deleterec_Load(object sender, EventArgs e)
        {
            Dabtn.Click += Dash_btn_Click;

            Viewbtn.Click += Viewbtn_Click;
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
