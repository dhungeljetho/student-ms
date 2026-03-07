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
    public partial class Updaterecord : Form
    {
        public Updaterecord()
        {
            InitializeComponent();


            this.Load += Updaterecord_Load;
        }

        private void Updaterecord_Load(object sender, EventArgs e)
        {
            Dabtn.Click += Dabtn_Click;
            view_btn.Click += View_btn_Click;
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
