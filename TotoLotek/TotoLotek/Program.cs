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


            for (int i = 1; i < 7; i++)
            {

                Console.WriteLine("Liczba {0}", i);
                totolotek.Add(int.Parse(Console.ReadLine()));

            }

            foreach (int lotek in totolotek)
            {
                int los = lotto.Next(1, 3);
                bool wynik = true;

                if (lotek == los)
                {
                    Console.WriteLine("---" + los);
                    Console.WriteLine("Trafiłeś");


                }
                else
                {
                    Console.WriteLine("---" + los);
                    Console.WriteLine("Nie trafiłeś");

                }
                
                Console.WriteLine(lotek);

            }

            

            Console.WriteLine("-----------------");
            
            foreach (int wynik in totolotek)
            {
                int los = lotto.Next(1, 51);
                Console.WriteLine(wynik);
                Console.WriteLine(los);
            }


        }
    }
}
