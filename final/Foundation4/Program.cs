using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity>exercises = new List<Activity>();
        exercises.Add(new Running(45, 3));
        exercises.Add(new Cycling(30, 80));
        exercises.Add(new Swimming(15, 50));


        foreach (var exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}