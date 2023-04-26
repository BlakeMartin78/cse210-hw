using System;

class Program
{

     static void displayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string promptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int promptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int userNum = int.Parse(userInput);
        return userNum;
    }

    static int squareNumber(int inputNumber)
    {
        int squaredNumber = inputNumber * inputNumber;
        return squaredNumber;
    }

    static void displayResult(int num, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {num}");
    }
    static void Main(string[] args)
    {
        displayWelcome();
        string name = promptUserName();
        int number = promptUserNumber();
        int squaredNumber = squareNumber(number);
        displayResult(squaredNumber,name);
    }
}