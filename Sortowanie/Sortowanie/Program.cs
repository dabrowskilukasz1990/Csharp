using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Kasia", "Basia", "Ala", "Ola", "Stasia", "Helga", "Kunegunda", "Zdzisia" };

            var namesList = new List<string>();

            namesList.AddRange(names);
            Console.WriteLine("Bez sortowania:");
            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();


            namesList.Sort();
            Console.WriteLine("Posortowane:");
            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }



        }
    }
}
