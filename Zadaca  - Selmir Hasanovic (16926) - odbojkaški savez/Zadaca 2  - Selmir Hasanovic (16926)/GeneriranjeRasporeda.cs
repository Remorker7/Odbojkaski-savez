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
    public partial class GeneriranjeRasporeda : Form
    {
        List<Klub> _klubovi;
        List<int> _brojPoena = new List<int>();
        List<int> _brojOsvojenihSetova = new List<int>();
        List<int> _brojIzgubljenihSetova = new List<int>();
        public GeneriranjeRasporeda(Liga l, List<Klub> k)
        {
            InitializeComponent();
            _klubovi = k;

            foreach (Klub ka in k)
            {
                _brojPoena.Add(0);
                _brojOsvojenihSetova.Add(0);
                _brojIzgubljenihSetova.Add(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GBoxKola.Visible = true;
            // prvo kolo
            K1K1.Text = _klubovi[0].Naziv;
            K1K2.Text = _klubovi[1].Naziv;
            K1K3.Text = _klubovi[2].Naziv;
            K1K4.Text = _klubovi[3].Naziv;
            // drugo kolo
            K2K1.Text = _klubovi[0].Naziv;
            K2K2.Text = _klubovi[2].Naziv;
            K2K3.Text = _klubovi[1].Naziv;
            K2K4.Text = _klubovi[3].Naziv;
            // treće kolo
            K3K1.Text = _klubovi[0].Naziv;
            K3K2.Text = _klubovi[3].Naziv;
            K3K3.Text = _klubovi[1].Naziv;
            K3K4.Text = _klubovi[2].Naziv;
            // četvrto kolo
            K4K1.Text = _klubovi[1].Naziv;
            K4K2.Text = _klubovi[0].Naziv;
            K4K3.Text = _klubovi[3].Naziv;
            K4K4.Text = _klubovi[2].Naziv;
            // peto kolo
            K5K1.Text = _klubovi[2].Naziv;
            K5K2.Text = _klubovi[0].Naziv;
            K5K3.Text = _klubovi[3].Naziv;
            K5K4.Text = _klubovi[1].Naziv;
            // šesto kolo
            K6K1.Text = _klubovi[3].Naziv;
            K6K2.Text = _klubovi[0].Naziv;
            K6K3.Text = _klubovi[2].Naziv;
            K6K4.Text = _klubovi[1].Naziv;
        }
        private void validiraj(int rezultat1, int rezultat2)
        {
            if(rezultat1 + rezultat2 < 3 || rezultat1 + rezultat2 > 5 || (rezultat1 != 3 && rezultat2 != 3))
                throw (new DupliranjeException("Neispravan unos rezultata."));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (K1T1.Text == "" || K1T2.Text == "" || K1T3.Text == "" || K1T4.Text == "" ||
               K2T1.Text == "" || K2T2.Text == "" || K2T3.Text == "" || K2T4.Text == "" ||
               K3T1.Text == "" || K3T2.Text == "" || K3T3.Text == "" || K3T4.Text == "" ||
               K4T1.Text == "" || K4T2.Text == "" || K4T3.Text == "" || K4T4.Text == "")
                MessageBox.Show("Niste unijeli sve rezultate.", "Nevalidan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    validiraj(Int32.Parse(K1T1.Text), Int32.Parse(K1T2.Text));
                    validiraj(Int32.Parse(K1T3.Text), Int32.Parse(K1T4.Text));
                    validiraj(Int32.Parse(K2T1.Text), Int32.Parse(K2T2.Text));
                    validiraj(Int32.Parse(K2T3.Text), Int32.Parse(K2T4.Text));
                    validiraj(Int32.Parse(K3T1.Text), Int32.Parse(K3T2.Text));
                    validiraj(Int32.Parse(K3T3.Text), Int32.Parse(K3T4.Text));
                    validiraj(Int32.Parse(K4T1.Text), Int32.Parse(K4T2.Text));
                    validiraj(Int32.Parse(K4T3.Text), Int32.Parse(K4T4.Text));
                    validiraj(Int32.Parse(K5T1.Text), Int32.Parse(K5T2.Text));
                    validiraj(Int32.Parse(K5T3.Text), Int32.Parse(K5T4.Text));
                    validiraj(Int32.Parse(K6T1.Text), Int32.Parse(K6T2.Text));
                    validiraj(Int32.Parse(K6T3.Text), Int32.Parse(K6T4.Text));

                    if (Int32.Parse(K1T1.Text) == 3) _brojPoena[0] += 3;
                    if (Int32.Parse(K2T1.Text) == 3) _brojPoena[0] += 3;
                    if (Int32.Parse(K3T1.Text) == 3) _brojPoena[0] += 3;
                    if (Int32.Parse(K4T2.Text) == 3) _brojPoena[0] += 3;
                    if (Int32.Parse(K5T2.Text) == 3) _brojPoena[0] += 3;
                    if (Int32.Parse(K6T2.Text) == 3) _brojPoena[0] += 3;
                    _brojOsvojenihSetova[0] += Int32.Parse(K1T1.Text);
                    _brojIzgubljenihSetova[0] += Int32.Parse(K1T2.Text);
                    _brojOsvojenihSetova[0] += Int32.Parse(K2T1.Text);
                    _brojIzgubljenihSetova[0] += Int32.Parse(K2T2.Text);
                    _brojOsvojenihSetova[0] += Int32.Parse(K3T1.Text);
                    _brojIzgubljenihSetova[0] += Int32.Parse(K3T2.Text);
                    _brojOsvojenihSetova[0] += Int32.Parse(K4T2.Text);
                    _brojIzgubljenihSetova[0] += Int32.Parse(K4T1.Text);
                    _brojOsvojenihSetova[0] += Int32.Parse(K5T2.Text);
                    _brojIzgubljenihSetova[0] += Int32.Parse(K5T1.Text);
                    _brojOsvojenihSetova[0] += Int32.Parse(K6T2.Text);
                    _brojIzgubljenihSetova[0] += Int32.Parse(K6T1.Text);
                    if (Int32.Parse(K1T2.Text) == 3) _brojPoena[1] += 3;
                    if (Int32.Parse(K2T3.Text) == 3) _brojPoena[1] += 3;
                    if (Int32.Parse(K3T3.Text) == 3) _brojPoena[1] += 3;
                    if (Int32.Parse(K4T1.Text) == 3) _brojPoena[1] += 3;
                    if (Int32.Parse(K5T4.Text) == 3) _brojPoena[1] += 3;
                    if (Int32.Parse(K6T4.Text) == 3) _brojPoena[1] += 3;
                    _brojOsvojenihSetova[1] += Int32.Parse(K1T2.Text);
                    _brojIzgubljenihSetova[1] += Int32.Parse(K1T1.Text);
                    _brojOsvojenihSetova[1] += Int32.Parse(K2T3.Text);
                    _brojIzgubljenihSetova[1] += Int32.Parse(K2T4.Text);
                    _brojOsvojenihSetova[1] += Int32.Parse(K3T3.Text);
                    _brojIzgubljenihSetova[1] += Int32.Parse(K3T4.Text);
                    _brojOsvojenihSetova[1] += Int32.Parse(K4T1.Text);
                    _brojIzgubljenihSetova[1] += Int32.Parse(K4T2.Text);
                    _brojOsvojenihSetova[1] += Int32.Parse(K5T4.Text);
                    _brojIzgubljenihSetova[1] += Int32.Parse(K5T3.Text);
                    _brojOsvojenihSetova[1] += Int32.Parse(K6T4.Text);
                    _brojIzgubljenihSetova[1] += Int32.Parse(K6T3.Text);
                    if (Int32.Parse(K1T3.Text) == 3) _brojPoena[2] += 3;
                    if (Int32.Parse(K2T2.Text) == 3) _brojPoena[2] += 3;
                    if (Int32.Parse(K3T4.Text) == 3) _brojPoena[2] += 3;
                    if (Int32.Parse(K4T4.Text) == 3) _brojPoena[2] += 3;
                    if (Int32.Parse(K5T1.Text) == 3) _brojPoena[2] += 3;
                    if (Int32.Parse(K6T3.Text) == 3) _brojPoena[2] += 3;
                    _brojOsvojenihSetova[2] += Int32.Parse(K1T3.Text);
                    _brojIzgubljenihSetova[2] += Int32.Parse(K1T4.Text);
                    _brojOsvojenihSetova[2] += Int32.Parse(K2T2.Text);
                    _brojIzgubljenihSetova[2] += Int32.Parse(K2T1.Text);
                    _brojOsvojenihSetova[2] += Int32.Parse(K3T4.Text);
                    _brojIzgubljenihSetova[2] += Int32.Parse(K3T3.Text);
                    _brojOsvojenihSetova[2] += Int32.Parse(K4T4.Text);
                    _brojIzgubljenihSetova[2] += Int32.Parse(K4T3.Text);
                    _brojOsvojenihSetova[2] += Int32.Parse(K5T1.Text);
                    _brojIzgubljenihSetova[2] += Int32.Parse(K5T2.Text);
                    _brojOsvojenihSetova[2] += Int32.Parse(K6T3.Text);
                    _brojIzgubljenihSetova[2] += Int32.Parse(K6T4.Text);
                    if (Int32.Parse(K1T4.Text) == 3) _brojPoena[3] += 3;
                    if (Int32.Parse(K2T4.Text) == 3) _brojPoena[3] += 3;
                    if (Int32.Parse(K3T2.Text) == 3) _brojPoena[3] += 3;
                    if (Int32.Parse(K4T3.Text) == 3) _brojPoena[3] += 3;
                    if (Int32.Parse(K5T3.Text) == 3) _brojPoena[3] += 3;
                    if (Int32.Parse(K6T1.Text) == 3) _brojPoena[3] += 3;
                    _brojOsvojenihSetova[3] += Int32.Parse(K1T4.Text);
                    _brojIzgubljenihSetova[3] += Int32.Parse(K1T3.Text);
                    _brojOsvojenihSetova[3] += Int32.Parse(K2T4.Text);
                    _brojIzgubljenihSetova[3] += Int32.Parse(K2T3.Text);
                    _brojOsvojenihSetova[3] += Int32.Parse(K3T2.Text);
                    _brojIzgubljenihSetova[3] += Int32.Parse(K3T1.Text);
                    _brojOsvojenihSetova[3] += Int32.Parse(K4T3.Text);
                    _brojIzgubljenihSetova[3] += Int32.Parse(K4T4.Text);
                    _brojOsvojenihSetova[3] += Int32.Parse(K5T3.Text);
                    _brojIzgubljenihSetova[3] += Int32.Parse(K5T4.Text);
                    _brojOsvojenihSetova[3] += Int32.Parse(K6T1.Text);
                    _brojIzgubljenihSetova[3] += Int32.Parse(K6T2.Text);
                    MessageBox.Show("Podaci uspješno evidentirani. Klikom na dugme 'Ispiši tabelu' možete vidjeti kompletnu tabelu evidentirane sezone.", "Evidentiranje uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Rezultati moraju biti brojčane vrijednosti.", "Greška pri unosu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DupliranjeException d)
                {
                    MessageBox.Show(d.Message, "Neispravni rezultat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tabela _tab = new Tabela(_klubovi, _brojOsvojenihSetova, _brojIzgubljenihSetova, _brojPoena);
            _tab.ShowDialog();
        }
    }
}
