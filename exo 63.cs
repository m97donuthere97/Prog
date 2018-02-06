using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo___63
{
    class Program
    {
        static int  y = 0;
        public static void Pile()
        {
            int x = 0;
            
            bool Mabool = true;
            Stack<int> Lapile = new Stack<int>();

            do
            {
                Console.SetCursorPosition(5, 5);
                Console.Write("Entrer un nombre : ");

                x = int.Parse(Console.ReadLine());

                   Lapile.Push(x);
                    ++y;
                Console.SetCursorPosition(5, 5);

                Console.WriteLine("Voulez vous continuer True/False ");
                Mabool = bool.Parse(Console.ReadLine());
                Console.Clear();

            } while (Mabool);
             
        }
        static void Main(string[] args)
        {
            Pile();
            Console.WriteLine($"La pile est d'une grosseur de {y} elements!");
            Console.ReadLine();
            
        }
    }
}
