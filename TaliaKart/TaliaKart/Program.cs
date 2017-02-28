using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaliaKart
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); //1
            string input;

            while (true)
            {
                deck.WriteAllCards();
                Console.WriteLine("1. Dodaj nową karte:");
                Console.WriteLine("2. Wyjdz");

                input = Console.ReadLine();
                if (input == "1") deck.AddNewCard();
                if (input == "2") break;
                Console.Clear();
            }
        }


        
  
    }
}
