using System;
using System.Collections.Generic;
namespace Exo_61
{   
    class Program
    {      
        static Random rnd = new Random();
        public static List<int> generateur()
        {         
            List<int> Maliste = new List<int>();
            for (int x = 0; x < 25; ++x)
            {
                Maliste.Add(rnd.Next(1, 255));
            }
            Maliste.Sort();
            return Maliste;
        }
        static void AfficherBonsElements()
        {
            var MyList = generateur();
            
            for (int i = 0; i < 25; ++i)
            {
                for (int x = 0; x < 255; x += 2)
                {
                    bool Mabool = false;
                    if (MyList[i] == x)
                        Mabool = true;
                    if (Mabool)
                        Console.WriteLine($"Element : {i + 1} = {MyList[i]} : Paire");                                 
                }
                for (int x = 1; x < 255; x += 2)
                {
                    bool Mabool = false;
                    if (MyList[i] == x)
                        Mabool = true;
                    if (Mabool)
                        Console.WriteLine($"Element : {i + 1} = {MyList[i]} : Impaire");
                }
            }        
        }
        static void Main(string[] args)
        {
            AfficherBonsElements();
            Console.ReadLine();          
        }
    }
}

/*
    static void AfficherBonsElements()
        {
            var MyList = generateur();
            
            for (int i = 0; i < 25; ++i)
            {
                for (int x = 0; x < 255; x += 2)
                {
                   
                    if (MyList[i] == x)
                       Console.WriteLine($"Element : {i + 1} = {MyList[i]} : Paire");  
                    else if(MyList[i] == x+1)
                        Console.WriteLine($"Element : {i + 1} = {MyList[i]} : ImPaire");  
                }  
            }        
        }
            
            
