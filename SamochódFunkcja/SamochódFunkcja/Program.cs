using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamochódFunkcja
{
    class Program
    {
        static void Main(string[] args)
        {
            //Auto spala 10 litrow na 100km
            bool jechac = true;
            bool tankowac = true;
            bool przejechacKota = true;
            
            
            Console.WriteLine("Co chcesz zrobić ?");
            Console.ReadLine();
            if (jechac == true)
            {
                Console.WriteLine("Ile chcesz kilometrow jechac ?");
                int km = int.Parse(Console.ReadLine());
                Console.WriteLine("Przejechales {0}km", km);
            }

            Console.WriteLine("Stan twojego baku:{0}", Tankowanie(20));
        }
        static int StanBaku(int litrow)
        {
            int litry;
            return litrow;
        }
        static int Tankowanie(int litry)
        {
            int iloscLitrow;
            Console.WriteLine("Wlasnie podjechales na stacje, wpisz ile litrow tankujesz");
            litry = int.Parse(Console.ReadLine());
            
            return litry;
        }
        static int Droga(int km)
        {
            
            for (int droga = 800; droga <= 0; droga -= 10)
            {
                Console.WriteLine("Przejechales {0} km", droga);
            }
       

            return km;
        }
    }
}
