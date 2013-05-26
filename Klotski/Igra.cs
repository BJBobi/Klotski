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
    public partial class Igra : Form
    {
        public String s
        {
            get;
            set;
        }
        public Brush b1
        {
            get;
            set;
        }
        public Graphics g
        {
            get;
            set;
        }
        public List<Podloga> p
        {
            get;
            set;
        }
        public int br_Fig
        {
            get;
            set;
        }
        public bool fateno
        {
            get;
            set;
        }
        public int Nas
        {
            get;
            set;
        }
        public Figura Fig
        {
            get;
            set;
        }
        public Podloga po
        {
            get;
            set;
        }
        public int x
        {
            get;
            set;
        }
        public int y
        {
            get;
            set;
        }
        public int Min
        {
            get;
            set;
        }
        public int Sec
        {
            get;
            set;
        }
        public int Potezi
        {
            get;
            set;
        }
        public bool mrdnato = false;
        
        public int Nivo
        {
            get;
            set;
        }
        public bool Prove = true;
        
        public Igra(int nivo)
        {
            InitializeComponent();
            Potezi = 0;
            Nivo = nivo;
            timer1.Start();
            p = Nivoa.ZemiNivoa();
            po = p.ElementAt(Nivo - 1);
            po.Oznaci();
            g = CreateGraphics();
           
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            
            g.Clear(Color.Black);
           
            bool[][] prov = po.Oznaka;
            Brush b = new SolidBrush(Color.Black);
            b1 = new SolidBrush(Color.White);
            Pen pe = new Pen(b, 4);
            Pen pe1 = new Pen(b1, 2);
            int broj = 35;
            Figura izl = po.Izlez;
            for (int l = 0; l < izl.Kocki.Length; l++)
            {
                int br1 = izl.Kocki[l].PozicijaX;
                int br2 = izl.Kocki[l].PozicijaY;
                Rectangle r = new Rectangle(broj * br2, broj * br1, broj, broj);
                g.FillRectangle(izl.B, r);
            }
            for (int i = 0; i < po.Figuri.Length; i++)
            {
                Figura f = po.Figuri[i];
                for (int j = 0; j < f.Kocki.Length; j++)
                {
                    int br1 = f.Kocki[j].PozicijaX;
                    int br2 = f.Kocki[j].PozicijaY;
                    Rectangle r = new Rectangle(broj * br2, broj * br1, broj, broj);
                    g.FillRectangle(f.B, r);
                }
                for (int m = 0; m < f.Kocki.Length; m++)
                {
                   

                    int br1 = f.Kocki[m].PozicijaX;
                    int br2 = f.Kocki[m].PozicijaY;
                    bool flag1 = true;
                    bool flag2 = true;
                    bool flag3 = true;
                    bool flag4 = true;
                    for (int n = 0; n < f.Kocki.Length; n++)
                    {
                        Kocka k = f.Kocki[n];
                        if (k.PozicijaX == br1 + 1 && k.PozicijaY == br2)
                        {
                            flag1 = false;
                        }
                        if (k.PozicijaX == br1 - 1 && k.PozicijaY == br2)
                        {
                            flag2 = false;
                        }
                        if (k.PozicijaX == br1 && k.PozicijaY == br2 + 1)
                        {
                            flag3 = false;
                        }
                        if (k.PozicijaX == br1 && k.PozicijaY == br2 - 1)
                        {
                            flag4 = false;
                        }
                    }

                    if (flag1)
                    {
                        Point p1 = new Point(br2 * broj, (br1 + 1) * broj);
                        Point p2 = new Point((br2 + 1) * broj, (br1 + 1) * broj);
                        g.DrawLine(pe, p1, p2);
                        g.DrawLine(pe1, p1, p2);
                    }
                    if (flag2)
                    {
                        Point p1 = new Point(br2 * broj, br1 * broj);
                        Point p2 = new Point((br2 + 1) * broj, br1 * broj);
                        g.DrawLine(pe, p1, p2);
                        g.DrawLine(pe1, p1, p2);
                    }
                    if (flag3)
                    {
                        Point p1 = new Point((br2 + 1) * broj, br1 * broj);
                        Point p2 = new Point((br2 + 1) * broj, (br1 + 1) * broj);
                        g.DrawLine(pe, p1, p2);
                        g.DrawLine(pe1, p1, p2);
                    }
                    if (flag4)
                    {
                        Point p1 = new Point(br2 * broj, br1 * broj);
                        Point p2 = new Point(br2 * broj, (br1 + 1) * broj);
                        g.DrawLine(pe, p1, p2);
                        g.DrawLine(pe1, p1, p2);
                    }
                }
            }
            Figura gr = po.Granica;
            for (int k = 0; k < po.Granica.Kocki.Length; k++)
            {
                int br1 = gr.Kocki[k].PozicijaX;
                int br2 = gr.Kocki[k].PozicijaY;
                Rectangle r = new Rectangle(broj * br2, broj * br1, broj, broj);
                g.FillRectangle(gr.B, r);
                bool f1 = true;
                bool f2 = true;
                bool f3 = true;
                bool f4 = true;
                for (int i = 0; i < gr.Kocki.Length; i++)
                {
                    Kocka kc = gr.Kocki[i];
                    if (kc.PozicijaX == br1 + 1 && kc.PozicijaY == br2)
                    {
                        f1 = false;
                    }
                    if (kc.PozicijaX == br1 - 1 && kc.PozicijaY == br2)
                    {
                        f2 = false;
                    }
                    if (kc.PozicijaX == br1 && kc.PozicijaY == br2 + 1)
                    {
                        f3 = false;
                    }
                    if (kc.PozicijaX == br1 && kc.PozicijaY == br2 - 1)
                    {
                        f4 = false;
                    }
                }

                if (f1)
                {
                    Point p1 = new Point(br2 * broj, (br1 + 1) * broj);
                    Point p2 = new Point((br2 + 1) * broj, (br1 + 1) * broj);
                    g.DrawLine(pe, p1, p2);
                    g.DrawLine(pe1, p1, p2);
                }
                if (f2)
                {
                    Point p1 = new Point(br2 * broj, br1 * broj);
                    Point p2 = new Point((br2 + 1) * broj, br1 * broj);
                    g.DrawLine(pe, p1, p2);
                    g.DrawLine(pe1, p1, p2);
                }
                if (f3)
                {
                    Point p1 = new Point((br2 + 1) * broj, br1 * broj);
                    Point p2 = new Point((br2 + 1) * broj, (br1 + 1) * broj);
                    g.DrawLine(pe, p1, p2);
                    g.DrawLine(pe1, p1, p2);
                }
                if (f4)
                {
                    Point p1 = new Point(br2 * broj, br1 * broj);
                    Point p2 = new Point(br2 * broj, (br1 + 1) * broj);
                    g.DrawLine(pe, p1, p2);
                    g.DrawLine(pe1, p1, p2);
                }

            }

            Figura c = po.Cel;
            for (int l = 0; l < c.Kocki.Length; l++)
            {
                int br1 = c.Kocki[l].PozicijaX;
                int br2 = c.Kocki[l].PozicijaY;
                Rectangle r = new Rectangle(broj * br2, broj * br1, broj, broj);
                g.FillRectangle(c.B, r);
                bool f1 = true;
                bool f2 = true;
                bool f3 = true;
                bool f4 = true;
                for (int i = 0; i < c.Kocki.Length; i++)
                {
                    Kocka kc = c.Kocki[i];
                    if (kc.PozicijaX == br1 + 1 && kc.PozicijaY == br2)
                    {
                        f1 = false;
                    }
                    if (kc.PozicijaX == br1 - 1 && kc.PozicijaY == br2)
                    {
                        f2 = false;
                    }
                    if (kc.PozicijaX == br1 && kc.PozicijaY == br2 + 1)
                    {
                        f3 = false;
                    }
                    if (kc.PozicijaX == br1 && kc.PozicijaY == br2 - 1)
                    {
                        f4 = false;
                    }
                }

                if (f1)
                {
                    Point p1 = new Point(br2 * broj, (br1 + 1) * broj);
                    Point p2 = new Point((br2 + 1) * broj, (br1 + 1) * broj);
                    g.DrawLine(pe, p1, p2);
                    g.DrawLine(pe1, p1, p2);
                }
                if (f2)
                {
                    Point p1 = new Point(br2 * broj, br1 * broj);
                    Point p2 = new Point((br2 + 1) * broj, br1 * broj);
                    g.DrawLine(pe, p1, p2);
                    g.DrawLine(pe1, p1, p2);
                }
                if (f3)
                {
                    Point p1 = new Point((br2 + 1) * broj, br1 * broj);
                    Point p2 = new Point((br2 + 1) * broj, (br1 + 1) * broj);
                    g.DrawLine(pe, p1, p2);
                    g.DrawLine(pe1, p1, p2);
                }
                if (f4)
                {
                    Point p1 = new Point(br2 * broj, br1 * broj);
                    Point p2 = new Point(br2 * broj, (br1 + 1) * broj);
                    g.DrawLine(pe, p1, p2);
                    g.DrawLine(pe1, p1, p2);
                }
            }


            
        }
       
        protected override void OnMouseUp(MouseEventArgs e)
        {
           
            if (Prove)
            {
                x = e.X;
                y = e.Y;
                mrdnato = true;
            }
            Prove = true;
            
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
   
            fateno = false;
            if (po != null && mrdnato == true)
            {
                
                for (int i = 0; i < po.Figuri.Length; i++)
                {
                    Figura f = po.Figuri[i];
                    for (int j = 0; j < f.Kocki.Length; j++)
                    {
                        Kocka k = f.Kocki[j];
                        if ((k.PozicijaY*35 <= x && k.PozicijaX*35  <= y) && ((k.PozicijaY*35) + 35 >= x && (k.PozicijaX*35) + 35 >= y))
                        {
                            fateno = true;
                            br_Fig = i;
                            Fig = f;

                        }
                    }
                }
                if (fateno)
                {
                    int pomx = e.X;
                    int pomy = e.Y;
                    
                    if (pomx > x + 20 && pomx < x + 90 && pomy < y + 40 && pomy > y - 40)
                    {
                        Nas = 2;
                    }
                    else if (pomx > x - 90 && pomx < x - 20 && pomy < y + 40 && pomy > y - 40)
                    {
                        Nas = 1;

                    }
                    else if (pomy > x + 20 && pomy < y + 90 && pomx < x + 40 && pomx > x - 40)
                    {
                        Nas = 4;
                    }
                    else if (pomy < y - 20 && pomy > y - 90 && pomx < x + 40 && pomx > x - 40)
                    {
                        Nas = 3;
                    }
                    
                    

                }
            }
            
            
            if (po != null && Fig != null)
            {
                if (mrdnato)
                {
                    po.Oznaci(); 
                    if (po.Pomesti(Fig, Nas) == 1)
                    {
                        
                        Potezi++;
                        label4.Text = "" + Potezi;
                        if(Nas == 1)
                        {
                            for (int i = 0; i < Fig.Kocki.Length; i++)
                            {
                                Kocka k = new Kocka(Fig.Kocki[i].PozicijaX, Fig.Kocki[i].PozicijaY -1);
                                Fig.Kocki[i] = k;
                            }
                        }
                        if(Nas == 2)
                        {
                            for (int i = 0; i < Fig.Kocki.Length; i++)
                            {
                                Kocka k = new Kocka(Fig.Kocki[i].PozicijaX , Fig.Kocki[i].PozicijaY +1);
                                Fig.Kocki[i] = k;
                            }
                        }
                        if(Nas == 3)
                        {
                            for (int i = 0; i < Fig.Kocki.Length; i++)
                            {
                                Kocka k = new Kocka(Fig.Kocki[i].PozicijaX -1, Fig.Kocki[i].PozicijaY );
                                Fig.Kocki[i] = k;
                            }
                        }
                        if(Nas == 4)
                        {
                            for (int i = 0; i < Fig.Kocki.Length; i++)
                            {
                                Kocka k = new Kocka(Fig.Kocki[i].PozicijaX +1, Fig.Kocki[i].PozicijaY);
                                Fig.Kocki[i] = k;
                            }
                        }

                        po.Figuri[br_Fig] = Fig;
                        po.Oznaci();
                        this.OnPaint(null);
                        
                    }
                    if (po.Pomesti(Fig, Nas) == 2)
                    {
                        MessageBox.Show("Успешно завршена игра за: " + Min + " минути и " + Sec + " секунди во: " + Potezi +" потези!");
                        Close();
                        
                    }
                }
                Prove = false;
            }
            mrdnato = false;
            Fig = null;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Sec == 59)
            {
                Min++;
                Sec = 0;

            }
            else
            {
                Sec++;
            }
            label2.Text = Min + ":" + Sec;
            
        }


    }
}
 