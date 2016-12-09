using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string haslo;
            while (true)
            {
                Console.WriteLine("Podaj Login: ");
                login = Console.ReadLine();

                Console.WriteLine("Podaj Hasło: ");
                haslo = Console.ReadLine();

                if (login == "123" && haslo == "123")
                {
                    Console.WriteLine("login i haslo prawidłowe\n");
                }
                else if (login != "123")
                {
                    Console.WriteLine("login nieprawidłowy\n");
                }
                else if (haslo != "123")
                {
                    Console.WriteLine("haslo nieprawidlowe\n");
                }
                else
                    Console.WriteLine("Nieprawidlowy login i haslo\n");
            }










        }
    }
}
