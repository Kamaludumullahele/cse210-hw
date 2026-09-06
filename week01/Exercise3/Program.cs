using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess;
        int attempts = 0;
        do
        {
            Console.Write($"What is your guess? ");
            string guessNumber = Console.ReadLine();
            guess = int.Parse(guessNumber);
            attempts++;

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != number);

        Console.WriteLine($"You guessed it in {attempts} attempts!");
    }

}
