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
            Random color = new Random();

            
            string[] shoes = new string[6];

            shoes[0] = "Niebieski";
            shoes[1] = "Rozowy";
            shoes[2] = "Fioletowy";
            shoes[3] = "Czarny";
            shoes[4] = "Zolty";
            shoes[5] = "Czerwony";

            while (true)
            {

                int index = color.Next(0, 6);

                Console.WriteLine("Twój kolor butów na dzisiaj:");
                Console.WriteLine(shoes[index]);
                Console.ReadLine();
            }






        }
    }
}
