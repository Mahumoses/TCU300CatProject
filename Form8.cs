using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tcu300Cat1
{
    public partial class AverageTempGasColumn : Form
    {
        public AverageTempGasColumn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double Tt, Tb, T;
            Tt = Convert.ToDouble(txttubingheadtemp.Text);
            Tb = Convert.ToDouble(txtwelboretemp.Text);
            if(Regex.IsMatch(txttubingheadtemp.Text,"[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers");
                txttubingheadtemp.Clear();
                txttubingheadtemp.Focus();

            }
            T = (Tt+Tb)/2;
            txtarithmeticavetemp.Text = T.ToString();
            dataGridView1.Rows.Add(txttubingheadtemp.Text,txtwelboretemp.Text,txtarithmeticavetemp.Text);

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txttubingheadtemp.Clear();
            txtwelboretemp.Clear();
            txtarithmeticavetemp.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    internal class Me
    {
    }
}
