using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaawansowanyKalkulator
{
    class ObliczanieRabatu
    {
        public void Dzialanie()
        {
            double a, b;

            Console.WriteLine("Ile produkt kosztuje: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ile procent rabatu otrzymałeś: ");
            b = int.Parse(Console.ReadLine());
            
            double procent = (b / 100) * a;
            double wynik = a - procent;

            Math.Round(wynik, 3);


            Console.WriteLine("Musisz zapłacić: " + wynik);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
