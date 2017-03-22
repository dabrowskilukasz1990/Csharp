using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciąg_Fibonacciego
{
    class Program
    {
        static int fib(int n)
        {
            if ((n == 1) || (n == 2))
            {
                return 1;
            }
            else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                n = int.Parse(Console.ReadLine());
            }

          

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(fib(n));
            }

        }
    }
}


