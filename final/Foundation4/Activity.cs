public abstract class Activity{


    public Activity(double length)
    {
        _lengthMinutes = length;
    }
    protected DateTime _date = DateTime.Now;
    protected double _lengthMinutes;
    public abstract string GetSummary();

}