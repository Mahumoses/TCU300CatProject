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
    public partial class InterVel : Form
    {
        public InterVel()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double q, Q, A, V;
            q = Convert.ToDouble(txtflowrate.Text);
            Q = Convert.ToDouble(txtporosity.Text);
            A = Convert.ToDouble(txtarea.Text);
            V = q / (Q * A);
            txtvelocity.Text = V.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtflowrate.Clear();
            txtporosity.Clear();    
            txtarea.Clear();
            txtvelocity.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
