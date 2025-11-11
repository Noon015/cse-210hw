using System;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 30;
    }

    public void DoStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like the activity to last: ");
        _duration = int.Parse(Console.ReadLine());
        
    }

    public void DoEndingMessage()
    {
        Console.WriteLine("Well Done!!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity");
    }

    protected void _SpinnerAnimation(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.Write("\b\b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("\\");
        }
    }
    
    protected void _Countdown(int countFrom)
    {
        for (int i = countFrom; i > 0; i--)
        {
            Console.Write("\b\b\b");
            Console.Write(i);
            Thread.Sleep(1000);
        }
    }
}