using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenje
{
    internal class E01UlazIzlaz
    {
        //unutar klase radimo metodu
        public static void Izvedi()
        {


            Console.WriteLine("Pozdrav svijetu");

            Console.WriteLine("Isti red");

            Console.WriteLine("Osijek je\n SUPER");// \n je novi red

            Console.WriteLine("\t\t Ovo je uvučeno");

            Console.Write("Unesi svoje ime: ");

            //varijabla ime
            string ime = Console.ReadLine();

            Console.WriteLine("Unijeli ste {0}",ime);



        } //kraj metode





    }//kraj klase
}  //kraj imenskog prostora
