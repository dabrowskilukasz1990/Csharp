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
            string[] alfabet; // 32
            Console.WriteLine("Podaj tekst do zaszyfrowania: ");
            tekst = Console.ReadLine();
            Console.WriteLine("Podaj o ile przesunąc tekst: ");
            przesun = int.Parse(Console.ReadLine());

            for (int i = 0; i < tekst.Length; i++)
            {
                tekst.Length = 2;
            }

        }
    }
}
