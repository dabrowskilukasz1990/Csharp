using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odwrócona_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> liczby = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                liczby.Add(int.Parse(Console.ReadLine()));
            }

            liczby.Reverse();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(liczby[i]);
            }
        }
    }
}
