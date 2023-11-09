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
    public partial class HydroPoreVol : Form
    {
        public HydroPoreVol()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double N, Np, Bo, Vro;
            N = Convert.ToDouble(txtoilplace.Text);
            Np = Convert.ToDouble(txtcumoil.Text);
            Bo = Convert.ToDouble(txtoilform.Text);
            Vro = (N - Np) * Bo;
            txtvolume.Text = Vro.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtoilplace.Clear();
            txtcumoil.Clear();
            txtoilform.Clear();
            txtvolume.Clear();
        }
    }
}
