using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        public static void Krakatoa(int n)
        {
           
            if (n == 0)
            {
                Console.WriteLine("Vos message ont tout ete afficher!");
               
            }

            else
            {
                Console.WriteLine("hello");
               Krakatoa(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nb message a afficher : ");
            int q = int.Parse(Console.ReadLine());
          
            Krakatoa(q);
            Console.ReadLine();
        }
    }
}

