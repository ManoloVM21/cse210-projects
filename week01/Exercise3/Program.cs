using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        int number = randomgenerator.Next(1,101);

        string usern;
        int guess;
        int attempts = 0;
        string response = "yes";
        while (response == "yes")
        {
            do{
                Console.Write("What is your guess? ");
            usern = Console.ReadLine();
            guess = int.Parse(usern);
            
            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("Lower");
            }

            attempts=attempts+1;
            
            } while (guess != number);
            Console.WriteLine($"You did it in {attempts} attempts.");
            Console.WriteLine("Do you want to play again? ");
            response = Console.ReadLine();
        }
        
    }
}