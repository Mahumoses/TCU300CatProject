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
    public partial class GeothermalGrad : Form
    {
        public GeothermalGrad()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double Tbh, Ts, Dbh, Gg;
            Tbh = Convert.ToDouble(txtmaxtemp.Text);
            Ts = Convert.ToDouble(txtsurtemp.Text);     
            Dbh = Convert.ToDouble(txttotdepth.Text);  
            Gg = ((Tbh - Ts) / Dbh) * 100;
            txtgeograd.Text = Gg.ToString();
        }

        private void txtgeograd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmaxtemp.Clear();
            txtsurtemp.Clear();
            txttotdepth.Clear();
            txtgeograd.Clear();

        }
    }
}
