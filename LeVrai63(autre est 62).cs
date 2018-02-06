using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVrai63
{
    class Program
    {
        static Random rnd = new Random();
        static string[] Maxim = new string[2];
        static string[] Wiliam = new string[2];
        static string[] Denis = new string[2];
        static string[] Antony = new string[2];
        static string[] Tidjer = new string[2];


        public static void Init()
        {
            Console.WriteLine($" ________________________________________");
            Console.WriteLine($"|        Client      |        Donut      |");
            Console.WriteLine($"|____________________|___________________|");
            Console.WriteLine($"|                                        |");
            Console.WriteLine($"|                                        |");
            Console.WriteLine($"|                                        |");
            Console.WriteLine($"|                                        |");
            Console.WriteLine($"|                                        |");
            Console.WriteLine($"|                                        |");
            Console.WriteLine($"|                                        |");
            Console.WriteLine($"|                                        |");
            Console.WriteLine($"|                                        |");
            Console.WriteLine($"|                                        |");
            Console.WriteLine($"|________________________________________|");
        }

        public static void Client()
        {
                         /**/ /**/ /**/ /**/ /**/ /**/ /**/ /**/
                        /**/  Maxim[0] = "Maxim";          /**/
                       /**/  Maxim[1] = "Argent";         /**/        
                      /**/                               /**/    
                     /**/  Wiliam[0] = "Wiliam";        /**/
                    /**/  Wiliam[1] = "PasDargent";    /**/
                   /**/                               /**/
                  /**/  Denis[0] = "Denis";          /**/
                 /**/  Denis[1] = "PasDargent";     /**/
                /**/                               /**/
               /**/  Antony[0] = "Antony";        /**/
              /**/  Antony[1] = "Argent";        /**/
             /**/                               /**/    
            /**/  Tidjer[0] = "Tidjer" ;       /**/
           /**/  Tidjer[1] = "PasDargent";    /**/
          /**/ /**/ /**/ /**/ /**/ /**/ /**/ /**/
        }

        public static void NextClient(string[] LeClient)
        {
            bool AsTuEuTonBeignet;
            int LeFacteurChance = rnd.Next(1, 10);
            if (LeClient[1] == "Argent")
                AsTuEuTonBeignet = true;
            else if (LeFacteurChance == 5)
                AsTuEuTonBeignet = true;
            else
                AsTuEuTonBeignet = false;

            Console.WriteLine($"|       {LeClient[0]}                {AsTuEuTonBeignet}");
            

           

        }

        static void Main(string[] args)
        {
            Init();
            Client();
            Console.SetCursorPosition(0, 4);
            NextClient(Maxim);
            NextClient(Wiliam);
            NextClient(Denis);
            NextClient(Antony);
            NextClient(Denis);
            Console.SetCursorPosition(0, 15);
        }
    }
}
