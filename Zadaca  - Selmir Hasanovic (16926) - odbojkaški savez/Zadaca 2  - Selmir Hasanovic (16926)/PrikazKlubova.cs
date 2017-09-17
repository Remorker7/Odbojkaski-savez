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
    public partial class PrikazKlubova : Form
    {
        public PrikazKlubova(BindingList<Klub> klubovi)
        {
            InitializeComponent();
            treeView1.Nodes.Add("Klubovi");
            foreach(Klub k in klubovi)
            {
                treeView1.Nodes[0].Nodes.Add(k.Prefiks + " " + k.Naziv + " (" + k.Mjesto + ")");
                ListViewItem lvi = new ListViewItem(k.Prefiks + " " + k.Naziv);
                lvi.SubItems.Add(k.Mjesto);
                lvi.SubItems.Add(k.Adresa);
                lvi.SubItems.Add(k.Telefon);
                listView1.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KluboviDataGrid kdg = new KluboviDataGrid();
            kdg.ShowDialog();
        }
    }
}
