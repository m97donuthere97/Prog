using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devinerunnombre
{
    class Program
    {
        public static void FeliciterOuPas(bool nombreTrouve, int nombreADeviner)
        {
            Console.Clear();
            if (nombreTrouve == true)

                Console.WriteLine("Bravo , tu as gagner, un vrai champion!");
            else
                Console.WriteLine("Too bad , Git gud, Ez , go back to tutorial !");

            Console.WriteLine($"Nombre : {nombreADeviner}");
        }

        public static bool DemanderNombreADeviner(int nombreEssais, int NbDevine)
        {
            
            if (nombreEssais != 0)
            {
                Console.Write("Choississez Nombre : ");
               int NbChoisi = int.Parse(Console.ReadLine());

                //////////////////////////////////////////////////////////////////
                if (NbChoisi == NbDevine)
                    return true;
                else if (NbChoisi > NbDevine)
                    Console.WriteLine("Le nombre est plus bas");
                else
                    Console.WriteLine("Le nombre est plus haut");

                //////////////////////////////////////////////////////////////////
            }
            if (nombreEssais == 0)
            {
                return false;
            }

            else
            {
               return  DemanderNombreADeviner(nombreEssais - 1, NbDevine);
            }
        }

        public static int GenererAleatoire(int[] intervalle)
        {
            Random rnd = new Random();
            
            int Devine = rnd.Next(intervalle[0], intervalle[1]+1);
            
            return Devine;
        }

        public static int[] DemanderIntervalle()
        {
            Console.Write("\n Choissisez une interval , De : 1 à ");
            int I = int.Parse(Console.ReadLine());
            int[] intervalle = new int[2];
            intervalle[0] = 1;
            return intervalle;
        }

        public static int DemanderNombreEssais()      
        {
            Console.Write("En combien d'essaie voulez vous trouver le nombre : ");
            int NbEssaie = int.Parse(Console.ReadLine());
            return NbEssaie;
        }
        
        static void Main(string[] args)
        {
            int QstNbEssaie = DemanderNombreEssais();
             int[] interval = DemanderIntervalle();
             int Divene = GenererAleatoire(interval);
            bool ValEssaie =  DemanderNombreADeviner(QstNbEssaie, Divene);
            FeliciterOuPas(ValEssaie, Divene);
        }
    }
}
