using System.Text;
namespace Ucenje.E16Polimorfizam
{
    public class Polaznik : Osoba
    {
        public string? Telefon { get; set; }

        public override void Greska(string poruka)
        {
            //todo: Završi
            // pojam tehnički dug: Technical debt
        }

        public override string Pozdravi()
        {
            return new StringBuilder().Append("Dobar dan ")
                .Append(Ime).Append(", polazniče ").Append(Telefon).ToString();
        }
    }
}
