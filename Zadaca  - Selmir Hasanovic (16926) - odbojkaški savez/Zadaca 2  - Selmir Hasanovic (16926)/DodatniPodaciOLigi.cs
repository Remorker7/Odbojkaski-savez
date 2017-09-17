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
    public partial class DodatniPodaciOLigi : Form
    {
        public List<Klub> _kluboviZaIspis;
        public DodatniPodaciOLigi(List<Klub> klubovi, out bool dozvoli)
        {
            InitializeComponent();
            _kluboviZaIspis = klubovi;
            try
            {
                mojaKontrola1.klub1 = _kluboviZaIspis[0].Naziv;
                mojaKontrola1.klub2 = _kluboviZaIspis[1].Naziv;
                mojaKontrola1.klub3 = _kluboviZaIspis[2].Naziv;
                mojaKontrola1.klub4 = _kluboviZaIspis[3].Naziv;
                dozvoli = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Izbor klubova neispravan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dozvoli = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mojaKontrola1.izlazak)
                this.Close();
            else
                MessageBox.Show("Niste unijeli podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
