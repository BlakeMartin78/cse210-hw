public class ChecklistGoal : Goal
{
    int _maxTimesCompleted;
    int _pointValue2;
    int _timesCompleted = 0;



    public ChecklistGoal() : base()
    {
    }



    public override string DisplayGoal()
    {
        string completed;
        if (_completed == true)
        {
            completed = "[X]";
        }
        else
        {
            completed = "[ ]";
        }
        return $"{_name} {_description} {_timesCompleted}/{_maxTimesCompleted} {completed}";
    } 

    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of the goal you're creating?");
        _name = Console.ReadLine();
        Console.WriteLine("What is the description of the goal you're creating?");
        _description = Console.ReadLine();
        Console.WriteLine("How many Points is it worth?");
        _pointValue = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points is it worth?");
        _pointValue2 = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times do you want to complete it?");
        _maxTimesCompleted = int.Parse(Console.ReadLine());
    }

    public override int CompleteGoal(){
        if ( _timesCompleted < _maxTimesCompleted-1){
            _timesCompleted++;
            return _pointValue;
        } else if (_completed == false) {
            _completed = true;
            _timesCompleted = _maxTimesCompleted;
            return _pointValue2;
        } else {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }
    }


    public override string GetSaveString()
    {
        return $"ChecklistGoal|||{_name}|||{_description}|||{_pointValue}|||{_completed}|||{_timesCompleted}|||{_maxTimesCompleted}|||{_pointValue2}";
    }
    public override void LoadFromSave(string[] inputString)
    {
        _name = inputString[1];
        _description = inputString[2];
        _pointValue = int.Parse(inputString[3]);
        _completed = bool.Parse(inputString[4]);
        _timesCompleted = int.Parse(inputString[5]);
        _maxTimesCompleted = int.Parse(inputString[6]);
        _pointValue2 = int.Parse(inputString[7]);
    }

}