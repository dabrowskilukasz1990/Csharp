using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaliaKart
{
    class Deck
    {
        public List<Card> Cards;
        public Deck()
        {
            Cards = new List<Card>();

            for (int currentColor = 0; currentColor < 4; currentColor++)
            {
                for (int currentValue = 9; currentValue < 15; currentValue++)
                {
                    Card newCard;
                    if (currentColor == 0)//Karo
                    {
                        newCard = new Card(currentValue, "Karo");
                        Cards.Add(newCard);
                    }
                    if (currentColor == 1)//Kier
                    {
                        newCard = new Card(currentValue, "Kier");
                        Cards.Add(newCard);
                    }
                    if (currentColor == 2)//Trefl
                    {
                        newCard = new Card(currentValue, "Trefl");
                        Cards.Add(newCard);
                    }
                    if (currentColor == 3)//Pik
                    {
                        newCard = new Card(currentValue, "Pik");
                        Cards.Add(newCard);
                    }


                }

            }

        }

        public void WriteAllCards()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine(card.Description());
            }

        }
        public void AddNewCard()
        {
            Console.Clear();


            Console.WriteLine("Podaj wartość");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj kolor");
            string color = Console.ReadLine();

            Card NewCard = new Card(value, color);

            //int found = Find(value, color);
            //if (found == 1)
            //{
            //    Console.WriteLine("");
            //}
            //else
            //{
            //    Console.WriteLine();
            //}
            //Cards.Add(NewCard);
        }

        //public int Find(int value, string color)
        //{
        //    foreach (Card card in Cards)
        //    {
        //        if (color == card.Color && value == card.Value)
        //        {
        //            Console.WriteLine("Taka karta istnieje");
        //            return 1;
        //        }
        //    }
        //    return 0;
        //}
        public bool IsCardInList(Card newCard)
        {
            for (int currentCardIndex = 0; currentCardIndex < Cards.Count; currentCardIndex++)
            {
                if (newCard.Color == Cards[currentCardIndex])
                {

                }
            }
        }
    }


}
