using System;

namespace Ucenje.E17Vjezbanje
{
    public class Zadaca
    {
        public Zadaca()
        {
        }

        public void IzracunajPovrsinu()
        {
            Console.Write("Unesi duljinu pravokutnika: ");
            double duljina = double.Parse(Console.ReadLine());

            Console.Write("Unesi širinu pravokutnika: ");
            double sirina = double.Parse(Console.ReadLine());

            double povrsina = duljina * sirina;
            Console.WriteLine("Površina pravokutnika je: " + povrsina);
        }

        public void ProvjeriBroj()
        {
            Console.Write("Unesi jedan broj: ");
            double broj = double.Parse(Console.ReadLine());

            if (broj > 0)
                Console.WriteLine("Broj je pozitivan.");
            else if (broj < 0)
                Console.WriteLine("Broj je negativan.");
            else
                Console.WriteLine("Broj je nula.");
        }
        public void ZbrojElemenataNiza()
        {
            Console.Write("Koliko elemenata ima niz? ");
            int n = int.Parse(Console.ReadLine());

            int[] niz = new int[n];
            int zbroj = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Unesi " + (i + 1) + ". broj: "); 
                niz[i] = int.Parse(Console.ReadLine());
                zbroj += niz[i];
            }

            Console.WriteLine("Zbroj elemenata niza je: " + zbroj);
        }

    }
}