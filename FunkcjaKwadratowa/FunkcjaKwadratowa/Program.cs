using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkcjaKwadratowa
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            Console.WriteLine("Podaj współczynnik A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik B");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik C");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Delta to:");
            delta = (b * b) - (4 * a * c);
            Console.WriteLine(delta);

            if (delta > 0)
            {

                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Rozwiazanie x1: {0}, Rozwiazanie x2: {1}", x1, x2);
            }
            else if (delta == 0)
            {

                x1 = -b / (2 * a);

                Console.WriteLine("Rozwiązanie x1: {0}", x1);
            }
            else
            {
                Console.WriteLine("Brak rozwiazan.");
            }
        }
    }
}
