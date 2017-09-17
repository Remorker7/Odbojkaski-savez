using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrola
{
    public partial class MojaKontrola : UserControl
    {
        public bool izlazak { get; set; }
        public int id;
        public bool dozvoliPrelazak { get; set; }
        public string klub1 { get; set; }
        public string klub2 { get; set; }
        public string klub3 { get; set; }
        public string klub4 { get; set; }
        public bool dodatniPrikaz
        {
            get { return CBKlubovi.Checked; }
        }
        public MojaKontrola()
        {
            InitializeComponent();
            dozvoliPrelazak = true;
            izlazak = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!SviPodaciUneseni())
            {
                MessageBox.Show("Niste unijeli sve podatke ili je unos neispravan!", "Unos nije validan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LigaPodaci lp = new LigaPodaci(
                TBNazivLige.Text,
                DTPOsnivanje.Value.ToString(),
                (int)NUDKola.Value,
                TBDržava.Text,
                id
            );
            if (CBKlubovi.Checked)
            {
                IspisKlubova.PrviKlub = klub1;
                IspisKlubova.DrugiKlub = klub2;
                IspisKlubova.TreciKlub = klub3;
                IspisKlubova.CetvrtiKlub = klub4;
                IspisKlubova.Visible = true;
            }
            izlazak = true;
            MessageBox.Show("Podaci uspješno spremljeni.", "Unos uspješan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TBNazivLige_Validated(object sender, EventArgs e)
        {
            TextBox TB = sender as TextBox;
            if (TB.Text.Length >= 3)
                UkloniError(TB);
        }

        private void TBNazivLige_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Naziv lige mora sadržavati minimalno tri znaka.", e);
        }
        private void ValidirajTextBox(TextBox TB, string Text, CancelEventArgs e)
        {
            if (TB.Text.Length < 3)
            {
                errorProvider1.SetError(TB, Text);
                e.Cancel = dozvoliPrelazak;
            }
        }
        private void UkloniError(Control C)
        {
            errorProvider1.SetError(C, "");
        }
        private void DTPOsnivanje_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as DateTimePicker).Value.Date > DateTime.Now.Date.AddDays(1))
            {
                errorProvider1.SetError(sender as DateTimePicker, "Datum nije validan.");
                e.Cancel = !dozvoliPrelazak;
            }
        }
        private void DTPOsnivanje_Validated(object sender, EventArgs e)
        {
            if ((sender as DateTimePicker).Value.Date <= DateTime.Now.Date)
                UkloniError(sender as DateTimePicker);
        }
        public bool SviPodaciUneseni()
        {
            foreach (Control C in groupBox1.Controls)
                if (errorProvider1.GetError(C) != "")
                    return false;
            return true;
        }

        private void TBDržava_Validated(object sender, EventArgs e)
        {
            TextBox TB = sender as TextBox;
            if (TB.Text.Length >= 3)
                UkloniError(TB);
        }

        private void TBDržava_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Naziv države mora sadržavati minimalno tri znaka.", e);
        }

        private void TBID_Validated(object sender, EventArgs e)
        {
            TextBox TB = sender as TextBox;
            if (Int32.TryParse(TBID.Text, out id))
                UkloniError(TB);
        }

        private void TBID_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "ID može sadržavati samo brojeve.", e);
        }

    }
}
