using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.AccessControl;
using System;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string Level = "";
            Console.WriteLine("Hello Welcome to the guessing game.");
            Console.WriteLine("There are three levels:");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Intermediate");
            Console.WriteLine("3. Hard");
            Console.Write("What level would you like to play: ");
            Level = Console.ReadLine();
            Console.WriteLine(Level);
            string level1 = "Easy";
            string level2 = "Intermediate";
            string level3 = "Hard";
            if (Level == level1)
            {
                Console.WriteLine("You have 6 trials");
                Console.WriteLine("guess a number from 1 to 10 ");
                
               
                for(int i = 0; i < 6; i++) 
                {   
                    int input = 0;
                    Random rd = new Random();
                    int rand_num = rd.Next(1,10);
                    Console.Write("Enter a guess: ");
                    input = int.Parse(Console.ReadLine());
                    
                    if (input != rand_num )
                    {
                        Console.WriteLine("Try again");
                    }
                    else if(input == rand_num)
                    {
                        Console.WriteLine("You Win");
                        break;
                    }
                    
                }
                
            }   
            
                Console.Write("What level would you like to play: ");
                Level = Console.ReadLine();
                if (Level == level2)
            {
                Console.WriteLine("You have 4 trials");
                Console.WriteLine("guess a number from 1 to 20 ");
                
                
                for(int i = 0; i < 4; i++) 
                {   
                    int input = 0;
                    Random rd = new Random();
                    int rand_num = rd.Next(1,20);
                    Console.Write("Enter a guess: ");
                    input = int.Parse(Console.ReadLine());
                    
                    if (input != rand_num)
                    {
                        Console.WriteLine("Try again");
                    }
                    else if(input == rand_num)
                    {
                        Console.WriteLine("You Win");
                        break;
                    }
                    
                }
                Console.Write("What level would you like to play: ");
                Level = Console.ReadLine();
            }    
                
            if (Level == level3)
            {
                Console.WriteLine("You have 6 trials");
                Console.WriteLine("guess a number from 1 to 50 ");
                
                for(int i = 0; i < 6; i++) 
                {   
                    int input = 0;
                    Random rd = new Random();
                    int rand_num = rd.Next(1,50);
                    Console.Write("Enter a guess: ");
                    input = int.Parse(Console.ReadLine());
                    
                    if (input != rand_num )
                    {
                        Console.WriteLine("Try again");
                    }
                    else if(input == rand_num)
                    {
                        Console.WriteLine("You Win");
                        break;
                    }
                    
                }      
                
                
                
            }
        }
    }
}