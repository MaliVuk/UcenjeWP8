
namespace Ucenje.E14KlasaObjekt
{
    internal class Program
    {

        // 5. vrsta metode je konstruktor
        // Naziv mora biti jedna nazivu klase
        public Program()
        {
            Console.WriteLine("Klasa/objekt");

            // Objekt je pojavnost (instanca) klase -> ovo naučiti napamet

            // Osoba (primjetiti veliko slovo O) je klasa
            // osoba (primjetiti malo slovo 0) je objekt (instanca, varijabla)
            Osoba osoba = new Osoba(); // pozvali smo konstruktor od klase Osoba (new)

            // postavljanje vrijednosti za svojstva objekta
            osoba.Sifra = 1; // pozvao si setter (učahurivanje)
            //osoba.Ime = "Pero"; namjerno ime ostavljamo null jer ono može biti null (? smo stavili)
            osoba.Prezime = "Perić";
            osoba.DatumRodenja = new DateTime(1980, 12, 7);


            // ponoviti ću s uzimanjem vrijednosti od naših korisnika
            //osoba.Sifra = Pomocno.UcitajCijeliBroj("Unesi šifru osobe"); //usporediti s linijom 20
            //osoba.Prezime = Pomocno.UcitajString("Unesi prezime osobe");
            //osoba.DatumRodenja = new DateTime(
            //    Pomocno.UcitajCijeliBroj("Unesi godinu rođenja"),
            //    Pomocno.UcitajCijeliBroj("Unesi mjesec rođenja"),
            //    Pomocno.UcitajCijeliBroj("Unesi dan rođenja")
            //    );

            // korištenje vrijednosti svojstava
            Console.WriteLine(osoba.Prezime); // pozvao si getter (učahurivanje)

            Console.WriteLine(osoba.Ime); // ispiše "" prazno
            Console.WriteLine(osoba.Ime ?? "nije postavljeno"); // ime može biti null, stoga ?? znači što će biti ako je null. Konkretno, ako je ime null ispiši nije postavljeno

            // ne statična metoda se zova s objekta
            osoba.IspisiImeIPrezime();

            //osoba.Primjer(); // ne možeš pozvati statičnu metodu s objekta

            Osoba.Primjer(); // statičnu metodu pozivamo s klase

            //Osoba.IspisiImeIPrezime(); // na klasi se ne može pozvati ne statična metoda


            Osoba[] osobe = new Osoba[3];

            // skraćeni oblik postavljanja vrijednosti svojstava
            osobe[0] = new Osoba() { 
                Ime = "Marija", 
                Prezime = "Kat", 
                Sifra = 2, 
                DatumRodenja = new DateTime(1982, 1, 2) 
            };

            osobe[1] = new() { Ime = "Ante" };

            osobe[2] = osoba;

            foreach(Osoba o in osobe){
                Console.WriteLine(o.Ime);
            }


        }


    }
}
