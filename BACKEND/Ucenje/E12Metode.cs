namespace Ucenje
{
    internal class E12Metode
    {

        // metoda je organizacijska jedinica koda koja služi određenoj svrsi
        // cilj rada s metoda: Write once, use everywhere
        // static  - označava da se metoda može izvesti na klasi
        public static void Izvedi()
        {

            Console.WriteLine("Metode");

            // Rad s metodama se sastoji od dva djela
            // 1. Tijelo metode
            // 2. Poziv metode


            // poziv metode
            Tip1();
            for (int i = 0; i < 10; i++)
            {
                Tip1();
            }

            Tip2(2);

            Tip2(7);

            Tip2(2, 3); // po završetku metode nema poveratne vrijednost

            Tip3(); // po završetku metode vraćena vrijednost nije nikome dodjeljena

            //int i = Tip2(8);   -> ovo ne može

            string s = Tip3();

            Console.WriteLine(s);

            Console.WriteLine(prim(5));
            Console.WriteLine(prim(100000));
   
            for(int i = 1; i <= 100; i++)
            {
 
                if (prim(i))
                {
                    Console.WriteLine(i);
                }
                
            }

            // Napiši program koji ispisuje zbroj dvaju brojeva
            Console.WriteLine(ucitajCijeliBroj("Unesi 1. broj") + ucitajCijeliBroj("Unesi 2. broj"));


        } // kraj metode Izvedi


        // Metoda tipa 1
        // ne prima parametar i ne vraća vrijednost
        // tijelo metode
        static void Tip1()
        {
            Console.WriteLine("Ispis iz metode tipa 1 koja je bez načina pristupa - vidljiva samo u klasi");
            Console.WriteLine("*******");
            Console.WriteLine("Edunova");
            Console.WriteLine("*******");
        }



        // Metoda tipa 2
        // prima parametre, ne vraća vrijednost
        private static void Tip2(int i)
        {
            Console.WriteLine("Primio sam broj {0}",i);
        }

        // potpis metode:
        // način pristupa
        // static ili ne (prazno)
        // tip podatka (void ili neki tip)
        //  -> naziv
        //  -> lista parametara

        //method overloading
        private static void Tip2(int i, int j)
        {
            Console.WriteLine("Zbroj je {0}", i + j);
        }


        // Metoda tipa 3
        // ne prima parametre, vraća vrijednost
        protected static string Tip3()
        {
            Console.WriteLine("Izvodim metodu tip3");
            return "Web programiranje";
        }



        // Metoda tipa 4
        // prima parametre, vraća vrijednost
        // Da li je primljeni broj prim/prome/prosti ili ne
        public static bool prim(int broj)
        {
            // matematički princip hipoteze
            for(int i = 2; i < broj; i++)
            {
                // za 5
                if(broj % i == 0)
                {
                    return false; // short cuircuting
                    // prekidanjem metode prekida se i petlja
                }
            }


            return true;

        }


        public static int ucitajCijeliBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pokušajte ponovo");
                }
            }
        }


    } // kraj klase
}
