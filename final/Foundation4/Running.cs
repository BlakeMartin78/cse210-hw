public class Running : Activity
{

    double _distanceKm;
    public Running(double length, double distance) : base(length)
    {
        _distanceKm = distance;
    }

    public override string GetSummary()
    {
        return $"{_date.ToLongDateString()} Running ({_lengthMinutes} min): Distance {_distanceKm} km, Speed {(_distanceKm / _lengthMinutes)*60} kph, Pace: {_lengthMinutes/_distanceKm} min per km";
    }
}