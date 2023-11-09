using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tcu300Cat1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            AverageTempGasColumn ATG = new AverageTempGasColumn();
            ATG.MdiParent = this;
            ATG.Show();
            

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.MdiParent = this;
            f9.Show(); 

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            CommFactor f10 = new CommFactor();
            f10.MdiParent = this;
            f10.Show();
        }

        private void toolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            CommFactor f10 = new CommFactor();
            f10.MdiParent = this;
            f10.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            CompDrive f11 = new CompDrive();
            f11.MdiParent = this;
            f11.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.MdiParent = this;
            f12.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            CrossflowIndex f13 = new CrossflowIndex();
            f13.MdiParent = this;
            f13.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            DimRad f14 = new DimRad();
            f14.MdiParent = this;
            f14.Show();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            EffWellRad f15 = new EffWellRad();
            f15.MdiParent = this;
            f15.Show();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            FormTemp f16 = new FormTemp();
            f16.MdiParent = this;
            f16.Show();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            GasExpTerm f17 = new GasExpTerm();
            f17.MdiParent = this;
            f17.Show();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            GasFormVol f18 = new GasFormVol();
            f18.MdiParent = this;
            f18.Show();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            GeothermalGrad f19 = new GeothermalGrad();
            f19.MdiParent = this;
            f19.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            HydroPoreVol form21 = new HydroPoreVol();
            form21.MdiParent = this;
            form21.Show();
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            HydroPressure form22 = new HydroPressure();
            form22.MdiParent = this;
            form22.Show();
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            IneffectivePorosity form23 = new IneffectivePorosity();
            form23.MdiParent = this;
            form23.Show();
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            InitGasCp form24 = new InitGasCp();
            form24.MdiParent = this;
            form24.Show();
        }

        private void form24ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InjecIndex form25 = new InjecIndex();
            form25.MdiParent = this;
            form25.Show();
        }

        private void form25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterVel form26 = new InterVel();
            form26.MdiParent = this;
            form26.Show();
        }

        private void form26ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatBal form27 = new MatBal();
            form27.MdiParent = this;
            form27.Show();
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            ModColePlot form28 = new ModColePlot();
            form28.MdiParent = this;
            form28.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Location = @"C:\Users\Hp\Documents\Academics\3.1\Programming 2\C#";
            string path = System.IO.Path.Combine(Location, "Created Folder"); //new foldername
            System.IO.Directory.CreateDirectory(path);
            MessageBox.Show("Folder Created Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Location = @"C:\Users\Hp\Documents\Academics\3.1\Programming 2\C#";
            string file = System.IO.Path.Combine(Location, "MyFile.docx");
            if (!System.IO.File.Exists(file)) // ! means file does not exist
            {
                System.IO.File.Create(file);
                MessageBox.Show("File Created Successfully");
            }
            else
            {
                MessageBox.Show("File Already Exists");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Location = @"C:\Users\Hp\Documents\Academics\3.1\Programming 2\C#";
            File.WriteAllText(Location, txtfilestream.Text);
            MessageBox.Show("Successfully past the text in the text file");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Location = @"C:\Users\Hp\Documents\Academics\3.1\Programming 2\C#";
            var str = File.ReadAllText(Location);
            txtfilestream.Text = str;

        }

        private void txtfilestream_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
