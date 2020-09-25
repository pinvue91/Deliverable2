using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Guess which will have more: heads or tails?");

            string headsorTailsGuess = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("How many times shall we flip a coin?");

            int numberOfFlips = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            int flipCount = 0;
            int correctCount = 0;

            while (flipCount < numberOfFlips) 
            {
                Random rnd = new Random();

                int coinFlip = rnd.Next(1, 3);

                if(coinFlip == 1) 
                {
                    Console.WriteLine("heads");
                    flipCount++;
                    if(headsorTailsGuess == "heads")
                    {
                        correctCount++;
                    }
                }
                else if(coinFlip ==2)
                {
                    Console.WriteLine("tails");
                    flipCount++;
                    if (headsorTailsGuess == "tails")
                    {
                        correctCount++;
                    }
                }

            }

            Console.WriteLine("");

            double correctRatio = ((double)correctCount / (double)numberOfFlips)*100;

            Console.WriteLine("Your guess, " + headsorTailsGuess + ", came up " + correctCount + " time(s).");
            Console.WriteLine("That's " + correctRatio + "%.");

        }
    }
}
