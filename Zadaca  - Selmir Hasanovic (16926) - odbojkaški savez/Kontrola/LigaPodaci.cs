using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrola
{
    class LigaPodaci
    {
        public string NazivLige { get; set; }
        public string DatumOsnivanja { get; set; }
        public int BrojKola { get; set; }
        public string Država { get; set; }
        public int ID { get; set; }
        public LigaPodaci(string Naziv, string Datum, int Kola, string država, int id)
        {
            NazivLige = Naziv;
            DatumOsnivanja = Datum;
            BrojKola = Kola;
            Država = država;
            ID = id;
        }
    }
}
