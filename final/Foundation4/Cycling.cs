public class Cycling : Activity
{

    double _speedKph;
    public Cycling(double length, double speed) : base(length)
    {
        _speedKph = speed;
    }

    public override string GetSummary()
    {
        return $"{_date.ToLongDateString()} Cycling  ({_lengthMinutes} min): Distance {(_lengthMinutes/60)*_speedKph} km, Speed {_speedKph} kph, Pace: {60/_speedKph} min per km";
    }
}