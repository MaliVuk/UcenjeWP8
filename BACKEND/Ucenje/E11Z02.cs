

namespace Ucenje
{
    internal class E11Z02
    {
        public static void Izvedi()
        {
            Console.WriteLine("Hristina Zadatak");
            // program unosi ime osobe i ispisuje uneseno ime

            string ime = Pomocno.UcitajString("unesi ime osobe");
            if (!Pomocno.IsCijeliBroj(ime))
            {
                Console.WriteLine(ime);
            }

        }

    }
}
