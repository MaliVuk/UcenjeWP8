namespace Ucenje
{
    internal class Pomocno
    {

        /// <summary>
        /// Učitava i vraća string s konzole. 
        /// Prikazuje poruku korisniku i zahtijeva unos koji nije prazan.
        /// Ako je unos prazan, ispisuje poruku o obaveznom unosu i ponavlja unos.
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <returns>Uneseni string koji nije prazan.</returns>
        public static string UcitajString(string poruka)
        {
            string s;
            for (; ; )
            {
                Console.Write(poruka + ": ");
                s = Console.ReadLine().Trim();
                if (s.Length > 0)
                {
                    return s;
                }
                Console.WriteLine("Obavezan unos!");
            }
        }

        /// <summary>
        /// Provjerava je li zadani string cijeli broj.
        /// </summary>
        /// <param name="s">String koji se provjerava.</param>
        /// <returns>True ako je string cijeli broj, inače false.</returns>
        public static bool IsCijeliBroj(string s)
        {
            try
            {
                int.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Učitava cijeli broj s konzole.
        /// Prikazuje poruku korisniku i zahtijeva unos cijelog broja.
        /// Ako unos nije cijeli broj, ispisuje poruku o pogrešci i ponavlja unos.
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <returns>Uneseni cijeli broj.</returns>
        public static int UcitajCijeliBroj(string poruka)
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
    }
}
