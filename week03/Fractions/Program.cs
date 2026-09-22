using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        return $"{GetTop()}/{GetBottom()}";
    }

    public double GetDecimalValue()
    {
        return (double)GetTop() / GetBottom();
    }
}


class Program
{
    static void Main(string[] args)
    {
        
        Fraction f1 = new Fraction(1, 1);
        Fraction f2 = new Fraction(6, 1);
        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine($"Fraction 1: {f1.GetFractionString()}");
        Console.WriteLine($"Fraction 1 as decimal: {f1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {f2.GetFractionString()}");
        Console.WriteLine($"Fraction 2 as decimal: {f2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {f3.GetFractionString()}");
        Console.WriteLine($"Fraction 3 as decimal: {f3.GetDecimalValue()}");
    }

    
}