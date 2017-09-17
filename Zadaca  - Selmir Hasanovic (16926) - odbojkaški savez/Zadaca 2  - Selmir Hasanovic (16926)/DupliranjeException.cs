using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_2___Selmir_Hasanovic__16926_
{
    class DupliranjeException : Exception
    {
        public DupliranjeException() { }
        public DupliranjeException(string poruka) : base(poruka) { }
        public DupliranjeException(string poruka, Exception izuzetak) : base(poruka, izuzetak) { }
    }
}
