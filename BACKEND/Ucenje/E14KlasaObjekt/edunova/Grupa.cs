namespace Ucenje.E14KlasaObjekt.edunova
{
    public class Grupa
    {
        public int Sifra { get; set; }
        public string Naziv { get; set; } = "";
        public Smjer Smjer { get; set; } = new Smjer();
        public string? Predavac { get; set; }
        public Polaznik[]? Polaznici { get; set; }
    }
}
