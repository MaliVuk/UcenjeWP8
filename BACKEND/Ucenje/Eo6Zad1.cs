

namespace Ucenje
{
    internal class E06Zad1
    {

public static void Izvedi()

        {
            
        Console.WriteLine("E06Zad");
            int i = 0;

            int[] ocjene = new int[7];
            Console.Write("Upiši {0}. ocjenu:", i + 1);
            ocjene[i++]=int.Parse(Console.ReadLine());

            Console.Write("Upiši {0}. ocjenu:", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());
            Console.Write("Upiši {0}. ocjenu:", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());
            Console.Write("Upiši {0}. ocjenu:", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());
            Console.Write("Upiši {0}. ocjenu:", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());
            Console.Write("Upiši {0}. ocjenu:", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());
            Console.Write("Upiši {0}. ocjenu:", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            int suma = ocjene[0] + ocjene[1] + ocjene[2] + ocjene[3] + ocjene[4] + ocjene[5] + ocjene[6];

            Console.WriteLine(string.Join(",",ocjene));
            Console.WriteLine("Prosjek je:{0}",(double)suma/7);

          



        }



    }
}
