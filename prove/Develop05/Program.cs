using System;

class Program
{
    static void Main(string[] args)
    {
        CharacterSheet sheet = new CharacterSheet();
        string selection = "-1";
        string fileName;
        string type;
        PerpetualGoal tempPerpetual;
        SimpleGoal tempSimple;
        ChecklistGoal tempCheck;
        int whichGoal;


        while (selection != "6")
        {
            Console.Clear();
            Console.WriteLine($"You have {sheet.DisplayPoints()} points.");
            Console.WriteLine("This is the goal tracking program.");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Complete a goal");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            Console.Write(" >  ");
            selection = Console.ReadLine() ?? String.Empty;
            
            switch (selection)
            {
                case "1":
                    Console.WriteLine("What kind of goal would you like to make?");
                    Console.WriteLine("1. PerpetualGoal, 2. SimpleGoal, or 3. ChecklistGoal");
                    type = Console.ReadLine();
                    switch (type)
                    {
                        case "1":
                        tempPerpetual = new PerpetualGoal();
                        tempPerpetual.CreateGoal();
                        sheet.NewGoal(tempPerpetual);
                        break;

                        case "2":
                        tempSimple = new SimpleGoal();
                        tempSimple.CreateGoal();
                        sheet.NewGoal(tempSimple);
                        break;

                        case "3":
                        tempCheck = new ChecklistGoal();
                        tempCheck.CreateGoal();
                        sheet.NewGoal(tempCheck);
                        break;

                        default:
                        tempSimple = new SimpleGoal();
                        tempSimple.CreateGoal();
                        sheet.NewGoal(tempSimple);
                        break;
                    }
                
                break;

                case "2":
                sheet.DisplayAllGoals();
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                break;

                case "3":
                Console.WriteLine("Input the file to save to. Include .txt");
                fileName = Console.ReadLine();
                sheet.SaveGoals(fileName);
                break;
                
                case "4":
                Console.WriteLine("Input the file to load from. Include the file extension.");
                fileName = Console.ReadLine();
                sheet.LoadGoals(fileName);
                break;


                case "5":
                sheet.DisplayAllGoals();
                Console.WriteLine("Select a goal to complete.");
                whichGoal = int.Parse(Console.ReadLine());
                sheet.CompleteGoal(whichGoal);
                break;
            }
        }
    }
}