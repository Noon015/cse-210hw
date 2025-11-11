using System.Diagnostics.Contracts;

public class Entrepreneur : Character
{
    public Entrepreneur() : base("Steve")
    {

    }
    
    public override void Attack()
    {
        Console.WriteLine($"{_name} throws money at people $$$$");
    }
}