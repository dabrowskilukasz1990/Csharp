﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double waga, wzrost, bmi, bmi2;


            Console.WriteLine("podaj swoj wzrost (w cm): ");
            wzrost = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj swoja wage (w kg): ");
            waga = double.Parse(Console.ReadLine());

            waga = waga * 10000;

            bmi2 = (waga / (wzrost * wzrost));

            bmi = Math.Round(bmi2, 2);


            Console.WriteLine("Twoje BMI to: {0} \n", bmi) da;


            if (bmi <= 16.00)
            {
                Console.WriteLine("Twoj organizm jest wyglodzony !\n");
            }
            else if (bmi > 16.00 && bmi <= 17.00)
            {
                Console.WriteLine("Jestes wychudzony\n");

            }
            else if (bmi > 17.00 && bmi <= 18.50)
            {
                Console.WriteLine("Masz niedowage\n");
            }
            else if (bmi > 18.50 && bmi <= 25.00)
            {
                Console.WriteLine("Twoja waga jest prawidlowa, GRATULACJE !\n");
            }
            else if (bmi > 25.00 && bmi <= 30.00)
            {
                Console.WriteLine("Masz nadwage\n");
            }
            else if (bmi > 30.00 && bmi <= 35.00)
            {
                Console.WriteLine("Masz pierwszy stopien otylosci\n");
            }
            else if (bmi > 35.00 && bmi <= 40.00)
            {
                Console.WriteLine("Masz drugi stopien otylosci\n");
            }
            else
            {
                Console.WriteLine("Masz otylosc skrajna !!!\n");
            }
            Console.ReadLine();
        }
    }
}
