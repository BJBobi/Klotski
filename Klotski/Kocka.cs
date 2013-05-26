using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klotski
{
    public class Kocka
    {
        public int PozicijaX
        {
            get;
            set;
        }
        public int PozicijaY
        {
            get;
            set;
        }
        public Kocka()
        {
        }
        public Kocka(int x, int y)
        {
            PozicijaX = x;
            PozicijaY = y;
        }

    }
}
