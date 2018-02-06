using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursif_carrer
{
    class Program
    {
        static int total;
        public static void puissance( int Carrer)
        {
            if (Carrer == 0)
            {

                return;
                Console.WriteLine($"Le total est de : {total}");
                Console.ReadLine();
            }

            else
            {
                total = total + (Carrer * Carrer);
                puissance(Carrer - 1);
            }
                

        }
        static void Main(string[] args)
        {
            int nbcarrer;
            Console.WriteLine("Entrer un nombre");
            nbcarrer = int.Parse(Console.ReadLine());
            puissance(nbcarrer);
        }
    }
}
