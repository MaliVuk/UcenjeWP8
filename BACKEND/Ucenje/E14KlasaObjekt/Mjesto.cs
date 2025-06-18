namespace Ucenje.E14KlasaObjekt
{
    // POCO - Plain Old C# Object
    public class Mjesto
    {
        public string? PostanskiBroj { get; set; }
        public string? Naziv { get; set; }

        public Zupanija? Zupanija { get; set; }
    }
}