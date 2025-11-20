using System;
using System.Collections.Specialized;

class Goal
{
    protected string _name;
    protected int _points;
    protected string _description;
    protected bool _isComplete = false;

    public Goal(string name, int points, string description)
    {
        _name = name;
        _points = points;
        _description =  description;
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

    public void DisplayGoal()
    {
        Console.WriteLine($"Goal: {_name}");
        Console.WriteLine($"Description: {_description}");
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


}