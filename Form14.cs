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
    public partial class DimRad : Form
    {
        public DimRad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r, rw, rd;
            r = Convert.ToDouble(txteffrad.Text);
            rw = Convert.ToDouble(txtwbrad.Text);
            rd = r / rw;
            txtdimrad.Text = rd.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txteffrad.Clear();
            txtwbrad.Clear();
            txtdimrad.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
