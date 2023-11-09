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
    public partial class ModColePlot : Form
    {
        public ModColePlot()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtgasplace.Clear();
            txtcumwater.Clear();
            txtexpgas.Clear();
            txtfluid.Clear();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double G,We,Et,F;
            G = Convert.ToDouble(txtgasplace.Text);
            We = Convert.ToDouble(txtcumwater.Text);
            Et = Convert.ToDouble(txtexpgas.Text);
            F = G + (We / Et);
            txtfluid.Text = F.ToString();
        }
    }
}
