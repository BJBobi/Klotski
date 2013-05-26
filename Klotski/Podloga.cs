using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Klotski
{
    public class Podloga
    {
        #region Promenlivi
        public static int levo = 1;
        public static int desno = 2;
        public static int gore = 3;
        public static int dole = 4;
        public int Visina
        {
            get;
            set;
        }
        public int Sirina
        {
            get;
            set;
        }
        public int Broj
        {
            get;
            set;
        }
        public bool[][] Oznaka
        {
            get;
            set;
        }
        public Figura[] Figuri
        {
            get;
            set;
        }
        public Figura Granica
        {
            get;
            set;
        }
        public Figura Izlez
        {
            get;
            set;
        }
        public Figura Cel
        {
            get;
            set;
        }
        public Figura Tar
        {
            get;
            set;
        }

        #endregion 
        public Podloga()
        {
        }
        public Podloga(int vis, int sir, int br, Figura[] fig, Figura g, Figura i, Figura c, Figura tar)
        {
            Visina = vis;
            Sirina = sir;
            Broj = br;
            Figuri = fig;
            Cel = c;
            Granica = g;
            Izlez = i;
            Tar = tar;
        }
        public void Oznaci()
        {
            Oznaka = new bool[Visina][];
            for (int a = 0; a < Sirina; a++)
            {
                Oznaka[a] = new bool[Sirina];
            }

                
            for (int i = 0; i < Figuri.Length; i++)
            {
                    Figura f = Figuri[i];
                    for (int j = 0; j < f.Kocki.Length; j++)
                    {
                        Kocka k = f.Kocki[j];          
                        Oznaka[k.PozicijaX][k.PozicijaY] = true;
                    }
            }
            for (int k = 0; k < Granica.Kocki.Length; k++)
            {
                Kocka koc = Granica.Kocki[k];
                Oznaka[koc.PozicijaX][koc.PozicijaY] = true;
            }
            for (int k = 0; k < Izlez.Kocki.Length; k++)
            {
                Kocka koc = Izlez.Kocki[k];
                Oznaka[koc.PozicijaX][koc.PozicijaY] = true;
            }
            for (int k = 0; k < Cel.Kocki.Length; k++)
            {
                Kocka koc = Cel.Kocki[k];
                Oznaka[koc.PozicijaX][koc.PozicijaY] = true;
            }
        }
        public int Pomesti(Figura f, int nasoka)
        {
            
            
            bool[][] oz = Oznaka;
            Kocka[] k = f.Kocki;
            //bool  flag = false;
            if (Tar == f)
            {

                for (int j = 0; j < Izlez.Kocki.Length; j++)
                {
                    for (int r = 0; r < k.Length; r++)
                    {
                        if (Izlez.Kocki[j].PozicijaX - 1 == k[r].PozicijaX)
                        {
                            Oznaka[Izlez.Kocki[j].PozicijaX][Izlez.Kocki[j].PozicijaY] = false;
                        }
                    }
                }
                for (int j = 0; j < Izlez.Kocki.Length; j++)
                {
                    for (int r = 0; r < k.Length; r++)
                    {
                        if (Izlez.Kocki[j].PozicijaX + 1 == k[r].PozicijaX)
                        {
                            return 2;
                        }
                    }
                }
               
            }

            for (int i = 0; i < k.Length; i++)
            {
                oz[k[i].PozicijaX][k[i].PozicijaY] = false;
            }


            if (nasoka == 1)
            {
                for (int i = 0; i < k.Length; i++)
                {
                   
                        if (oz[k[i].PozicijaX][k[i].PozicijaY - 1]== true)
                        {
                            return 0;
                        }
                    
                }
            }
            if (nasoka == 2)
            {
                for (int i = 0; i < k.Length; i++)
                {
                    
                        if (oz[k[i].PozicijaX][k[i].PozicijaY + 1] == true)
                        {
                            return 0;
                        }
                    
                }
            }
            if (nasoka == 3)
            {
                for (int i = 0; i < k.Length; i++)
                {
                    
                    
                        if (oz[k[i].PozicijaX - 1][k[i].PozicijaY] == true)
                        {
                            return 0;
                        }
                   
                }
            }
            if (nasoka == 4)
            {
                for (int i = 0; i < k.Length; i++)
                {
                    
                        if (oz[k[i].PozicijaX + 1][k[i].PozicijaY] == true)
                        {
                            return 0;
                        }
                    
                }
            }


            return 1;
        }
                 

    }
}
