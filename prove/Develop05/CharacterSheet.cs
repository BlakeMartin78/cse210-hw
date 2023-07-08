public class CharacterSheet{
    List<Goal> _goals = new List<Goal>();
    int _currentPoints;


    public CharacterSheet(){
        _currentPoints = 0;
    }

    public void DisplayAllGoals()
    {
        int i = 0;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.DisplayGoal()}");
            i++;
        }
    }
    public int DisplayPoints()
    {
        return _currentPoints;
    }
    public void NewGoal(Goal tempGoal) // can you pass in multiple types for argument or whatever
    {
        _goals.Add(tempGoal);
    }
    public void LoadGoals(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(string line in lines)
        {
            string[] parts = line.Split("|||");
            switch (parts[0])
            { //The different "tempgoals" here are really inelegeant and realistically aren't the best solution, but it's the quickest way I could think of to do this.
                case "PerpetualGoal":
                    Goal tempGoal = new PerpetualGoal();
                    tempGoal.LoadFromSave(parts);
                    _goals.Add(tempGoal);
                break;


                case "ChecklistGoal":
                    PerpetualGoal tempGoal2 = new PerpetualGoal();
                    tempGoal2.LoadFromSave(parts);
                    _goals.Add(tempGoal2);
                break;


                case "SimpleGoal":
                    PerpetualGoal tempGoal3 = new PerpetualGoal();
                    tempGoal3.LoadFromSave(parts);
                    _goals.Add(tempGoal3);
                break;

                case "points":
                    _currentPoints = int.Parse(parts[1]);
                break;
            }
        }
    }
    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"points|||{_currentPoints}");
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
    }
    public void CompleteGoal(int selection)
    {
        _currentPoints += _goals[selection].CompleteGoal();
    }

}