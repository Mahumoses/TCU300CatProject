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
    public partial class EffWellRad : Form
    {
        public EffWellRad()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double Xf, E, Rw;
            Xf = Convert.ToDouble(txtfrac.Text);
            E = Convert.ToDouble(txtlog.Text);
            Rw = Xf / E;
            txteffrad.Text = Rw.ToString();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfrac.Clear();
            txtlog.Clear();
            txteffrad.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
