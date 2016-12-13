using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorFunkcje
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Podaj dwie liczby\n \nPierwsza Liczba:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Druga Liczba:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik dodawania: {0}\n", Dodawanie(a, b));
            Console.WriteLine("Wynik odejmowania: {0}\n", Odejmowanie(a,b));
            Console.WriteLine("Wynik mnozenia: {0}\n", Mnozenie(a, b));
            Console.WriteLine("Wynik dzielenia: {0}\n", Dzielenie(a, b));


        }
        static int Dodawanie(int a, int b)
        {
            int wynik = a + b;
            return wynik;   
        }
        static int Odejmowanie(int a, int b)
        {
            int wynik = a - b;
            return wynik;
        }
        static int Mnozenie(int a, int b)
        {
            int wynik = a * b;
            return wynik;
        }
        static int Dzielenie(int a, int b)
        {
            int wynik = a / b;
            return wynik;
        }
    }
}
