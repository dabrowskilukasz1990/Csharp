using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotoLotek
{
    class Program
    {
        static void Traf(int los, int lotek)
        {
            if (los == lotek)
            {

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 6 liczb w zakresie od 1 do 50:");

            Random lotto = new Random();
            
            List<int> totolotek = new List<int>();


            for (int i = 1; i < 7; i++) // Podajemy liczby od 1 do 50.
            {
                Console.WriteLine("Liczba {0}", i);
                totolotek.Add(int.Parse(Console.ReadLine()));
                Console.Clear();
            }


            totolotek.Sort();
            Console.WriteLine("Twoje obstawione liczby to: "); // Wyświetla obstawione liczby.
            foreach (int lotek in totolotek)
            {
                
                Console.WriteLine(lotek);

            }

            
            Console.WriteLine("Liczby wylosowane przez komputer to: "); // Wyświetla wylosowane liczby przez komputer.
            for (int i = 1; i < 7; i++)
            {
                int los = lotto.Next(1, 51);

                Console.WriteLine(los);
            }


        }
    }
}


