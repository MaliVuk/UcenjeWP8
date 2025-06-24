using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E15Nasljedivanje
{
    // u C# jedna klasa može nasljediti samo jednu nadklasu
    public class Predavac : Osoba
    {
        public string IBAN { get; set; } = "";
    }
}
