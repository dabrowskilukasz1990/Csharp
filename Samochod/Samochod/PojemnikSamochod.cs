using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samochod
{
    class PojemnikSamochod
    {
        List<Samochod> Samochody = new List<Samochod>();

        public PojemnikSamochod()
        {
            Samochod Lamborghini = new Samochod("Lamborghini", "Aventador", 2016);
            Samochody.Add(Lamborghini);
            Samochod Ferrari = new Samochod("Ferrari", "488 GTB", 2015);
            Samochody.Add(Ferrari);
            Samochod PaganiZonda = new Samochod("Pagani Zonda", "R", 2009);
            Samochody.Add(PaganiZonda);
        }

        public void DodajSamochod()
        {

            Console.WriteLine("Podaj markę");
            string marka = Console.ReadLine();
            Console.WriteLine("Podaj model");
            string model = Console.ReadLine();
            Console.WriteLine("Podaj rok produkcji");
            int rokprodukcji = int.Parse(Console.ReadLine());

            Samochod DodajAuto = new Samochod(marka, model, rokprodukcji);

            Samochody.Add(DodajAuto);

        }
        
        public void PokazWszystkieSamochody()
        {
            int iteracja = 1;
            foreach (Samochod Auto in Samochody)
            {
                Console.WriteLine(iteracja.ToString() + ". " + Auto.Description());
                iteracja++;
            }
        }


    }
}
