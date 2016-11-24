using System;

namespace Doktor_Samo_Zlo
{
    class Program
    {
        static void Main(string[] args)
        {
            string tarcza;

            Random kulaOgnia = new Random();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}. Bajtek powinienes osłaniac nasze plecy ! \nUwazaj żeby Doktor Czyste Zlo nas nie zaatakowal !", i);
                Console.ReadLine();


                if (kulaOgnia.Next(20) <= 10)
                {
                    Console.WriteLine("UWAZAJ! Leci kula ognia! Doktor Czyste Zlo atakuje!");

                    tarcza = "Woda";

                    Console.WriteLine("Tarcza: {0}", tarcza);
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Uff, cale szczescie Doktor Czyste Zlo nas nie zaatakowal.");

                    tarcza = "Brak tarczy";

                    Console.WriteLine("Tarcza: {0}", tarcza);
                    Console.ReadLine();
                }

            }
        }
    }
}
