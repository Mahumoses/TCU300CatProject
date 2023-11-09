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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtgp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtg.Clear();
            txtgp.Clear();
            txtbg.Clear();
            txtefw.Clear();
            txtcdi.Clear();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double G, Gp, Bg, Efw, Cdi;
            G = Convert.ToDouble(txtg.Text);
            Gp = Convert.ToDouble(txtgp.Text);
            Bg = Convert.ToDouble(txtbg.Text);
            Efw = Convert.ToDouble(txtefw.Text);
            Cdi = (G * Efw) / (Gp * Bg);
            txtcdi.Text = Cdi.ToString();

        }
    }
}
