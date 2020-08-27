using System;

namespace C__morning_challenge
{
  class Program
  //   NOTE Write a program that will choose a random number and allow users to guess. Users will be prompted to guess higher and lower until they get the final answer. Users have the option to 'start a new game' once they get the right answer.
  {
    static void Main(string[] args)
    {
      game();
      static void game()
      {
        Random rdm = new Random();
        int randomNumber = rdm.Next(20);

        Console.WriteLine("Guess the random number between 1 & 20...");
        int.TryParse(Console.ReadLine(), out int guessedNumber);

        while (guessedNumber != randomNumber)
        {
          if (guessedNumber < randomNumber)
          {
            Console.WriteLine("Higher. Guess again...");
          }
          else if (guessedNumber > randomNumber)
          {
            Console.WriteLine("Lower. Guess again...");
          }
          int.TryParse(Console.ReadLine(), out guessedNumber);
        }

        Console.WriteLine($"Correct. You win! The number was {randomNumber}");
        Console.WriteLine("Would you like to play again?  Y/N");
        string playAgain = Console.ReadLine();
        if (playAgain.ToLower() == "y")
        {
          game();
        }
      }
    }
  }
}

