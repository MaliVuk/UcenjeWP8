using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt
{
    // Klasa je opisnik objekta -> naučiti napamet
    internal class Osoba
    {
        // klasa se sastoji od svojstava
        // princip učahurivanja (OOP princip)
        // Nazivi svojstava se pišu velikim početnim  slovom
        public int Sifra { get; set; }
        public string? Ime { get; set; } // ? znači da svojstvo može biti null
        public string Prezime { get; set; } = ""; // = "" će postaviti prazno, neće biti null
        public DateTime? DatumRodenja { get; set; }



        // klasa se sastoji od metoda
        // ova metoda nije static!
        public void IspisiImeIPrezime()
        {
            // ključna riječ this se odnosi na klasu u kojoj se nalazim
            Console.WriteLine(this.Ime + " " + Prezime);
        }

        // statične metode se pozivaju na klasi a ne statične na objektu
        
        public static void Primjer()
        {
            Console.WriteLine("Primjer statične metode");
        }

    }
}
