using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaawansowanyKalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            DzialaniaProste Proste = new DzialaniaProste();
            ObliczanieRabatu Rabat = new ObliczanieRabatu();
            ObliczPole Pole = new ObliczPole();

            while (true)
            {

                Console.WriteLine("Co chciałbyś zrobić ?");
                Console.WriteLine("1. Działania proste na dwóch liczbach (dodwanie, odejmowanie, mnożenie, dzielenie)");
                Console.WriteLine("2. Obliczanie Rabatu");
                Console.WriteLine("3. Oblicz pole");
                Console.WriteLine("0. Zakończ");

                string inputChar = Console.ReadLine();

                Console.Clear();
                if (inputChar == "1")
                {
                    Proste.Question();
                }
                if (inputChar == "2")
                {
                    Rabat.Dzialanie();

                }
                if (inputChar == "3")
                {
                    Pole.Question();

                }
                if (inputChar == "0")
                {
                    break;
                }
            }
        }
    }
}
