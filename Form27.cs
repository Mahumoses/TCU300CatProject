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
    public partial class MatBal : Form
    {
        public MatBal()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double G, Eg, We, F;
            G = Convert.ToDouble(txtgasplace.Text);
            Eg = Convert.ToDouble(txtexpgas.Text);
            We = Convert.ToDouble(txtcumwater.Text);
            F = G * Eg + We;
            txtfluid.Text = F.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtgasplace.Clear();
            txtexpgas.Clear();
            txtcumwater.Clear();
            txtfluid.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
