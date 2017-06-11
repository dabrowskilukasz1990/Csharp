using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaawansowanyKalkulator
{
    class DzialaniaProste
    {
        public void Question()
        {

            Console.WriteLine("1.Dodawanie");
            Console.WriteLine("2.Odejmowanie");
            Console.WriteLine("3.Mnożenie");
            Console.WriteLine("4.Dzielenie");
            string inputChar2 = Console.ReadLine();
            Console.Clear();
            if (inputChar2 == "1")
            {
                Dodawanie();
            }
            if (inputChar2 == "2")
            {
                Odejmowanie();
            }
            if (inputChar2 == "3")
            {
                Mnozenie();
            }
            if (inputChar2 == "4")
            {
                Dzielenie();
            }
        }

        public void Dodawanie()
        {
            int a, b;
            Console.WriteLine("Podaj liczbę pierwszą");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę pierwszą");
            b = int.Parse(Console.ReadLine());

            int wynik = a + b;

            Console.WriteLine("Wynik to: " + wynik);

            Console.ReadKey();

            Console.Clear();
        }

        public void Odejmowanie()
        {
            int a, b;
            Console.WriteLine("Podaj liczbę pierwszą");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę pierwszą");
            b = int.Parse(Console.ReadLine());

            int wynik = a - b;

            Console.WriteLine("Wynik to: " + wynik);

            Console.ReadKey();

            Console.Clear();
        }

        public void Mnozenie()
        {
            int a, b;
            Console.WriteLine("Podaj liczbę pierwszą");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę pierwszą");
            b = int.Parse(Console.ReadLine());


            int wynik = a * b;

            Console.WriteLine("Wynik to: " + wynik);

            Console.ReadKey();

            Console.Clear();

        }

        public void Dzielenie()
        {
            int a, b;
            Console.WriteLine("Podaj liczbę pierwszą");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę pierwszą");
            b = int.Parse(Console.ReadLine());

            int wynik = a / b;

            Console.WriteLine("Wynik to: " + wynik);

            Console.ReadKey();

            Console.Clear();
        }
    }
}
