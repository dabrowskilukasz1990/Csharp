using System;

namespace Doktor_Samo_Zlo
{
    class Program
    {
        static void Main(string[] args)
        {
            string shield;

            Random fireBall = new Random();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}. Bajtek powinienes osłaniac nasze plecy ! \nUwazaj żeby Doktor Czyste Zlo nas nie zaatakowal !", i);
                Console.ReadLine();


                if (fireBall.Next(20) <= 10)
                {
                    Console.WriteLine("UWAZAJ! Leci kula ognia! Doktor Czyste Zlo atakuje!");

                    shield = "Woda";

                    Console.WriteLine("Tarcza: {0}", shield);
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Uff, cale szczescie Doktor Czyste Zlo nas nie zaatakowal.");

                    shield = "Brak tarczy";

                    Console.WriteLine("Tarcza: {0}", shield);
                    Console.ReadLine();
                }

            }
        }
    }
}