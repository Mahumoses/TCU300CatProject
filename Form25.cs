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
    public partial class InjecIndex : Form
    {
        public InjecIndex()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double q, p, Pwf, I;
            q = Convert.ToDouble(txtflowrate.Text);
            p = Convert.ToDouble(txtrpressure.Text);
            Pwf = Convert.ToDouble(txtwfpressure.Text);
            I = q / (Pwf - q);
            txtinjectivity.Text = I.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtflowrate.Clear();
            txtrpressure.Clear();
            txtwfpressure.Clear();
            txtinjectivity.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
