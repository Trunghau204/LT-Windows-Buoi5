using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Bitmap file|*.bmp|JPEG file|*.jpg";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                Form2 frm = new Form2(openFile.FileName);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void casedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void titleVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
