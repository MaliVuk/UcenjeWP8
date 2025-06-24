using System;

namespace Ucenje.E17Vjezbanje
{
    public class Program
    {
        public Zadatak1 Zad1 { get; set; }
        public Zadaca Zadaca { get; set; }


         public Program()
      
        {
            Zad1 = new Zadatak1();
            Zadaca = new Zadaca();
            Izbornik();
        }

        private void Izbornik()
        {
            Console.WriteLine("\n*******************************");
            Console.WriteLine("*********** IZBORNIK ************");
            Console.WriteLine("0. Izlaz");
            Console.WriteLine("1. Zbrajanje dvaju brojeva");
            Console.WriteLine("2. Izračun površine pravokutnika");
            Console.WriteLine("3. Provjera je li broj pozitivan, negativan ili nula");
            Console.WriteLine("4. Zbroj elemenata niza");
            Console.WriteLine("*******************************");

            OcitajOdabir();
        }

        private void OcitajOdabir()
        {
            Console.Write("Unesi redni broj programa: ");
            int odabir = int.Parse(Console.ReadLine());

            switch (odabir)
            {
                case 0:
                    Console.WriteLine("Doviđenja!");
                    return;
                case 1:
                    Zad1.Izvedi();
                    break;
                case 2:
                    Zadaca.IzracunajPovrsinu();
                    break;
                case 3:
                    Zadaca.ProvjeriBroj();
                    break;
                case 4:
                    Zadaca.ZbrojElemenataNiza();
                    break;
                default:
                    Console.WriteLine("Nepostojeći odabir.");
                    break;
            }

            Izbornik(); // Vraćanje na izbornik
        }

        // Pokretanje programa
        public static void Main(string[] args)
        {
            new Program(); // pokretanje izbornika
        }
    }
}
//2. Izračun površine pravokutnika:
//            Napiši program koji od korisnika traži da unese duljinu i širinu pravokutnika, a zatim izračunava i ispisuje površinu pravokutnika.
//        3. Provjera je li broj pozitivan, negativan ili nula:
//            Napiši program koji od korisnika traži da unese broj i ispisuje je li broj pozitivan, negativan ili nula.
//        4. Zbroj elemenata niza:
//            Napiši program koji deklarira niz cijelih brojeva, traži od korisnika da unese vrijednosti u niz, a zatim izračunava i ispisuje zbroj svih elemenata niza.
//        5. Prosjek ocjena:
//            Napiši program koji od korisnika traži da unese broj ocjena, a zatim i same ocjene.Program treba izračunati i ispisati prosjek ocjena.
//        6. Ispis Fibonaccijevog niza:
//            Napiši program koji od korisnika traži da unese broj n, a zatim ispisuje prvih n brojeva Fibonaccijevog niza (0, 1, 1, 2, 3, 5, 8...).
//        7. Preokret stringa:
//            Napiši program koji od korisnika traži da unese string, a zatim ispisuje taj string naopako(npr. "zdravo" postaje "ovardz").
//        8. Brojanje samoglasnika:
//            Napiši program koji od korisnika traži da unese string, a zatim prebrojava i ispisuje koliko samoglasnika ima u tom stringu.
//        9. Pretvorba temperature:
//            Napiši program koji od korisnika traži da unese temperaturu u Celzijusima i pretvara je u Fahrenheit(°F = °C* 9/5 + 32) ili obrnuto, ovisno o odabiru korisnika.
//        10. Sortiranje niza:
//            Napiši program koji deklarira niz cijelih brojeva, traži od korisnika da unese vrijednosti u niz, a zatim sortira niz uzlazno i ispisuje sortirani niz.
//        11. Kalkulator:
//            Napiši program koji od korisnika traži da unese dva broja i operaciju (+, -, *, /), a zatim izračunava i ispisuje rezultat.Koristi switch statement za odabir operacije.
