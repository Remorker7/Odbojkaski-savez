using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca_2___Selmir_Hasanovic__16926_
{
    public partial class Izvještaj : Form
    {
        List<Klub> klubovi;
        int brojOK = 0, brojMOK = 0, brojŽOK = 0, brojHOK = 0, brojSOK = 0, brojBOK = 0;
        public Izvještaj(List<Klub> kl)
        {
            InitializeComponent();
            klubovi = kl;
            foreach (Klub k in klubovi)
            {
                if (k.Prefiks == "OK")
                    brojOK++;
                else if (k.Prefiks == "BOK")
                    brojBOK++;
                else if (k.Prefiks == "MOK")
                    brojMOK++;
                else if (k.Prefiks == "ŽOK")
                    brojŽOK++;
                else if (k.Prefiks == "SOK")
                    brojSOK++;
                else if (k.Prefiks == "HOK")
                    brojHOK++;
            }
            Prefiksi.Series["Prefiksi"].Points.AddXY("OK", brojOK);
            Prefiksi.Series["Prefiksi"].Points.AddXY("MOK", brojMOK);
            Prefiksi.Series["Prefiksi"].Points.AddXY("ŽOK", brojŽOK);
            Prefiksi.Series["Prefiksi"].Points.AddXY("HOK", brojHOK);
            Prefiksi.Series["Prefiksi"].Points.AddXY("SOK", brojSOK);
            Prefiksi.Series["Prefiksi"].Points.AddXY("BOK", brojBOK);

            Prefiksi2.Series["PPrefiksi"].Points.AddXY("OK", brojOK);
            Prefiksi2.Series["PPrefiksi"].Points.AddXY("MOK", brojMOK);
            Prefiksi2.Series["PPrefiksi"].Points.AddXY("ŽOK", brojŽOK);
            Prefiksi2.Series["PPrefiksi"].Points.AddXY("HOK", brojHOK);
            Prefiksi2.Series["PPrefiksi"].Points.AddXY("SOK", brojSOK);
            Prefiksi2.Series["PPrefiksi"].Points.AddXY("BOK", brojBOK);
        }
    }
}
