using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_int
{
    class Program
    {
        //static int minimum;
        //static int maximum;
        static double moyenne;
        static double SommeTotal;

        public static void Tableau()
           
        {
            SommeTotal = 0;
            double[] tableau = new double[] { 1,2,3,4,5,6,7,8,9,10};
            for (int i = 0; i <= tableau.Length -1; ++i)
            {
                SommeTotal += tableau[i];
            }
            Console.WriteLine($"SommeTotal : {SommeTotal}");
            moyenne = SommeTotal / tableau.Length;
            Console.WriteLine($"Moyenne : {moyenne}");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Tableau(); 
            
        }
    }
}
