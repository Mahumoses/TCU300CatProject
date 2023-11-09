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
    public partial class CompDrive : Form
    {
        public CompDrive()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtci_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double G, Gp, Bg, Ef, CI;
            G = Convert.ToDouble(txtg.Text);
            Gp = Convert.ToDouble(txtgp.Text);
            Bg = Convert.ToDouble(txtbg.Text);
            Ef = Convert.ToDouble(txtef.Text);
            CI = (G * Ef) / (Bg * Gp);
            txtci.Text = CI.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtg.Clear();
            txtgp.Clear();
            txtbg.Clear();
            txtef.Clear();
            txtci.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
