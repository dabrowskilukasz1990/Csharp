using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotoLotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 6 liczb w zakresie od 1 do 50:");

            Random lotto = new Random();

            List<int> totolotek = new List<int>();
            List<int> sprawdzenie = new List<int>();


            for (int i = 1; i < 7; i++) // Podajemy liczby od 1 do 50.
            {
                Console.WriteLine("Liczba {0}", i);
                totolotek.Add(int.Parse(Console.ReadLine()));
                sprawdzenie.Add(lotto.Next(1, 50));
                Console.Clear();

                totolotek.Sort();
                sprawdzenie.Sort();

            }



            Console.WriteLine("Twoje obstawione liczby to: "); // Wyświetla obstawione liczby.
            foreach (int lotek in totolotek)
            {

                Console.WriteLine(lotek);

            }

            Console.WriteLine("Liczby wylosowane przez komputer to: "); // Wyświetla wylosowane liczby przez komputer.
            foreach (int spr in sprawdzenie)
            {
                Console.WriteLine(spr);
            }

            Console.WriteLine("=====");



            int traf = 0;
            foreach (int spr in sprawdzenie) // Sprawdzenie czy została trafiona jakaś liczba.
            {

                foreach (int lotek in totolotek)
                {

                    if (spr == lotek)
                    {
                        traf++;
                    }

                }

            }
            Console.WriteLine("Ilość trafionych liczb: " + traf);


        }
    }
}