using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
        static double taux;
        static double montant;
        static bool inverse;
        static double MontantT;
   
        public static double convertir(double taux, double montant, bool inverse)
        {

            if (inverse)
                MontantT = montant / taux;
            else
                MontantT = montant * taux;
            return MontantT;
        }
        static void Main(string[] args)
        {
            Console.Title = ("Conversion monetaire");
            bool Continuer = false;
           
            do
            {
                Console.Clear();
                Console.WriteLine("Taux de change : ");
                taux = double.Parse(Console.ReadLine());
                Console.WriteLine("Montant : ");
                montant = double.Parse(Console.ReadLine());
                Console.WriteLine("inverse (True/False)");
                inverse = bool.Parse(Console.ReadLine());
                convertir(taux, montant, inverse);
                Console.Clear();
                Console.WriteLine($"Montant = {MontantT}\n\n");
                Console.ReadLine();
                Console.WriteLine("Voulez vous effectuer d'autre conversion ? (True/false)");
                Continuer = bool.Parse(Console.ReadLine());
            } while (Continuer);
        }
    }
}
