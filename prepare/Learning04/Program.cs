using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment a1 = new Assignment("Maxulus McCalculus", "Calculus");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignments
        MathAssignment a2 = new MathAssignment("Clark Namauu", "Operational Amplifiers", "12.1", "1-4");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Abigayl Martin", "Women's History", "A Summary of Women's Suffrage");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}