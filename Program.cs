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
                Console.WriteLine("Hint: It is less than 8");
                
               
                for(int i = 0; i < 6; i++) 
                {   
                    int input = 0;
                    int answer = 6; 
                    Console.Write("Enter a guess: ");
                    input = int.Parse(Console.ReadLine());
                    
                    if (input != answer )
                    {
                        Console.WriteLine("Try again");
                    }
                    else if(input == answer)
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
                Console.WriteLine("Hint: It is less than 17");
                
                
                for(int i = 0; i < 4; i++) 
                {   
                    int input = 0;
                    int answer = 12; 
                    Console.Write("Enter a guess: ");
                    input = int.Parse(Console.ReadLine());
                    
                    if (input != answer )
                    {
                        Console.WriteLine("Try again");
                    }
                    else if(input == answer)
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
                Console.WriteLine("Hint: It is less than 40");
                
                for(int i = 0; i < 6; i++) 
                {   
                    int input = 0;
                    int answer = 26; 
                    Console.Write("Enter a guess: ");
                    input = int.Parse(Console.ReadLine());
                    
                    if (input != answer )
                    {
                        Console.WriteLine("Try again");
                    }
                    else if(input == answer)
                    {
                        Console.WriteLine("You Win");
                        break;
                    }
                    
                }      
                
                
                
            }
        }
    }
}