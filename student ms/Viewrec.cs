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
    public partial class Viewrec : Form
    {
        public Viewrec()
        {
            InitializeComponent();

            this.Load += Viewrec_Load;
        }

        private void Viewrec_Load(object sender, EventArgs e)
        {
            Dabtn.Click += Dabtn_Click;
        }

        private void Dabtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
