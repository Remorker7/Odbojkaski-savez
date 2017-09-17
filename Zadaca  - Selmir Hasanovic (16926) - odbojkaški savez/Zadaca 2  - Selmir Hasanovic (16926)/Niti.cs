using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Zadaca_2___Selmir_Hasanovic__16926_
{
    public partial class Niti : Form
    {
        Thread nit1, nit2;
        int brojac = 0;
        string brojSekundi;
        string lokacija;
        Stopwatch stoperica;
        public Niti()
        {
            InitializeComponent();
        }

        private void pocniBrojanje()
        {
            stoperica = Stopwatch.StartNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IzaberiFolder();
            try
            {
                nit1 = new Thread(new ThreadStart(traziFajlStart));
                nit2 = new Thread(new ThreadStart(pocniBrojanje));
                nit1.Start();
                nit2.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            brojDokumenata.Text = Convert.ToString(brojac);
            System.Threading.Thread.Sleep(500);
            stoperica.Stop();
            brojSekundi = stoperica.ElapsedMilliseconds.ToString();
            vrijemePretrage.Text = brojSekundi;
            brojDokumenata.Text = Convert.ToString(brojac);
        }
        public delegate void myDelegate(int anInteger, string aString);
        void traziFajlStart()
        {
            traziFajl(lokacija);
        }
        public void dodajUListu(string[] fajlovi, string ekstenzija, string l)
        {  
            if (this.listView1.InvokeRequired)
            {
                this.Invoke(new InsertIntoListDelegate(dodajUListu), fajlovi, ekstenzija, l);
            }
            else
            {
                if (brojac1 < brojac2)
                {
                    string[] red = { fajlovi[brojac1], l, ekstenzija};
                    var listViewItem = new ListViewItem(red);
                    listView1.Items.Add(listViewItem);
                    brojac1++;
                    listView1.Refresh();
                }
            }
        }
        delegate void InsertIntoListDelegate(string[] fajlovi, string e, string l);
        int brojac1 = 0, brojac2;
        void traziFajl(String pocetniFolder)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(lokacija);
                brojac = Directory.GetFiles(lokacija, "*.txt", SearchOption.AllDirectories).Length;
                brojac += Directory.GetFiles(lokacija, "*.xml", SearchOption.AllDirectories).Length;
                string[] fajlovi = Directory.GetFiles(lokacija, "*.txt");
                brojac1 = 0;
                brojac2 = fajlovi.Length;
                dodajUListu(fajlovi, ".txt", lokacija);
                fajlovi = Directory.GetFiles(lokacija, "*.xml");
                brojac1 = 0;
                brojac2 = fajlovi.Length;
                dodajUListu(fajlovi, ".xml", lokacija);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void IzaberiFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lokacija = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            brojDokumenata.Text = Convert.ToString(brojac);
            nit1.Abort();
            System.Threading.Thread.Sleep(500);
            stoperica.Stop();
            brojSekundi = stoperica.ElapsedMilliseconds.ToString();
            vrijemePretrage.Text = brojSekundi;
        }
    }
}
