public class PerpetualGoal : Goal
{


    public PerpetualGoal() : base()
    {
        
    }








    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of the goal you're creating?");
        _name = Console.ReadLine();
        Console.WriteLine("What is the description of the goal you're creating?");
        _description = Console.ReadLine();
        Console.WriteLine("How many Points is it worth?");
        _pointValue = int.Parse(Console.ReadLine());
    }
    public override int CompleteGoal()
    {
        return _pointValue;
    }

    public override string GetSaveString()
    {
        return $"PerpetualGoal|||{_name}|||{_description}|||{_pointValue}|||{_completed}";
    }
    public override void LoadFromSave(string[] inputString)
    {
        _name = inputString[1];
        _description = inputString[2];
        _pointValue = int.Parse(inputString[3]);
        _completed = bool.Parse(inputString[4]);
    }
}