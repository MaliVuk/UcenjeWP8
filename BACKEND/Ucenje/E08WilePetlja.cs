using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08WilePetlja
    {


        public static void Izvedi()
        {
            Console.WriteLine("while petlja");

            while (true)
            {
                Console.WriteLine("Ispis iz beskonačne petlje nakon čega je break");
                break;

            }

            Console.WriteLine("*****************************");

            int i = 10;

            while (i < 10)
            {

                Console.WriteLine(i++);
            }
            Console.WriteLine("*****************************");

            i = 0;
            while (i < 10)
            {
                Console.WriteLine(++i);

                Console.WriteLine("*****************************");

                i = 0;
                int j = 1;
                while (i < 10 && j==1)
                
                {
                    Console.WriteLine(i);


                }

                while (i > 10)
                {
                    while (j == 1)
                    {
                        goto labela;

                    }
                }
            labela:
                Console.WriteLine("Gotov");
            }    


        }
    }
}
