using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj liczbe do bisekcji ?");

            int liczba = int.Parse(Console.ReadLine());
            int wynik = int.Parse(Console.ReadLine());

            if (liczba / 2 == wynik)
            {
                Console.WriteLine("Twoj wynik to {0}", wynik);
            }
            else
                Console.WriteLine("SSIJ");
        }
    }
}
