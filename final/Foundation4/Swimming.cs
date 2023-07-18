public class Swimming : Activity
{

    double _laps;
    public Swimming(double length, double laps) : base(length)
    {
        _laps = laps;
    }

    public override string GetSummary()
    {
        return $"{_date.ToLongDateString()} Swimming ({_lengthMinutes} min): Distance {_laps*50/1000} km, Speed {((_laps*50/1000)/_lengthMinutes)*60} kph, Pace: {60/(((_laps*50/1000)/_lengthMinutes)*60)} min per km";
    }
}