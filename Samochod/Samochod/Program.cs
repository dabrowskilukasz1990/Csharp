using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samochod
{
    class Program
    {
        static void Main(string[] args)
        {
            PojemnikSamochod Auta = new PojemnikSamochod();

            string input;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Wybierz z listy");
                Console.WriteLine("2. Dodaj samochód");
                Console.WriteLine("0. Wyjdź");
                input = Console.ReadLine();

                if (input == "1")
                {
                    Auta.PokazWszystkieSamochody();
                }
                if (input == "2")
                {
                    Console.Clear();
                    Auta.DodajSamochod();
                }
                if (input == "0")
                {
                    break;
                }
            }
        }
    }
}