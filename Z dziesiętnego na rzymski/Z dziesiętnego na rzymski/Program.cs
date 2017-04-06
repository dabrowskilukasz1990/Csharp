using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_dziesiętnego_na_rzymski
{
    class Program
    {

        // Konwersja z dziesiętnego na rzymski lub odwrotnie
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj cyfre do konwersji, max do 9999:");
            int conv = int.Parse(Console.ReadLine());



            if (conv >= 1000)
            {
                while (true)
                {
                    int wynik = conv - 1000;
                    Console.Write("M");
                }

            }




            if (conv == 1)
            {
                Console.Write("I");
            }
            if (conv > 1 && conv < 5)
            {
                Console.Write("V");
            }
            if (conv > 5 && conv < 10)
            {
                Console.Write("X");
            }
            if (conv == 1)
            {
                Console.Write("L");
            }
            if (conv == 1)
            {
                Console.Write("C");
            }
            if (conv == 1)
            {
                Console.Write("D");
            }

        }
    }
}
