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
            int position = 0, diceNumber = 0;
            int dieNumber, gameOptions;

            //Generate Numbers For Die and GameOptions
            Random rand = new Random();            
            
            //Loop to get Winning Points reached
            while (position != 100)
            {
                diceNumber++;
                // generating Random Numbers for Die and Game Options
                dieNumber = rand.Next(1, 7);
                gameOptions = rand.Next(0, 3);

                switch (gameOptions)
                {
                    case 0:
                        Console.WriteLine("Number : " +diceNumber + " Position : " + position);
                        break;
                    case 1:
                        position += dieNumber;
                        Console.WriteLine("Number : " + diceNumber + " Position : " + position);
                        break;

                    case 2:
                        position -= dieNumber;
                        Console.WriteLine("Number : " + diceNumber + " Position : " + position);
                        break;

                    default:
                        break;
                }
                //Exact winning Position
                if (position > 100)
                    position -= dieNumber;
                else if (position < 0)
                    position = 0;
            }
            //Display Position Number and Numer of Time Dice was Played
            Console.WriteLine("You Won ! Reached at : " + position);
            Console.WriteLine("The Number of Times the Dice Was Played : " + diceNumber);
        }
    }
}
