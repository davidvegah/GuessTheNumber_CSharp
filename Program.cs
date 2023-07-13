using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Guess The Number!");
        
        Random random = new Random();
        int secretNumber = random.Next(1, 100 + 1);

        Console.WriteLine("I'm thinking in a number between 1 and 100");
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            int guess = int.Parse(input);

            if (guess > secretNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("You won! :)");
                return;
            }
        }
        Console.WriteLine("Game Over! :(");
    }
}