using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, at least 1, and type 0 when finished.");
        string input;
        int inputNumber = -1;
        
        
        while (inputNumber != 0)
        {
            Console.Write("Enter number : ");
            input = Console.ReadLine();
            inputNumber = int.Parse(input);

            if (inputNumber != 0)
            {
            numbers.Add(inputNumber);
            }
        }
        float average = 0;
        int sum = 0;
        int biggest = -1;
        foreach (int number in numbers)
        {
            sum += number;
            if (biggest < number)
            {
                biggest = number;
            }
        }
        
        
        average = sum / numbers.Count;
        


        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The biggest number is {biggest}");
    }
}