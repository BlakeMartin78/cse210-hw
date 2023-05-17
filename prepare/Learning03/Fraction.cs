public class Fraction
{
    int _top;
    int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom =1;
    }

    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionAsString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetFractionAsFloat()
    {
        return (double)_top/(double)_bottom;
    }
}