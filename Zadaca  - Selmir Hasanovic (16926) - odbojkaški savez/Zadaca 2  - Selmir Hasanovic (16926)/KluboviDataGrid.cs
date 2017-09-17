using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Zadaca_2___Selmir_Hasanovic__16926_
{
    public partial class KluboviDataGrid : Form
    {
        BindingList<Klub> _klubovi;
        public KluboviDataGrid()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
        }

        private void učitajPodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try 
           {
               XmlDocument doc = new XmlDocument();
               doc.Load("c:\\klubovi.xml");
               foreach (XmlNode node in doc.DocumentElement.ChildNodes)
               {
                   string BOK, HOK, MOK, OK, SOK, ŽOK, naziv, mjesto, telefon, adresa, prefiks;
                   List<string> clanovi = new List<string>();
                   foreach (XmlNode n in node)
                   {
                       clanovi.Add(n.InnerText);
                   }
                   BOK = clanovi[0]; HOK = clanovi[1]; MOK = clanovi[2];
                   OK = clanovi[3]; SOK = clanovi[4]; ŽOK = clanovi[5];
                   naziv = clanovi[6]; mjesto = clanovi[7]; telefon = clanovi[8];
                   adresa = clanovi[9]; prefiks = clanovi[10];
                   dataGridView1.Rows.Add(BOK, HOK, MOK, OK, SOK, ŽOK, naziv, mjesto, telefon, adresa, prefiks);
               }
           }
           catch (XmlException ex) 
           { 
                MessageBox.Show(ex.ToString()); 
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("klubovi.dat", String.Empty);
            FileStream fs = new FileStream("klubovi.dat", FileMode.Open);
            List<Klub> lista = new List<Klub>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells.Count == 10 && item.Cells[1].Value != null && item.Cells[2].Value != null &&
                    item.Cells[3].Value != null && item.Cells[4].Value != null &&
                    item.Cells[5].Value != null && item.Cells[6].Value != null &&
                    item.Cells[7].Value != null && item.Cells[8].Value != null &&
                    item.Cells[9].Value != null && item.Cells[10].Value != null)
                {
                    List<string> pomocna = new List<string>();
                    pomocna.Add(item.Cells[1].Value.ToString());
                    pomocna.Add(item.Cells[2].Value.ToString());
                    pomocna.Add(item.Cells[3].Value.ToString());
                    pomocna.Add(item.Cells[4].Value.ToString());
                    pomocna.Add(item.Cells[5].Value.ToString());
                    pomocna.Add(item.Cells[6].Value.ToString());
                    pomocna.Add(item.Cells[7].Value.ToString());
                    pomocna.Add(item.Cells[8].Value.ToString());
                    pomocna.Add(item.Cells[9].Value.ToString());
                    pomocna.Add(item.Cells[10].Value.ToString());
                    lista.Add(new Klub(pomocna[0] != "false", pomocna[1] != "false", pomocna[2] != "false", pomocna[3] != "false",
                        pomocna[4] != "false", pomocna[5] != "false", pomocna[6], pomocna[7], pomocna[8], pomocna[9]));
                }
            }
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, lista);
            MessageBox.Show("Uspješno snimljeno u binarnu datoteku.");
            fs.Close();
        }

    }
}
