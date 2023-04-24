using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        
        //Console.WriteLine($"The magic number is {number}");
        
        string readguess = "-1";
        int guess = int.Parse(readguess);

        while (guess != number)
        {

            Console.WriteLine("What is your guess?");
            readguess = Console.ReadLine();
            guess = int.Parse(readguess);

            if (guess == number)
            {
                Console.WriteLine("Gj Bro");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
        }
    }
}