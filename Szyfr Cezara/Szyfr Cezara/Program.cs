using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfr_Cezara
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            int przesun;

            Console.WriteLine("Podaj tekst do zaszyfrowania: ");
            tekst = Console.ReadLine();
            Console.WriteLine("Podaj o ile przesunąc tekst: ");
            przesun = int.Parse(Console.ReadLine());

            for (int i = 0; i < tekst.Length; i++)
            {
                int szyfr = tekst.ElementAt(i);
                int x;

                if (szyfr >= 65 && szyfr <= 90)
                {
                    x = 65 + (szyfr + przesun - 65) % 26;
                }
                else if (szyfr >= 97 && szyfr <= 122)
                {
                    x = 97 + (szyfr + przesun - 97) % 26;
                }
                else
                {
                    x = 32;
                }

                char znakzm = (char)x;
                Console.Write("" + znakzm);


            }
            Console.ReadLine();



        }

    }
}
