namespace Ucenje
{
    internal class E11TryCatch
    {


        public static void Izvedi()
        {
            Console.WriteLine("Try Catch");



            int b = 0;

            /*
           // try blok se uvijek izvodi
           try
           {
               // ukoliko je bačena iznimka
              b = int.Parse(Console.ReadLine());

               // ona se hvata u catch
           }
           catch
           {
               //ovdje imam mogućnost obraditi bačenu iznimku
               Console.WriteLine("Niste unijeli broj");
           }
           Console.WriteLine(b+1);
           */


            while (true)
            {
                try
                {
                    Console.Write("Unesi broj: ");
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }
            }

            Console.WriteLine(b + 1);


            // Napisati program koji za dva unesena cijela broja ispisuje njihov zbroj

            int pb, db;

            while (true)
            {
                Console.Write("Unesi prvi broj: ");
                try
                {
                    pb = int.Parse(Console.ReadLine()); // break ide nakon metode koja uspješno prođe a mogla je baciti iznimku
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli prvi broj");
                }
            }



            while (true)
            {
                Console.Write("Unesi drugi broj: ");
                try
                {
                    db = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli drugi broj!");
                }
            }

            Console.WriteLine("Rezultat {0} + {1} = {2}", pb,db, pb+db);


            // dobro osiguranje unosa broja

            string unosniNizZnakova;
            while (true)
            {
                Console.Write("Unesi broj: ");
                unosniNizZnakova = Console.ReadLine().Trim();

                if (unosniNizZnakova.Length > 9)
                {
                    Console.WriteLine("Unijeli ste predugačak niz znakova");
                    continue;
                }
                // siguran sam da unosni niz znakova nema razmake prije ili poslije i nije duži od 9 znakova
                try
                {
                    b = int.Parse(unosniNizZnakova);
                    if (b > 10000)
                    {
                        Console.WriteLine("Uneseni broj je preveliki, unesite manji broj");
                        continue;
                    }
                    break;
                }
                catch 
                {
                    Console.WriteLine("Niste unije broj!");
                }

            }

            Console.WriteLine("Unesen je broj {0}", b);

            // nije dana puna sintaksa try catch, ostalo nakon OOP-a


        }


    }
}
