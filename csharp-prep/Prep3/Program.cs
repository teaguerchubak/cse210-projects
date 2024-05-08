using System;
using System.Runtime.CompilerServices;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";

        while (play == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int count = 0;
            int guess = 0;

            while (guess != number)
            {
                Console.Write("Guess the secret number: ");
                guess = int.Parse(Console.ReadLine());

                if (guess < number)
                {
                    count +=1;
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    count +=1;
                    Console.WriteLine("Lower");
                }
                else
                {
                    count +=1;
                    Console.WriteLine($"You guessed it in {count} attempts!");
                    Console.WriteLine("Would you like to play again? (yes/no) ");
                    play = Console.ReadLine();
                }
            }
        }

        Console.WriteLine("Thanks! Goodbye!");

    }

}