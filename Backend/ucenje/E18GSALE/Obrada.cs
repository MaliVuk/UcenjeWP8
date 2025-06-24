using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18GSALE
{
    public class Obrada<T> // T je oznaka TYPE a može biti bilo koje slovo ili niz slova
    {

        public T? PredmetObrade { get; set; }

        [Obsolete("Ovo više nemoj koristiti")]
        public void Posao()
        {
            Console.WriteLine("Obrađujem {0}",PredmetObrade);
        }

    }
}
