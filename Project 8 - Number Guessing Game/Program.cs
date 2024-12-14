using System;

class NumberGuessingGame
{
    static void Main()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 1001);
        int playerGuess = 0;
        int numberOfTries = 0;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 1000.");

        while (playerGuess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            string userInput = Console.ReadLine();

            bool isValidNumber = int.TryParse(userInput, out playerGuess);

            if (isValidNumber)
            {
                numberOfTries++;
                if (playerGuess < numberToGuess)
                {
                    Console.WriteLine("Too low buddy! Try again.");
                }
                else if (playerGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {numberOfTries} tries.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        Console.Write("Do you want to play again? (y/n): ");
        string playAgain = Console.ReadLine().ToLower();
        if (playAgain == "y")
        {
            Main();
        }
        else
        {
            Console.WriteLine("Thanks for playing! Goodbye.");
        }
    }
}

