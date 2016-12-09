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
            string pesel;
            int suma;
            int[] waga = new int[10] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            

            Console.WriteLine("Podaj PESEL:");
            pesel = Convert.ToInt32(Console.Read());

            for (int i = 0; i < pesel.Length; i++)
            {
                suma = pesel * waga[i];
                Console.WriteLine(pesel);

            }
           
        }
    }
}
