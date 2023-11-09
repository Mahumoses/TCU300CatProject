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
    public partial class InitGasCp : Form
    {
        public InitGasCp()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtratio.Clear();
            txtoriginal.Clear();
            txtvolform.Clear();
            txtgasform.Clear();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double m, N, Boi, Bgi, G;
            m = Convert.ToDouble(txtratio.Text);
            N = Convert.ToDouble(txtoriginal.Text);
            Boi = Convert.ToDouble(txtvolform.Text);
            Bgi = Convert.ToDouble(txtgasform.Text);
            G = (m * N * Boi) / Bgi;
            txtgascap.Text = G.ToString();


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
