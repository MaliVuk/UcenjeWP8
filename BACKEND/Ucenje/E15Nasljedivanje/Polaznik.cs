namespace Ucenje.E15Nasljedivanje
{
    // Klasa Polaznik nasljeđuje sva javna i zaštićena svjostva klase Osoba i svih drugi klasa koje Osoba nasljeđuje
    public class Polaznik : Osoba
    {
        public string Telefon { get; set; } = "";


        // prepisivanje metoda
        // method override
        public override string ToString()
        {
            return base.ToString() + " " + Telefon;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            
            var p = (Polaznik)obj; // var p = obj as Polaznik;

            if (p.Ime.Equals(Ime) && 
                p.Prezime.Equals(Prezime) &&
                p.Telefon.Equals(Telefon)) return true;

            return false;
        }

    }
}
