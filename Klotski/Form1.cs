using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Klotski
{
    public partial class Form1 : Form
    {
        public int Nivo = 1;
 
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            int visina = this.Size.Height;
            int sirina = this.Size.Width;
            Graphics g = e.Graphics;
            String s = "Клотски";
            Brush b = new SolidBrush(Color.Black);
            Font f = new Font("Arial", 45);
            g.DrawString(s, f, b, new Point(120, 50));
            Brush b1 = new SolidBrush(Color.Gray);
            g.DrawString(s, f, b1, new Point(118, 50));



        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (Nivo <= 7)
            {
                Igra i = new Igra(Nivo);
                i.ShowDialog();
                if (Nivo <= 7)
                {
                    Nivo++;
                    ToolStripMenuItem_Click(null, null);
                }
            }
            else
            {
                Nivo = 1;
            }
            
        }

        private void првоНивоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Igra i = new Igra(1);
            i.ShowDialog();
        }

        private void првоНивоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Igra i = new Igra(2);
            i.ShowDialog();
        }

        private void првоНивоToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Igra i = new Igra(3);
            i.ShowDialog();
        }

        private void првоНивоToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Igra i = new Igra(4);
            i.ShowDialog();
        }

        private void првоНивоToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Igra i = new Igra(5);
            i.ShowDialog();
        }

        private void првоНивоToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Igra i = new Igra(6);
            i.ShowDialog();
        }

        private void првоНивоToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Igra i = new Igra(7);
            i.ShowDialog();
        }

        private void упатствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pomos p = new Pomos();
            p.ShowDialog();
        }



    
        

        

        

    }
}
