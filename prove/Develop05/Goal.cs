public abstract class Goal
{
    protected int _pointValue;
    protected string _name;
    protected string _description;
    protected bool _completed;

    public Goal()
    {
        _completed = false;
    }

    public virtual string DisplayGoal()
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
        return $"{_name} {_description} {completed}";
    }
    public abstract void CreateGoal();
    public abstract int CompleteGoal();
    public abstract string GetSaveString();
    public abstract void LoadFromSave(string[] inputString);
}