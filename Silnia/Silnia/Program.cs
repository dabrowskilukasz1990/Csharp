using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę do silni:");

            int N = int.Parse(Console.ReadLine());
            int wynik = 1;
            for (int i = 1; i <= N; i++)
            {
                
                wynik = wynik * i;
                
            }

            Console.WriteLine(wynik);
        }
    }
}
