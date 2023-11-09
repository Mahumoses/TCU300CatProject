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
    public partial class FormTemp : Form
    {
        public FormTemp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double Ts, D, Gg, Tf;
            Ts = Convert.ToDouble(txtsurtemp.Text);
            D = Convert.ToDouble(txttotdepth.Text);
            Gg = Convert.ToDouble(txtgeograd.Text);
            Tf = Ts + Gg * (D / 100);
            txtformtemp.Text = Tf.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtsurtemp.Clear();
            txttotdepth.Clear();
            txtgeograd.Clear();
            txtformtemp.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
