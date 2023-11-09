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
    public partial class CommFactor : Form
    {
        public CommFactor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double k, a, t, l, c;
            k = Convert.ToDouble(txtpermeability.Text);
            a = Convert.ToDouble(txtarea.Text);
            t = Convert.ToDouble(txttemperature.Text);
            l = Convert.ToDouble(txtlength.Text);  
            c = (0.111924 * k *a) / (t * l);
            txtcommunicationfactor.Text = c.ToString(); 

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpermeability.Clear();
            txtarea.Clear();
            txttemperature.Clear();
            txtlength.Clear();
            txtcommunicationfactor.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttemperature_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlength_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
