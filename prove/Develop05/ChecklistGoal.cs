using System;

class ChecklistGoal : Goal
{
    int _bonusPoints;
    int _timesCompleted;
    int _timesToComplete;

    public ChecklistGoal(string name, int points, string description,int bonusPoints,int timesCompleted,int timesToComplete, bool isComplete) : base(name, points, description,isComplete)
    {
        _bonusPoints = bonusPoints;
        _timesToComplete = timesToComplete;
        _timesCompleted = timesCompleted;
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
            _isComplete = true;
        }
        else if (_timesCompleted > _timesToComplete)
        {
            Console.WriteLine("ERROR: Goal already completed the required number of times");
        }
    }

    public override string SerializeToString()
    {
        string pointString = _points.ToString();
        string bonusPointString = _bonusPoints.ToString();
        string timesCompletedString = _timesCompleted.ToString();
        string timesToCompleteString = _timesToComplete.ToString();

        string fullSerialization = $"C|{_name}|{pointString}|{_description}|{_isComplete}|{bonusPointString}|{timesCompletedString}|{timesToCompleteString}";
        return fullSerialization;
    }

    public override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.WriteLine($"Completed: [{_timesCompleted}/{_timesToComplete}]");
    }
}