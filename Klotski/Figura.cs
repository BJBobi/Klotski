using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Klotski
{
    public class Figura
    {
        public Kocka[] Kocki
        {
            get;
            set;
        }
        public Brush B
        {
            get;
            set;
        }
        public Figura()
        {
        }
        public Figura(Kocka[] koc, Brush b)
        {
            Kocki = koc;
            B = b;
        }

    }
}
