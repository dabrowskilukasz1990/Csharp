using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerContainer FlowerCont = new FlowerContainer();

            string inputChar;

            while (true)
            {
                Console.WriteLine("1. Stworz kwiatek.");
                Console.WriteLine("2. Usun kwiatek.");
                Console.WriteLine("0. Exit");


                Console.WriteLine("---------------");

                FlowerCont.ViewAllFlowers();
                inputChar = Console.ReadLine();
                if (inputChar == "1")
                {
                    FlowerCont.CreateNewFlower();
                }
                if (inputChar == "2")
                {
                    FlowerCont.RemoveFlower();
                }
                if (inputChar == "0")
                {
                    break;
                }
            }

        }
    }
    class FlowerContainer
    {
        List<Flower> Flowers = new List<Flower>();
        public FlowerContainer()
        {
            Flower Tulip = new Flower("Tulipan", "Zielony", 20, "Tulipa L.");
            Flowers.Add(Tulip);
            Flower Rose = new Flower("Roza", "Czerwony", 40, "Erysipelas");
            Flowers.Add(Rose);
            Flower Daisy = new Flower("Stokrotka", "Niebieski", 100, "Bellis perennis");
            Flowers.Add(Daisy);
        }
        public void ViewAllFlowers()
        {
            int iter = 1;
            foreach (Flower flower in Flowers)
            {
                Console.WriteLine(iter.ToString() + ". " + flower.Description());
                iter++;
            }
        }
        public void RemoveFlower()
        {
            Console.Clear();
            ViewAllFlowers();

            Console.WriteLine("Wpisz indeks kwiata ktory chcesz usunac z listy");
            int index = int.Parse(Console.ReadLine());
            Flowers.RemoveAt(index - 1);
        }

        public void CreateNewFlower()
        {
            Console.Clear();
            Console.WriteLine("Wpisz nazwe kwiatka");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj kolor kwiatka");
            string color = Console.ReadLine();
            Console.WriteLine("Podaj rozmiar kwiatka");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj gatunek kwiatka");
            string spiecies = Console.ReadLine();

            Flower newFlower = new Flower(name, color, height, spiecies);

            Flowers.Add(newFlower);
        }
    }

    class Flower
    {
        public string Name;
        public string Color;
        public int Height;
        public string Spieces;

        public Flower(string name, string color, int height, string spiecies)
        {
            Name = name;
            Color = color;
            Height = height;
            Spieces = spiecies;
        }

        public string Description()
        {
            return Name + " " + Color + " " + Height + " " + Spieces;
        }

    }
}
