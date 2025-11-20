using System;
using System.Drawing;

class EternalGoal:Goal
{

    int _timesCompleted = 0;
    public EternalGoal(string name, int points, string description) : base(name, points, description)
    {
        
    }

    public override int ComputePoints()
    {
        int totalPoints = _points * _timesCompleted;
        return totalPoints;  
    }

    public override void CompleteGoal()
    {
        _timesCompleted += 1;
        Console.WriteLine($"Your Goal {_name} has been completed");
        int totalPoints = this.ComputePoints();
        Console.WriteLine($"{totalPoints} points gained");
    }
}