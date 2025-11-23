using System;
using System.Drawing;

class EternalGoal:Goal
{
    int _timesCompleted;
    
    public EternalGoal(string name, int points, string description,int timesCompleted,bool isComplete) : base(name, points, description,isComplete)
    {
       _timesCompleted = timesCompleted; 
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

    public override string SerializeToString()
    {
        string pointString = _points.ToString();
        string timesCompleteString = _timesCompleted.ToString();

        string fullSerialization = $"E|{_name}|{pointString}|{_description}|{timesCompleteString}|{_isComplete}";
        return fullSerialization;
    }

    public override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.WriteLine($"Times Completed: {_timesCompleted}");
    }
}