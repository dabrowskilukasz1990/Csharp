using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samochod
{
    class Samochod
    {
        public string Marka;
        public string Model;
        public int RokProdukcji;

        public Samochod(string marka, string model, int rokprodukcji)
        {
            Marka = marka;
            Model = model;
            RokProdukcji = rokprodukcji;
        }

        public string Description()
        {
            return Marka + " " + Model + " " + RokProdukcji;
        }

    }
}
