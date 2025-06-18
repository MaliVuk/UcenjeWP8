

using System;

namespace Ucenje
{
    internal class EZAD
    {
        public static void Izvedi()
        {
            Console.Write("Unesi podatke u formatu npr. 3*7: ");
            string unos = Console.ReadLine();

            string[] delovi = unos.Split('*');

            if (delovi.Length != 2 ||
                !int.TryParse(delovi[0], out int redovi) ||
                !int.TryParse(delovi[1], out int kolone))
            {
                Console.WriteLine("Greška u unosu. Mora biti u formatu npr. 3*7");
                return;
            }

            int[,] tablica = new int[redovi, kolone];

            for (int i = 0; i < redovi; i++)
                for (int j = 0; j < kolone; j++)
                    tablica[i, j] = (i + 1) * (j + 1);

            Console.WriteLine("\nCiklične permutacije redova:\n");

            for (int rotacija = 0; rotacija < redovi; rotacija++)
            {
                for (int i = 0; i < redovi; i++)
                {
                    int stvarniRed = (i + rotacija) % redovi;

                    for (int j = 0; j < kolone; j++)
                        Console.Write(tablica[stvarniRed, j].ToString().PadLeft(4));

                    Console.WriteLine();
                }

                Console.WriteLine(); // razmak između rotacija
            }
        }
    }
}