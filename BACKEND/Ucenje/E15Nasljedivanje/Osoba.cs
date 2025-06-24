using System.Text;

namespace Ucenje.E15Nasljedivanje
{
    // https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-9.0
    // Apstraktna klasa je ona klasa koja nema implementaciju (instancu)
    // Služi da bi se nasljedila i proširila
    public abstract class Osoba : Object // SVE KLASE naljsđuju klasu Object htjele one to ili ne
    {
        public int Sifra { get; set; }
        public string Ime { get; set; } = "";
        public string Prezime { get; set; } = "";
        public string? Email { get; set; }

        public override string ToString()
        {
           // return Ime + " " + Prezime;
           return new StringBuilder().Append(Ime).Append(' ').Append(Prezime).ToString();
        }

    }
}
