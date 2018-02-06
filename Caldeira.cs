using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
///Il s'agit du numero 22 des exercises a remettre pour lundi 29 Janvier !
/// </summary>



namespace Hello
{
    class Program
    {
        static string Volcan;
        public static void  Caldeira(int n)
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("");
            if (n == 0)
            {
                Console.WriteLine("Vos message ont tout ete afficher!");
                
            }

            else
            {
                Console.WriteLine($"{Volcan}");
                 Caldeira(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("nb de fois a ecrire : ");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("Quel message voulez vous faire afficher");
            Volcan = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Vos message vont s'afficher");
            System.Threading.Thread.Sleep(2000);

            Caldeira(q);
            Console.ReadLine();
        }
    }
}

