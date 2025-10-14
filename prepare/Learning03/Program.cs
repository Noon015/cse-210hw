using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction numbers1 = new Fraction(3,2);
        Console.WriteLine(numbers1.getDecimalValue());
        Console.WriteLine(numbers1.GetFractionString());
    }
}