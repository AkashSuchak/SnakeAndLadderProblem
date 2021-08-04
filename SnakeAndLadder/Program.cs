using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Welcome Message
            Console.WriteLine("Welcome to Sanke & Ladder Simulator");

            //Variables
            int start_point = 0;
            int position = 0;
            int dieNumber, gameOptions;

            //Generate Numbers For Die and GameOptions
            Random rand = new Random();            
            
            //Loop to get Winning Points reached
            while (position != 100)
            {               
                // generating Random Numbers for Die and Game Options
                dieNumber = rand.Next(1, 7);
                gameOptions = rand.Next(0, 3);

                switch (gameOptions)
                {
                    case 0:
                        Console.WriteLine("Position : " + position);
                        break;
                    case 1:
                        position += dieNumber;
                        Console.WriteLine("Position : " + position);
                        break;

                    case 2:
                        position -= dieNumber;
                        Console.WriteLine("Position : " + position);
                        break;

                    default:
                        break;
                }
                //Above 100 break and below 0 - restart
                if (position > 100)                
                    break;
                else if (position < 0)                
                    position = 0;                
            }
            //Display Position Number
            Console.WriteLine("You Won ! Reached at : " + position);            
        }
    }
}
