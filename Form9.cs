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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double G, Eg, Wi, F;
            G = Convert.ToDouble(txtgip.Text);
            Eg = Convert.ToDouble(txtget.Text);
            Wi = Convert.ToDouble(txtwaterinflux.Text);
            F = (G * Eg) + Wi;
            txtuww.Text = F.ToString();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtgip.Clear();
            txtwaterinflux.Clear();
            txtget.Clear();
            txtuww.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtgip_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
