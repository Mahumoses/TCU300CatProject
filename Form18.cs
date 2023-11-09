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
    public partial class GasFormVol : Form
    {
        public GasFormVol()
        {
            InitializeComponent();
        }

        private void txtgdf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtgdf.Clear();
            txttemp.Clear();
            txtpressure.Clear();
            txtgdf.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double z, T, P, Bg;
            z = Convert.ToDouble(txtgdf.Text);  
            T = Convert.ToDouble(txttemp.Text);
            P = Convert.ToDouble(txtpressure.Text);
            Bg = (0.005035 * z * T) / P;
            txtgfvf.Text = Bg.ToString();
        }
    }
}
