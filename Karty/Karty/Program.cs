using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Napisz program do obsługi talii kart, który będzie miał nastepujące funkcje:
//- tworzenie talii (lista obiektów)
//- tasowanie talii
//- wyciąganie karty z talii
//- wybieranie losowej karty z talii



namespace Karty
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            

            while (true)
            {
                deck.ViewAllCards();
                Console.WriteLine("---------------------------------------");
                
                Console.WriteLine("1. Wyciągnij kartę z talii:");
                Console.WriteLine("2. Tasuj talie");
                Console.WriteLine("3. Losuj jedną kartę z talii");
                Console.WriteLine();
                Console.WriteLine("0. Wyjdz");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    deck.RemoveCards();
                }

                if (input == "2") deck.RandomCards(); 
                if (input == "3") deck.TakeCard();
                if (input == "0") break;
                Console.Clear();
            }
        }
    }
    class Card
    {
        public int Value;
        public string Color;


        public Card(int value, string color)
        {

            Value = value;
            Color = color;

        }

        public string Description()
        {
            return Value.ToString() + " " + Color;

        }
    }
    class Deck
    {
        List<Card> Cards = new List<Card>();


        public Deck()
        {
            for (int color = 0; color < 4; color++)
            {
               
                for (int value = 2; value < 15; value++)
                {
                    Card newCard;
                    if (color == 0)
                    {
                        newCard = new Card(value, "Kier");
                        Cards.Add(newCard);
                    }
                    if (color == 1)
                    {
                        newCard = new Card(value, "Karo");
                        Cards.Add(newCard);
                    }
                    if (color == 2)
                    {
                        newCard = new Card(value, "Pik");
                        Cards.Add(newCard);
                    }
                    if (color == 3)
                    {
                        newCard = new Card(value, "Trefl");
                        Cards.Add(newCard);
                    }
                }
            }
        }
        public void ViewAllCards()
        {
            foreach (var card in Cards)
            {
                Console.WriteLine(card.Description());

            }
        }

        public void ViewAllCardsToRemove()
        {

            int count = 1;
            foreach (var card in Cards)
            {
                Console.WriteLine(count.ToString() + ". " + card.Description());
                count++;
            }

        }

        public void RemoveCards()
        {
            Console.Clear();
            ViewAllCardsToRemove();

            Console.WriteLine("Wpisz indeks karty którą chcesz chcesz wyciągnąć: ");
            Console.WriteLine(Cards[3]);
            int index = int.Parse(Console.ReadLine());

            Cards.RemoveAt(index - 1);
        }


        public void TakeCard()
        {
            Console.Clear();
            Random randomCards = new Random();

            int rnd = randomCards.Next(1, Cards.Count);

            Console.WriteLine(Cards[rnd]);

            Console.ReadLine();


        }
        public void RandomCards()
        {
            Console.Clear();



            Console.ReadLine();
        }
    }
}
