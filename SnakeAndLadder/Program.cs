using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Welcome Message
            Console.WriteLine("Welcome to Sanke & Ladder Simulator");

            //Variable
            int start_point = 0;
            Random rand = new Random();
            int dieNumber = rand.Next(1,7);

            //Display Die Number
            Console.WriteLine("Die Number : " +dieNumber);
        }
    }
}
