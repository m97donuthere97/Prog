using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        
        public static int Bezymianny(int ninit, int pow)
        {

            if (pow <= 1)
            {
                
                return ninit;
            }

            else
            {
                
                return ninit * Bezymianny(ninit , pow - 1);
            }
        }
        static void Main(string[] args)
        {
             Console.Write("Nb  a Calculer : ");
             int q = int.Parse(Console.ReadLine());
             Console.Write("\nPuissance \n");
             int d = int.Parse(Console.ReadLine());
            
            int resultat = Bezymianny(q , d);
            Console.WriteLine(resultat);
            Console.ReadLine();
        }
    }
}
