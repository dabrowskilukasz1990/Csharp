using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string m = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                for (int z = 0; z < n; z++)
                {
                    Console.Write(m);
                }
                Console.Write("\r\n");
            }
        }
    }
}
