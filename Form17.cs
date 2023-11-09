using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tcu300Cat1
{
    public partial class GasExpTerm : Form
    {
        public GasExpTerm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtgasform_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgasexp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtgasform.Clear();
            txtinitgasform.Clear();
            txtgasexp.Clear();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double Bg, Bgi, Eg;
            Bg = Convert.ToDouble(txtgasform.Text);
            Bgi = Convert.ToDouble(txtinitgasform.Text);
            Eg = Bg - Bgi;
            txtgasexp.Text = Eg.ToString();
        }
    }
}
