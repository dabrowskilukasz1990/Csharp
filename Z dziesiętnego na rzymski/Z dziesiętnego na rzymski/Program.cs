using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_dziesiętnego_na_rzymski
{
    class Program
    {

        // Konwersja z dziesiętnego na rzymski lub odwrotnie
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj cyfre do konwersji, max do 9999:");
            char conv = char.Parse(Console.ReadLine());
            int wynik;

            while (conv == 0)
            {
                if (conv >= 1000)
                {
                    Console.Write("M");
                    wynik = conv - 1000;
                }
                else if (conv >= 500 && conv <= 1000)
                {
                    Console.Write("D");
                    wynik = conv - 500;
                }
                else if (conv >= 100 && conv <= 500)
                {
                    Console.Write("C");
                    wynik = conv - 100;
                }
                else if (conv >= 50 && conv <= 100)
                {
                    Console.Write("L");
                    wynik = conv - 50;
                }
                else if (conv >= 10 && conv <= 50)
                {
                    Console.Write("X");
                    wynik = conv - 10;
                }
                else if (conv >= 5 && conv <= 10)
                {
                    Console.Write("V");
                    wynik = conv - 5;
                }
                else if (conv >= 1 && conv <= 5)
                {
                    Console.Write("I");
                    wynik = conv - 1;
                }
                else if (conv == 0)
                {
                    break;
                }
            }
           


            //if (conv == 1)
            //{
            //    Console.Write("I");
            //}
            //if (conv > 1 && conv < 5)
            //{
            //    Console.Write("V");
            //}
            //if (conv > 5 && conv < 10)
            //{
            //    Console.Write("X");
            //}
            //if (conv == 1)
            //{
            //    Console.Write("L");
            //}
            //if (conv == 1)
            //{
            //    Console.Write("C");
            //}
            //if (conv == 1)
            //{
            //    Console.Write("D");
            //}

        }
    }
}
