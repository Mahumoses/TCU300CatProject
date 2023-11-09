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
    public partial class CrossflowIndex : Form
    {
        public CrossflowIndex()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Npcf, Npncf, Npu, Ci;
            Npcf = Convert.ToDouble(txtlayered.Text);
            Npncf = Convert.ToDouble(txtstratified.Text);
            Npu = Convert.ToDouble(txtuniform.Text);
            Ci = (Npcf - Npncf) / (Npu - Npncf);
            txtcrossflow.Text = Ci.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtlayered.Clear();
            txtstratified.Clear();
            txtuniform.Clear();
            txtcrossflow.Clear(); 
        }
    }
}
