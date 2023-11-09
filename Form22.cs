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
    public partial class HydroPressure : Form
    {
        public HydroPressure()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double mw, Tvd, Hp;
            mw = Convert.ToDouble(txtmudweight.Text);
            Tvd = Convert.ToDouble(txttvd.Text);
            Hp = mw * 0.052 * Tvd;
            txthp.Text = Hp.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmudweight.Clear();
            txttvd.Clear();
            txthp.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
