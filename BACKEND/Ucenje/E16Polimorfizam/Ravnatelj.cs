namespace Ucenje.E16Polimorfizam
{
    public class Ravnatelj : Osoba
    {
        public override void Greska(string poruka)
        {
          
        }

        public override void Log(string poruka)
        {
            Console.WriteLine(poruka);
        }

        public override string Pozdravi()
        {
            return "";
        }
    }
}
