using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Euklidesa
{
    class Program
    {
        // Algorytm Euklidesa
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            int pierwsza = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            int druga = int.Parse(Console.ReadLine());

            Console.WriteLine();
            nwd(pierwsza, druga);


        }
        public static int nwd(int pierwsza, int druga)
        {
            int trzecia;
            while (druga != 0)
            {
                trzecia = pierwsza % druga;
                pierwsza = druga;
                druga = trzecia;


                Console.WriteLine("{0} / {1} reszta {2}", pierwsza, druga, trzecia);

            }
            return pierwsza;



        }
    }
}


