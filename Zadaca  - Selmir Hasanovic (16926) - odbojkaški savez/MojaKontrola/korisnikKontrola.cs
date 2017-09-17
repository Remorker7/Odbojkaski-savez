using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojaKontrola
{
    public partial class korisnikKontrola : UserControl
    {
        public korisnikKontrola()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            GlavniGBox.Visible = true;
        }
    }
}
