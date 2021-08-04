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

            //Generate Numbers For Die and GameOptions
            Random rand = new Random();
            int dieNumber = rand.Next(1,7);
            int gameOptions = rand.Next(0, 3);

            //Display Die Number
            Console.WriteLine("Die Number : " +dieNumber);

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
        }
    }
}
