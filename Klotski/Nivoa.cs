using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Klotski
{
    public static class Nivoa
    {
        public static List<Podloga> ZemiNivoa()
        {
            List<Podloga> pod = new List<Podloga>();
            #region Prvo nivo
            Brush b1 = new SolidBrush(Color.Yellow);
            Brush g1 = new SolidBrush(Color.Gray);
            Brush t1 = new SolidBrush(Color.Red);
            Brush i1 = new SolidBrush(Color.WhiteSmoke);

            Kocka[] koc = { new Kocka(3, 3) }; 
            Figura ff = new Figura(koc, b1);
            Kocka[] koc0 = { new Kocka(4, 3) };
            Figura ff0 = new Figura(koc0, b1);
            Kocka[] koc1 = { new Kocka(5, 3) };
            Figura ff1 = new Figura(koc1, b1);
            Kocka[] koc2 = { new Kocka(6, 3) };
            Figura ff2 = new Figura(koc2, b1);
            Kocka[] koc3 = { new Kocka(7, 3) };
            Figura ff3 = new Figura(koc3, b1);
            Kocka[] koc4 = { new Kocka(5, 4) };
            Figura ff4 = new Figura(koc4, b1);
            Kocka[] koc5 = { new Kocka(6, 4) };
            Figura ff5 = new Figura(koc5, b1);
            Kocka[] koc6 = { new Kocka(5, 5) };
            Figura ff6 = new Figura(koc6, b1);
            Kocka[] koc7 = { new Kocka(6, 5) };
            Figura ff7 = new Figura(koc7, b1);
            Kocka[] koc8 = { new Kocka(3, 6) };
            Figura ff8 = new Figura(koc8, b1);
            Kocka[] koc9 = { new Kocka(4, 6) };
            Figura ff9 = new Figura(koc9, b1);
            Kocka[] koc10 = { new Kocka(5, 6) };
            Figura ff10 = new Figura(koc10, b1);
            Kocka[] koc11 = { new Kocka(6, 6) };
            Figura ff11 = new Figura(koc11, b1);
            Kocka[] koc12 = { new Kocka(7, 6) };
            Figura ff12 = new Figura(koc12, b1);
            Kocka[] koc13 = { new Kocka(3, 4), new Kocka(3, 5), new Kocka(4, 4), new Kocka(4, 5) };
            Figura fig = new Figura(koc13, t1);
            Kocka[] koc14 = { new Kocka(2, 2),new Kocka(2, 3),new Kocka(2, 4),new Kocka(2, 5),new Kocka(2, 6),new Kocka(2, 7),new Kocka(3,2),new Kocka(4, 2),new Kocka(5, 2),new Kocka(6, 2),new Kocka(7, 2),new Kocka(8, 2),
                                new Kocka(8, 3),new Kocka(3,7),new Kocka(4, 7),new Kocka(5, 7),new Kocka(6, 7),new Kocka(7, 7),new Kocka(8, 7), new Kocka(8,6)};
            Figura gran = new Figura(koc14, g1);
            Kocka[] koc16 ={ new Kocka(8,4), new Kocka(8,5)};
            Figura izl = new Figura(koc16, i1);
            Kocka[] koc15 = { new Kocka(9, 8), new Kocka(9, 9), new Kocka(10, 8), new Kocka(10, 9) };
            Figura cel = new Figura(koc15, t1);
            Figura []figuri = {ff, ff0,ff1, ff2,ff3,ff4, ff5,ff6, ff7,ff8,ff9, ff10,ff11, ff12, fig};
            Podloga p1 = new Podloga(12, 11, 110, figuri, gran, izl, cel, fig);

            
            
            #endregion
            #region Vtoro nivo
            Kocka[] akoc = { new Kocka(3, 3), new Kocka(4, 3) };
            Figura aff = new Figura(akoc, b1);
            Kocka[] akoc1 = { new Kocka(5, 3) };
            Figura aff1 = new Figura(akoc1, b1);
            Kocka[] akoc2 = { new Kocka(6, 3) };
            Figura aff2 = new Figura(akoc2, b1);
            Kocka[] akoc3 = { new Kocka(7, 3) };
            Figura aff3 = new Figura(akoc3, b1);
            Kocka[] akoc4 = { new Kocka(5, 4) };
            Figura aff4 = new Figura(akoc4, b1);
            Kocka[] akoc5 = { new Kocka(6, 4) };
            Figura aff5 = new Figura(akoc5, b1);
            Kocka[] akoc6 = { new Kocka(5, 5) };
            Figura aff6 = new Figura(akoc6, b1);
            Kocka[] akoc7 = { new Kocka(6, 5) };
            Figura aff7 = new Figura(akoc7, b1);
            Kocka[] akoc8 = { new Kocka(3, 6), new Kocka(4, 6) };
            Figura aff8 = new Figura(akoc8, b1);
            Kocka[] akoc10 = { new Kocka(5, 6) };
            Figura aff10 = new Figura(akoc10, b1);
            Kocka[] akoc11 = { new Kocka(6, 6) };
            Figura aff11 = new Figura(akoc11, b1);
            Kocka[] akoc12 = { new Kocka(7, 6) };
            Figura aff12 = new Figura(akoc12, b1);
            Kocka[] akoc13 = { new Kocka(3, 4), new Kocka(3, 5), new Kocka(4, 4), new Kocka(4, 5) };
            Figura afig = new Figura(akoc13, t1);
            Kocka[] akoc14 = { new Kocka(2, 2),new Kocka(2, 3),new Kocka(2, 4),new Kocka(2, 5),new Kocka(2, 6),new Kocka(2, 7),new Kocka(3,2),new Kocka(4, 2),new Kocka(5, 2),new Kocka(6, 2),new Kocka(7, 2),new Kocka(8, 2),
                                new Kocka(8, 3),new Kocka(3,7),new Kocka(4, 7),new Kocka(5, 7),new Kocka(6, 7),new Kocka(7, 7),new Kocka(8, 7), new Kocka(8,6)};
            Figura agran = new Figura(akoc14, g1);
            Kocka[] akoc16 = { new Kocka(8, 4), new Kocka(8, 5) };
            Figura aizl = new Figura(akoc16, i1);
            Kocka[] akoc15 = { new Kocka(9, 8), new Kocka(9, 9), new Kocka(10, 8), new Kocka(10, 9) };
            Figura acel = new Figura(akoc15, t1);
            Figura[] afiguri = { aff, aff1, aff2, aff3, aff4, aff5, aff6, aff7, aff8, aff10, aff11, aff12, afig };
            Podloga ap1 = new Podloga(12, 11, 110, afiguri, agran, aizl, acel, afig);



            #endregion
            #region Treto nivo
            Kocka[] bkoc = { new Kocka(3, 3), new Kocka(4, 3) };
            Figura bff = new Figura(bkoc, b1);
            Kocka[] bkoc1 = { new Kocka(5, 3), new Kocka(6, 3) };
            Figura bff1 = new Figura(bkoc1, b1);
            Kocka[] bkoc3 = { new Kocka(7, 3) };
            Figura bff3 = new Figura(bkoc3, b1);
            Kocka[] bkoc4 = { new Kocka(5, 4) };
            Figura bff4 = new Figura(bkoc4, b1);
            Kocka[] bkoc5 = { new Kocka(6, 4) };
            Figura bff5 = new Figura(bkoc5, b1);
            Kocka[] bkoc6 = { new Kocka(5, 5) };
            Figura bff6 = new Figura(bkoc6, b1);
            Kocka[] bkoc7 = { new Kocka(6, 5) };
            Figura bff7 = new Figura(bkoc7, b1);
            Kocka[] bkoc8 = { new Kocka(3, 6), new Kocka(4, 6) };
            Figura bff8 = new Figura(bkoc8, b1);
            Kocka[] bkoc10 = { new Kocka(5, 6) };
            Figura bff10 = new Figura(bkoc10, b1);
            Kocka[] bkoc11 = { new Kocka(6, 6) };
            Figura bff11 = new Figura(bkoc11, b1);
            Kocka[] bkoc12 = { new Kocka(7, 6) };
            Figura bff12 = new Figura(bkoc12, b1);
            Kocka[] bkoc13 = { new Kocka(3, 4), new Kocka(3, 5), new Kocka(4, 4), new Kocka(4, 5) };
            Figura bfig = new Figura(bkoc13, t1);
            Kocka[] bkoc14 = { new Kocka(2, 2),new Kocka(2, 3),new Kocka(2, 4),new Kocka(2, 5),new Kocka(2, 6),new Kocka(2, 7),new Kocka(3,2),new Kocka(4, 2),new Kocka(5, 2),new Kocka(6, 2),new Kocka(7, 2),new Kocka(8, 2),
                                new Kocka(8, 3),new Kocka(3,7),new Kocka(4, 7),new Kocka(5, 7),new Kocka(6, 7),new Kocka(7, 7),new Kocka(8, 7), new Kocka(8,6)};
            Figura bgran = new Figura(bkoc14, g1);
            Kocka[] bkoc16 = { new Kocka(8, 4), new Kocka(8, 5) };
            Figura bizl = new Figura(bkoc16, i1);
            Kocka[] bkoc15 = { new Kocka(9, 8), new Kocka(9, 9), new Kocka(10, 8), new Kocka(10, 9) };
            Figura bcel = new Figura(bkoc15, t1);
            Figura[] bfiguri = { bff, bff1, bff3, bff4, bff5, bff6, bff7, bff8, bff10, bff11, bff12, bfig };
            Podloga bp1 = new Podloga(12, 11, 110, bfiguri, bgran, bizl, bcel, bfig);



            #endregion
            #region Cetvrto nivo
            Kocka[] ckoc = { new Kocka(3, 3), new Kocka(4, 3) };
            Figura cff = new Figura(ckoc, b1);
            Kocka[] ckoc1 = { new Kocka(5, 3) };
            Figura cff1 = new Figura(ckoc1, b1);
            Kocka[] ckoc2 = { new Kocka(6, 3) };
            Figura cff2 = new Figura(ckoc2, b1);
            Kocka[] ckoc3 = { new Kocka(7, 3) };
            Figura cff3 = new Figura(ckoc3, b1);
            Kocka[] ckoc4 = { new Kocka(5, 4) ,new Kocka(5, 5) };
            Figura cff4 = new Figura(ckoc4, b1);
            Kocka[] ckoc5 = { new Kocka(6, 4) };
            Figura cff5 = new Figura(ckoc5, b1);
            Kocka[] ckoc7 = { new Kocka(6, 5) };
            Figura cff7 = new Figura(ckoc7, b1);
            Kocka[] ckoc8 = { new Kocka(3, 6), new Kocka(4, 6) };
            Figura cff8 = new Figura(ckoc8, b1);
            Kocka[] ckoc10 = { new Kocka(5, 6) };
            Figura cff10 = new Figura(ckoc10, b1);
            Kocka[] ckoc11 = { new Kocka(6, 6) };
            Figura cff11 = new Figura(ckoc11, b1);
            Kocka[] ckoc12 = { new Kocka(7, 6) };
            Figura cff12 = new Figura(ckoc12, b1);
            Kocka[] ckoc13 = { new Kocka(3, 4), new Kocka(3, 5), new Kocka(4, 4), new Kocka(4, 5) };
            Figura cfig = new Figura(ckoc13, t1);
            Kocka[] ckoc14 = { new Kocka(2, 2),new Kocka(2, 3),new Kocka(2, 4),new Kocka(2, 5),new Kocka(2, 6),new Kocka(2, 7),new Kocka(3,2),new Kocka(4, 2),new Kocka(5, 2),new Kocka(6, 2),new Kocka(7, 2),new Kocka(8, 2),
                                new Kocka(8, 3),new Kocka(3,7),new Kocka(4, 7),new Kocka(5, 7),new Kocka(6, 7),new Kocka(7, 7),new Kocka(8, 7), new Kocka(8,6)};
            Figura cgran = new Figura(ckoc14, g1);
            Kocka[] ckoc16 = { new Kocka(8, 4), new Kocka(8, 5) };
            Figura cizl = new Figura(ckoc16, i1);
            Kocka[] ckoc15 = { new Kocka(9, 8), new Kocka(9, 9), new Kocka(10, 8), new Kocka(10, 9) };
            Figura ccel = new Figura(ckoc15, t1);
            Figura[] cfiguri = { cff, cff1, cff2, cff3, cff4, cff5, cff7, cff8, cff10, cff11, cff12, cfig };
            Podloga cp1 = new Podloga(12, 11, 110, cfiguri, cgran, cizl, ccel, cfig);



            #endregion
            #region Petto nivo
            Kocka[] dkoc = { new Kocka(3, 3), new Kocka(4, 3) };
            Figura dff = new Figura(dkoc, b1);
            Kocka[] dkoc1 = { new Kocka(5, 3), new Kocka(6, 3) };
            Figura dff1 = new Figura(dkoc1, b1);
            Kocka[] dkoc3 = { new Kocka(7, 3) };
            Figura dff3 = new Figura(dkoc3, b1);
            Kocka[] dkoc4 = { new Kocka(5, 4) };
            Figura dff4 = new Figura(dkoc4, b1);
            Kocka[] dkoc5 = { new Kocka(6, 4) };
            Figura dff5 = new Figura(dkoc5, b1);
            Kocka[] dkoc6 = { new Kocka(5, 5) };
            Figura dff6 = new Figura(dkoc6, b1);
            Kocka[] dkoc7 = { new Kocka(6, 5) };
            Figura dff7 = new Figura(dkoc7, b1);
            Kocka[] dkoc8 = { new Kocka(3, 6), new Kocka(4, 6) };
            Figura dff8 = new Figura(dkoc8, b1);
            Kocka[] dkoc10 = { new Kocka(5, 6), new Kocka(6, 6) };
            Figura dff10 = new Figura(dkoc10, b1);
            Kocka[] dkoc12 = { new Kocka(7, 6) };
            Figura dff12 = new Figura(dkoc12, b1);
            Kocka[] dkoc13 = { new Kocka(3, 4), new Kocka(3, 5), new Kocka(4, 4), new Kocka(4, 5) };
            Figura dfig = new Figura(dkoc13, t1);
            Kocka[] dkoc14 = { new Kocka(2, 2),new Kocka(2, 3),new Kocka(2, 4),new Kocka(2, 5),new Kocka(2, 6),new Kocka(2, 7),new Kocka(3,2),new Kocka(4, 2),new Kocka(5, 2),new Kocka(6, 2),new Kocka(7, 2),new Kocka(8, 2),
                                new Kocka(8, 3),new Kocka(3,7),new Kocka(4, 7),new Kocka(5, 7),new Kocka(6, 7),new Kocka(7, 7),new Kocka(8, 7), new Kocka(8,6)};
            Figura dgran = new Figura(dkoc14, g1);
            Kocka[] dkoc16 = { new Kocka(8, 4), new Kocka(8, 5) };
            Figura dizl = new Figura(dkoc16, i1);
            Kocka[] dkoc15 = { new Kocka(9, 8), new Kocka(9, 9), new Kocka(10, 8), new Kocka(10, 9) };
            Figura dcel = new Figura(dkoc15, t1);
            Figura[] dfiguri = { dff, dff1, dff3, dff4, dff5, dff6, dff7, dff8, dff10, dff12, dfig };
            Podloga dp1 = new Podloga(12, 11, 110, dfiguri, dgran, dizl, dcel, dfig);



            #endregion
            #region Sesto nivo
            Kocka[] ekoc = { new Kocka(3, 3), new Kocka(4, 3) };
            Figura eff = new Figura(ekoc, b1);
            Kocka[] ekoc1 = { new Kocka(5, 3), new Kocka(6, 3) };
            Figura eff1 = new Figura(ekoc1, b1);
            Kocka[] ekoc3 = { new Kocka(7, 3) };
            Figura eff3 = new Figura(ekoc3, b1);
            Kocka[] ekoc4 = { new Kocka(5, 4), new Kocka(5, 5) };
            Figura eff4 = new Figura(ekoc4, b1);
            Kocka[] ekoc5 = { new Kocka(6, 4) };
            Figura eff5 = new Figura(ekoc5, b1);
            Kocka[] ekoc7 = { new Kocka(6, 5) };
            Figura eff7 = new Figura(ekoc7, b1);
            Kocka[] ekoc8 = { new Kocka(3, 6), new Kocka(4, 6) };
            Figura eff8 = new Figura(ekoc8, b1);
            Kocka[] ekoc10 = { new Kocka(5, 6) };
            Figura eff10 = new Figura(ekoc10, b1);
            Kocka[] ekoc11 = { new Kocka(6, 6) };
            Figura eff11 = new Figura(ekoc11, b1);
            Kocka[] ekoc12 = { new Kocka(7, 6) };
            Figura eff12 = new Figura(ekoc12, b1);
            Kocka[] ekoc13 = { new Kocka(3, 4), new Kocka(3, 5), new Kocka(4, 4), new Kocka(4, 5) };
            Figura efig = new Figura(ekoc13, t1);
            Kocka[] ekoc14 = { new Kocka(2, 2),new Kocka(2, 3),new Kocka(2, 4),new Kocka(2, 5),new Kocka(2, 6),new Kocka(2, 7),new Kocka(3,2),new Kocka(4, 2),new Kocka(5, 2),new Kocka(6, 2),new Kocka(7, 2),new Kocka(8, 2),
                                new Kocka(8, 3),new Kocka(3,7),new Kocka(4, 7),new Kocka(5, 7),new Kocka(6, 7),new Kocka(7, 7),new Kocka(8, 7), new Kocka(8,6)};
            Figura egran = new Figura(ekoc14, g1);
            Kocka[] ekoc16 = { new Kocka(8, 4), new Kocka(8, 5) };
            Figura eizl = new Figura(ekoc16, i1);
            Kocka[] ekoc15 = { new Kocka(9, 8), new Kocka(9, 9), new Kocka(10, 8), new Kocka(10, 9) };
            Figura ecel = new Figura(ekoc15, t1);
            Figura[] efiguri = { eff, eff1, eff3, eff4, eff5, eff7, eff8, eff10, eff11, eff12, efig };
            Podloga ep1 = new Podloga(12, 11, 110, efiguri, egran, eizl, ecel, efig);



            #endregion
            #region Sedmo nivo
            Kocka[] fkoc = { new Kocka(3, 3), new Kocka(4, 3) };
            Figura fff = new Figura(fkoc, b1);
            Kocka[] fkoc1 = { new Kocka(5, 3), new Kocka(6, 3) };
            Figura fff1 = new Figura(fkoc1, b1);
            Kocka[] fkoc3 = { new Kocka(7, 3) };
            Figura fff3 = new Figura(fkoc3, b1);
            Kocka[] fkoc4 = { new Kocka(5, 4), new Kocka(5, 5) };
            Figura fff4 = new Figura(fkoc4, b1);
            Kocka[] fkoc5 = { new Kocka(6, 4) };
            Figura fff5 = new Figura(fkoc5, b1);
            Kocka[] fkoc7 = { new Kocka(6, 5) };
            Figura fff7 = new Figura(fkoc7, b1);
            Kocka[] fkoc8 = { new Kocka(3, 6), new Kocka(4, 6) };
            Figura fff8 = new Figura(fkoc8, b1);
            Kocka[] fkoc10 = { new Kocka(5, 6), new Kocka(6, 6) };
            Figura fff10 = new Figura(fkoc10, b1);
            Kocka[] fkoc12 = { new Kocka(7, 6) };
            Figura fff12 = new Figura(fkoc12, b1);
            Kocka[] fkoc13 = { new Kocka(3, 4), new Kocka(3, 5), new Kocka(4, 4), new Kocka(4, 5) };
            Figura ffig = new Figura(fkoc13, t1);
            Kocka[] fkoc14 = { new Kocka(2, 2),new Kocka(2, 3),new Kocka(2, 4),new Kocka(2, 5),new Kocka(2, 6),new Kocka(2, 7),new Kocka(3,2),new Kocka(4, 2),new Kocka(5, 2),new Kocka(6, 2),new Kocka(7, 2),new Kocka(8, 2),
                                new Kocka(8, 3),new Kocka(3,7),new Kocka(4, 7),new Kocka(5, 7),new Kocka(6, 7),new Kocka(7, 7),new Kocka(8, 7), new Kocka(8,6)};
            Figura fgran = new Figura(fkoc14, g1);
            Kocka[] fkoc16 = { new Kocka(8, 4), new Kocka(8, 5) };
            Figura fizl = new Figura(fkoc16, i1);
            Kocka[] fkoc15 = { new Kocka(9, 8), new Kocka(9, 9), new Kocka(10, 8), new Kocka(10, 9) };
            Figura fcel = new Figura(fkoc15, t1);
            Figura[] ffiguri = { fff, fff1, fff3, fff4, fff5, fff7, fff8, fff10, fff12, ffig };
            Podloga fp1 = new Podloga(12, 11, 110, ffiguri, fgran, fizl, fcel, ffig);



            #endregion

            pod.Add(p1);
            pod.Add(ap1);
            pod.Add(bp1);
            pod.Add(cp1);
            pod.Add(dp1);
            pod.Add(ep1);
            pod.Add(fp1);
            return pod;
        }
    }
}
