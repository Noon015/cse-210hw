using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Runtime.CompilerServices;

class Goal
{
    protected string _name;
    protected int _points;
    protected string _description;
    protected bool _isComplete = false;

    public Goal(string name, int points, string description,bool isComplete)
    {
        _name = name;
        _points = points;
        _description =  description;
        _isComplete = isComplete;
    }

    public virtual int ComputePoints()
    {
        if (_isComplete)
        {
            return _points;
        }
        else
        {
            Console.WriteLine("Error: Goal is Incomplete.");
            return 0;
        }
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"Goal: {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
    }

    public void DisplayName()
    {
        Console.WriteLine(_name);
    }

    public virtual void CompleteGoal()
    {
        if (_isComplete)
        {
            Console.WriteLine("Error: Goal has already been Completed");
        }
        else
        {
            _isComplete = true;
            Console.WriteLine($"Your Goal {_name} has been completed");
            int goalPoints = this.ComputePoints();
            Console.WriteLine($"{goalPoints} points gained");
        }
    }

    public virtual string SerializeToString()
    {
        string point_string = _points.ToString();
        string completion_string = _isComplete.ToString();

        string fullSerialization = $"G|{_name}|{point_string}|{_description}|{completion_string}";
        return fullSerialization;
    }
}