using System;

class ChecklistGoal : Goal
{
    int _bonusPoints;
    int _timesCompleted;
    int _timesToComplete;

    public ChecklistGoal(string name, int points, string description,int bonusPoints,int timesToComplete) : base(name, points, description)
    {
        _bonusPoints = bonusPoints;
        _timesToComplete = timesToComplete;
    }

    public override int ComputePoints()
    {
      if (_timesCompleted < _timesToComplete)
        {
            return _points;
        }  
        else if (_timesCompleted == _timesToComplete)
        {
            int totalPoints = _bonusPoints + _points;
            return totalPoints;
        }
        else
        {
            return 0;
        }
    }


    public override void CompleteGoal()
    {
        int totalPoints = this.ComputePoints();
        if (_timesCompleted < _timesToComplete)
        {
            Console.WriteLine($"Your Goal {_name} has been completed");
            Console.WriteLine($"Completed {_timesCompleted}/{_timesToComplete} times");
            Console.WriteLine($"{totalPoints} gained");
        }
        else if (_timesCompleted == _timesToComplete)
        {
            Console.WriteLine($"Your Goal {_name} has been completed");
            Console.WriteLine($"Completed {_timesCompleted}/{_timesToComplete} times");
            Console.WriteLine($"{totalPoints} gained");
            Console.WriteLine($"{_bonusPoints} bonus points gained.");
        }
        else if (_timesCompleted > _timesToComplete)
        {
            Console.WriteLine("ERROR: Goal already completed the required number of times");
        }
    }
}