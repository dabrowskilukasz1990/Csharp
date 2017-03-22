using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapałki
{
    class Program
    {
        static void Main(string[] args)
        {
            char text = String.Split(Console.ReadLine());

            if (text == 0)
            {
                Console.WriteLine("1");
            }
            else if (text == 1)
            {
                Console.WriteLine("0");
            }

            Console.WriteLine(text);
        }
    }
}
