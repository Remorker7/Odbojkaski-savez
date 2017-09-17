using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca_2___Selmir_Hasanovic__16926_
{
    public class EntLiga : Liga
    {

        public int BrojKlubova
        {
            get { return brojKlubova; }
        } 

        string _entitet;
        public EntLiga(bool vrsta, bool aktivnost, bool entitet, List<Klub> k)
        {
            int broj = k.Count;
            if (broj != brojKlubova)
                throw new Exception();
            try
            {
                ValidacijaKlubova(k);
            }
            catch (DupliranjeException d)
            {
                MessageBox.Show(d.Message, "Pogrešan prefiks", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (entitet) _entitet = "Federacija BiH";
            else _entitet = "Republika Srpska";
            _vrsta = vrsta;
            _aktivnost = aktivnost;
            _klubovi = k;
        }
    }
}
