namespace Ucenje.E16Polimorfizam
{
    public class Program
    {
        public Program() 
        {
            Console.WriteLine("Polimorfizam");

            Osoba[] osobe = new Osoba[5];

            osobe[0] = new Polaznik() { Ime = "Pero", Telefon = "258" };
            osobe[1] = new Predavac() { Ime = "Karla", IBAN = "HR52565" };
            osobe[2] = new Predavac() { Ime = "Lota", IBAN = "HR232323" };
            osobe[3] = new Polaznik() { Ime = "Ivana", Telefon = "34756" };
            osobe[4] = new Predavac() { Ime = "Josip", IBAN = "HR32323" };


            Ispisi(osobe);


            var p = new Polaznik();
            p.Log("Problem kod prijave");

            var r = new Ravnatelj();
            r.Log("Ravnatelj je izuzet");

            


        }





        public static void Ispisi(Osoba[] osobe)
        {
            foreach(Osoba o in osobe)
            {
                // ovo je polimorfizam
                Console.WriteLine(o.Pozdravi());
            }
        }



    }
}
