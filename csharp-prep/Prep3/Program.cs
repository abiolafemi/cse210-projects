using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guesses = -1;
        while (true)
        {
            Console.Write("What is your guess? ");
            guesses = Convert.ToInt32(Console.ReadLine());
            guesses++;

            if (guesses < magicNumber )
            {
                Console.WriteLine("Higher");
            }
            else if (guesses > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine($"You guessed it! The magic number was {magicNumber},");

                Console.WriteLine($" It took you {guesses} guesses.");
                break;
            }
        // // Stretch Challenge: Keep track of how many guesses the user has made and inform them of it at the end of the game
		// // Ask the user if they want to play again
		// Console.Write("Do you want to play again? (yes/no) ");
		// string playAgain = Console.ReadLine();
		// if (playAgain.ToLower() != "yes")
		// {
		// 	return;
		// }



        }

    
    }
            
} 





