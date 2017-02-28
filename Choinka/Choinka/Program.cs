using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile poziomow ma miec choinka ?");
            int level = int.Parse(Console.ReadLine());
            int whitespace = level - 1;
            int star = 0;


            if (level >= 1)
            {
                for (int i = 0; i < level; i++)
                {
                    for (int j = 0; j < whitespace; j++)
                    {
                        Console.Write(" ");
                    }
                    whitespace--;
                    Console.Write("/");
                    for (int k = 0; k < star; k++)
                    {
                        Console.Write("*");
                    }
                    star += 2;
                    Console.WriteLine("\\");

                }
            }
        }
    }
}
