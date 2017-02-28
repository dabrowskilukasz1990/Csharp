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
            Random number = new Random();

            // Obliczamy wartość funkcji f(x) = x3 - x2 + 2x - 1 na krańcach przedziału < 0 , 1 >;
            Console.WriteLine("Podaj liczbe A przydzialu (mniejsza)");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe B przydzialu (wieksza)");
            int b = int.Parse(Console.ReadLine());

            int c = (a + b) / 2; // srodek przydzialu
            //double xA = (a * a * a) - (a * a) + 2 * a - 1; //kraniec A przedzialu
            //double xB = (b * b * b) - (b * b) + 2 * b - 1; //kraniec B przedzialu
            //double xAxB = (xA + xB) / 2; // srodek przydzialu
            //double x0 = (xAxB * xAxB * xAxB) - (xAxB * xAxB) + 2 * xAxB - 1; // wartosc funkcji w miejscu zerowym
            int index = number.Next(a, b);
            Console.WriteLine("Srodek przydzialu: {0}", c);
            Console.WriteLine("Random {0}", index);

            while (true)
            {



                if (c == index)
                {
                    Console.WriteLine("Liczba {0} to środek przydzialu", index);
                }
                else if (c < index)
                {
                    int a = (a + b) / 2;
                    c = a;
                    
                    Console.WriteLine("Index został okrojony");
                }
                else if (c > index)
                {
                    c = b;
                    Console.WriteLine("bla");
                } 
                break;


            }
            //Console.WriteLine("Przydzial A: {0}", xA);
            //Console.WriteLine("Przydzial B: {0}", xB);

            //Console.WriteLine("Wartosc funkcji w srodku przydzialu: {0}", x0);

        }

    }
}

