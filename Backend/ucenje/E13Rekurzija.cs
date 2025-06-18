namespace Ucenje
{
    internal class E13Rekurzija
    {


        public static void Izvedi()
        {
            //Izvedi(); // ovo je LOŠA rekurzija
            Console.WriteLine(zbroj(100));
        }


        private static int zbroj(int i)
        {
            //uvjet prekida rekurzije
            if (i == 1)
            {
                return 1;
            }
            return i + zbroj(i - 1);
        }


    }
}
