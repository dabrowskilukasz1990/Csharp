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
            int poziomy=int.Parse(Console.ReadLine());
            int spacje = poziomy - 1;
            int gwiazdki=0;
            

            if (poziomy>=1)
            {
                for (int i = 0; i < poziomy; i++)
                {
                    for (int j = 0; j < spacje; j++)
                    {
                        Console.Write(" ");
                    }spacje--;
                    Console.Write("/");
                    for (int k = 0; k < gwiazdki; k++)
                    {
                        Console.Write("*");
                    }gwiazdki += 2;
                    Console.WriteLine("\\");
                   
                }
            }
        }
    }
}
