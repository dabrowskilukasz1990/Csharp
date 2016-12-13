using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESEL
{
    class Program
    {
        static void Main(string[] args)
        {
            char pesel;
            string peselChar;
            int[] waga = new int[10] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };


            Console.WriteLine("Podaj PESEL:");
            while (true)
            {
                
                pesel = (char)Console.Read();
                peselChar = pesel.ToString();
                Console.WriteLine(peselChar);
                break;

            }
            //Console.WriteLine("Podaj PESEL:");
            //pesel = (char) Console.Read();
            //peselChar = pesel.ToString();
            //Console.WriteLine(peselChar);
           
        }
    }
}
