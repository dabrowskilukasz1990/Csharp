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
            string pass;
            while (true)
            {
                Console.WriteLine("Podaj Login: ");
                login = Console.ReadLine();

                Console.WriteLine("Podaj Hasło: ");
                pass = Console.ReadLine();

                if (login == "123" && pass == "123")
                {
                    Console.WriteLine("login i haslo prawidłowe\n");
                }
                else if (login != "123")
                {
                    Console.WriteLine("Login nieprawidłowy\n");
                }
                else if (pass != "123")
                {
                    Console.WriteLine("Haslo nieprawidlowe\n");
                }
                else
                    Console.WriteLine("Nieprawidlowy login i haslo\n");
            }










        }
    }
}
