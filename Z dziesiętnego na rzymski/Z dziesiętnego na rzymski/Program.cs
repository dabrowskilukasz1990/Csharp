using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_dziesiętnego_na_rzymski
{
    class Program
    {

        // Konwersja z arabskiego na rzymski
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj cyfre do konwersji, max do 9999:");
            int conv = int.Parse(Console.ReadLine());


            while (true)
            {
                if (conv >= 1000)
                {
                    Console.Write("M");
                    conv = conv - 1000;
                }
                else if (conv >= 500 && conv <= 1000)
                {
                    Console.Write("D");
                    conv = conv - 500;
                }
                else if (conv >= 100 && conv <= 500)
                {
                    Console.Write("C");
                    conv = conv - 100;
                }
                else if (conv >= 50 && conv <= 100)
                {
                    Console.Write("L");
                    conv = conv - 50;
                }
                else if (conv >= 10 && conv <= 50)
                {
                    Console.Write("X");
                    conv = conv - 10;
                }
                else if (conv >= 5 && conv <= 10)
                {
                    Console.Write("V");
                    conv = conv - 5;
                }
                else if (conv >= 1 && conv <= 5)
                {
                    Console.Write("I");
                    conv = conv - 1;
                }
                else if (conv == 0)
                {
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
