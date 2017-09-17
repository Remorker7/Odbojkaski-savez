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
    public partial class KontrolaZaIspis : UserControl
    {
        public string PrviKlub
        {
            get { return LABKlub1.Text; }
            set { LABKlub1.Text = value; }
        }
        public string DrugiKlub
        {
            get { return LABKlub2.Text; }
            set { LABKlub2.Text = value; }
        }
        public string TreciKlub
        {
            get { return LABKlub3.Text; }
            set { LABKlub3.Text = value; }
        }
        public string CetvrtiKlub
        {
            get { return LABKlub4.Text; }
            set { LABKlub4.Text = value; }
        }
        public KontrolaZaIspis()
        {
            InitializeComponent();
        }
    }
}
