using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaawansowanyKalkulator
{
    class ObliczPole
    {
        public void Question()
        {
            Console.WriteLine("1. Pole kwadratu.");
            Console.WriteLine("2. Pole prostokąta.");
            Console.WriteLine("3. Pole trójkąta.");
            Console.WriteLine("4. Pole okręgu.");

            string inputChar = Console.ReadLine();
            Console.Clear();
            if (inputChar == "1")
            {
                Kwadrat();
            }
            else if (inputChar == "2")
            {
                Prostokat();
            }
            else if (inputChar == "3")
            {
                Trojkat();
            }
            else if (inputChar == "4")
            {
                Okrąg();
            }

        }
        public void Kwadrat()
        {
            Console.WriteLine("Podaj długość boku: ");
            int a = int.Parse(Console.ReadLine());

            int wynik = a ^ 2;

            Console.WriteLine("Pole kwadratu to: " + wynik);

            Console.ReadKey();
            Console.Clear();
        }

        public void Prostokat()
        {
            Console.WriteLine("Podaj bok długość boku A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj bok długość boku B: ");
            int b = int.Parse(Console.ReadLine());

            int wynik = a * b;

            Console.WriteLine("Pole prostokąta to: " + wynik);

            Console.ReadKey();
            Console.Clear();
        }

        public void Trojkat()
        {
            Console.WriteLine("Podaj bok długość boku A: ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokość H: ");
            double h = int.Parse(Console.ReadLine());

            double wynik = (a * h) / 2;

            Console.WriteLine("Pole trójkąta to: " + wynik);

            Console.ReadKey();
            Console.Clear();
        }
        public void Okrąg()
        {
            Console.WriteLine("Podaj promień koła: ");
            int r = int.Parse(Console.ReadLine());

            double pi = 3.14;
            double wynik = Math.Round(pi, 2) * r * r;

            Console.WriteLine("Pole koła to: " + wynik);

            Console.ReadKey();
            Console.Clear();
        }

    }
}
