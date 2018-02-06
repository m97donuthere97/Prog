using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Dice
{
    class Program
    {
        static int cpt1 = 0, cpt2 = 0, cpt3 = 0, cpt4 = 0, cpt5 = 0, cpt6 = 0;
        static Random rnd = new Random();

        public static bool Verif(List<int> DePipe)
        {


            if ((cpt1 * 100 / DePipe.Count) >= 10 && (cpt1 * 100 / DePipe.Count) <= 20)
            {
                if ((cpt2 * 100 / DePipe.Count) >= 10 && (cpt2 * 100 / DePipe.Count) <= 20)
                {
                    if ((cpt3 * 100 / DePipe.Count) >= 10 && (cpt3 * 100 / DePipe.Count) <= 20)
                    {
                        if ((cpt4 * 100 / DePipe.Count) >= 10 && (cpt4 * 100 / DePipe.Count) <= 20)
                        {
                            if ((cpt5 * 100 / DePipe.Count) >= 10 && (cpt5 * 100 / DePipe.Count) <= 20)
                            {
                                if ((cpt6 * 100 / DePipe.Count) >= 10 && (cpt6 * 100 / DePipe.Count) <= 20)
                                {
                                    return true;
                                }
                                else
                                    return false;
                                    
                            }
                            else
                                return false;
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;

        }


        public static List<int> Dice(int NbLancer)
        {            

            int DiceFace;
            List<int> ListeLancer = new List<int>();
            for (int x = 0; x < NbLancer; ++x)
            {
                
                DiceFace = rnd.Next();
                ListeLancer.Add(DiceFace);
                
                switch(DiceFace)
                {
                    case 1:
                        cpt1++;
                        continue;
                    case 2:
                        cpt2++;
                        continue;
                    case 3:
                        cpt3++;
                        continue;
                    case 4:
                        cpt4++;
                        continue;
                    case 5:
                        cpt5++;
                        continue;
                    case 6:
                        cpt6++;
                        continue;
                }
            }
            return ListeLancer;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Combien de lancer de dée efectuer /n");
            int x = int.Parse(Console.ReadLine());
            bool depiper = Verif(Dice(x));
            Console.WriteLine($"Est-ce que le dé est pipe : {depiper}");
        }
    }
}
