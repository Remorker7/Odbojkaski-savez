using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_2___Selmir_Hasanovic__16926_
{
    class PremLiga : Liga
    {
        public int BrojKlubova
        {
            get { return brojKlubova; }
        } 

        string _država;
        public PremLiga(bool vrsta, bool aktivnost, string država, List<Klub> k)
        {
            int broj = k.Count;
            if (broj != brojKlubova)
                throw new Exception();
            try
            {
                ValidacijaKlubova(k);
            }
            catch (Exception)
            {
                throw;
            }
            _država = država;
            _vrsta = vrsta;
            _aktivnost = aktivnost;
            _klubovi = k;
        }
    }
}
