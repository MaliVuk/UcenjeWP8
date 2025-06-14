using System;
using System.Threading.Channels;

namespace Ucenje
{
    internal class E07ForPetlja
    {
        public static void Izvedi()
        {
            Console.WriteLine("E07 for");

            // Ispis bez petlje (nepotrebno, ali ostavljeno ako želiš pokazati razliku)
            Console.WriteLine("Hrvatska-Češka 5:1");
            Console.WriteLine("Hrvatska-Češka 5:1");
            Console.WriteLine("Hrvatska-Češka 5:1");
            Console.WriteLine("Hrvatska-Češka 5:1");
            Console.WriteLine("Hrvatska-Češka 5:1");
            Console.WriteLine("Hrvatska-Češka 5:1");
            Console.WriteLine("Hrvatska-Češka 5:1");
            Console.WriteLine("Hrvatska-Češka 5:1");
            Console.WriteLine("Hrvatska-Češka 5:1");
            Console.WriteLine("Hrvatska-Češka 5:1");

            Console.WriteLine("********************");

            // Ispis s petljom
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hrvatska-Češka 5:1");

            }
            Console.WriteLine("********************");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("(0).", i + 1);
            }
            Console.WriteLine("********************");

            Console.WriteLine(100 / 2 * 100 + 100 / 2);
            Console.WriteLine(100 / 2 * (100 + 1));
            int suma = 0;
            for (int i = 0; i < 100; i++)
            {

                suma = suma + i + 1;
            }
            Console.WriteLine(suma);

            Console.WriteLine("********************");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*********************");

            for (int i = 1; i <= 90; i += 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********************");

            for (int i = 79; i <= 123; i++)

            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine("*********************");

            string grad = "Osijek";
            for (int i = 0; i < grad.Length; i++)
            {
                Console.WriteLine(grad[i]);


            }
            Console.WriteLine("*********************");
            for (int i = 1; i<= 10; i++) {
             for(int j = 1; j <=10;j++)
             {
                    Console.Write("{0}",i*j);
             }
                Console.WriteLine();
            }
            //dz


            Console.WriteLine("*********************");
            for (int i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                if (i == 7)
                {
                    break;
                }
            Console.WriteLine(i);
            }

            Console.WriteLine("*********************");


        }

    }
}
        