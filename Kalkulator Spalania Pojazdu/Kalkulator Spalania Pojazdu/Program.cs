using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_Spalania_Pojazdu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ile twój samochód pali 'L' na 100 KM");
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine("Ile przejechałeś KM ?");
                int km = int.Parse(Console.ReadLine());

                int result = km * l / 100;

                Console.WriteLine("Twój samochód spalił {0} L paliwa", result);
                Console.ReadLine();

                Console.WriteLine("Chcesz obliczyć jeszcze raz ?");
                string answer = Console.ReadLine();

                if (answer == "NIE" || answer == "nie" || answer == "Nie")
                {
                    break;
                }

            }




        }
    }
}
