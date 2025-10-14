using System;
using System.Diagnostics.Contracts;

class Fraction
{
    int _top;
    int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    public int getTop()
    {
        int topNumber = _top;
        return topNumber;
    }

    public void setTop(int top)
    {
        _top = top;
    }

    public int getBottom()
    {
        int bottomNumber = _bottom;
        return bottomNumber;
    }

    public void setBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string topString = Convert.ToString(_top);
        string bottomString = Convert.ToString(_bottom);
        string fullFraction = $"{topString}/{bottomString}";
        return fullFraction;
    }

    public double getDecimalValue()
    {
        return (double) _top / (double) _bottom;
    }
}