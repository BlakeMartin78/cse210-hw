public class SimpleGoal : Goal
{

    public SimpleGoal() : base()
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
        if (_completed == false){
        _completed = true;
        return _pointValue;
        } else {
        Console.WriteLine("This goal has already been completed.");
        return 0;
        }
    }
    public override string GetSaveString()
    {
        return $"SimpleGoal|||{_name}|||{_description}|||{_pointValue}|||{_completed}";
    }

    public override void LoadFromSave(string[] inputString)
    {   //takes a list of strings from the file handler 
        _name = inputString[1];
        _description = inputString[2];
        _pointValue = int.Parse(inputString[3]);
        _completed = bool.Parse(inputString[4]);
    }


}