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
    public partial class IneffectivePorosity : Form
    {
        public IneffectivePorosity()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double Vdis, Vb, Qin;
            Vdis = Convert.ToDouble(txtdis.Text);
            Vb = Convert.ToDouble(txtbvol.Text);
            Qin = Vdis / Vb;
            txtinp.Text = Qin.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdis.Clear();
            txtbvol.Clear();
            txtinp.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
