using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomy
{
    class Program
    {
        static void Main(string[] args)
        {
            Random kolor = new Random();

            
            string[] buty = new string[6];

            buty[0] = "Niebieski";
            buty[1] = "Rozowy";
            buty[2] = "Fioletowy";
            buty[3] = "Czarny";
            buty[4] = "Zolty";
            buty[5] = "Czerwony";

            while (true)
            {

                int index = kolor.Next(0, 6);

                Console.WriteLine("Twój kolor butów na dzisiaj:");
                Console.WriteLine(buty[index]);
                Console.ReadLine();
            }






        }
    }
}
