using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction a = new Fraction();
        Console.WriteLine(a.GetFractionAsString());
        Console.WriteLine(a.GetFractionAsFloat());

        Fraction b = new Fraction(7);
        Console.WriteLine(b.GetFractionAsString());
        Console.WriteLine(b.GetFractionAsFloat());

        Fraction c = new Fraction(2,3);
        Console.WriteLine(c.GetFractionAsString());
        Console.WriteLine(c.GetFractionAsFloat());
        
        Fraction d = new Fraction(1,8);
        Console.WriteLine(d.GetFractionAsString());
        Console.WriteLine(d.GetFractionAsFloat());    
    
    
    }
}