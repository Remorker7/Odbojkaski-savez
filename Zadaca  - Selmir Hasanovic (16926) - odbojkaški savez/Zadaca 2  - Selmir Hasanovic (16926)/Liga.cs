using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_2___Selmir_Hasanovic__16926_
{
    public abstract class Liga
    {
        public const int brojKlubova = 4;
        public List<Klub> _klubovi;
        public bool _vrsta, _aktivnost;
        public void ValidacijaKlubova(List<Klub> klubovi)
        {
            foreach(Klub k in klubovi)
            {
                if (k.Prefiks == "ŽOK" && _vrsta == true)
                    throw new DupliranjeException("Nije moguće u mušku ligu dodati klub sa prefiksom ŽOK.");
                if (k.Prefiks == "MOK" && _vrsta == false)
                    throw new DupliranjeException("Nije moguće u žensku ligu dodati klub sa prefiksom MOK.");
            }
        }
    }
}
