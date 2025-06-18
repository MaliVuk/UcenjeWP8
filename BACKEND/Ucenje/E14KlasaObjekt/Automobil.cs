using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt
{
    public class Automobil
    {
        public int Sifra { get; set; }
        public string Marka { get; set; } = "";

        public bool Automatik { get; set; }

        public DateTime? DatumProizvodnje { get; set; }

        public decimal Cijena { get; set; }




    }
}
