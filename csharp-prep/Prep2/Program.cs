using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your Grade as a percentage?");
        string percentageGiven = Console.ReadLine();
        int percentage = int.Parse(percentageGiven);

        string letterGrade = "F";
        string passing = "true";

        if (percentage >= 90)
        {
            letterGrade = "A";
            passing = "true";
        }
        else if (percentage >= 80)
        {
            letterGrade = "B";
            passing = "true";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
            passing = "true";
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
            passing = "no";
        }
        else
        {
            letterGrade = "F";
            passing = "sad";
        }

        Console.WriteLine(" ");
        Console.WriteLine($"Your letter grade was a {letterGrade}.");
        if (passing == "true")
        {
            Console.WriteLine("Congratulations on passing the class!");
        }
        else
        {
            Console.WriteLine("Seriously? You couldn't pass the class? I can't believe this.");
        }


    }
}