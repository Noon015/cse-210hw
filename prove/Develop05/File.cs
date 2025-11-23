using System;
using System.Runtime.CompilerServices;
using System.Text.Json;


class File
{
     List<Goal> _goalList;

    public File(List<Goal> goals)
    {
        _goalList = goals;
    }
    public void AppendList(Goal goal)
    {
        _goalList.Add(goal);
    }

    public void DisplayList()
    {
        foreach (Goal item in _goalList)
        {
            item.DisplayGoal();
            Console.WriteLine();
        }
    }

    public void NumberedDisplay()
    {
        int i = 1;
        foreach (Goal item in _goalList)
        {

            string fullString = $"{i}. {item.DisplayGoal}";
            Console.WriteLine(fullString);
            i += 1;
        }
    }

    public void SaveToFile()
    {
        string filename = "json.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal item in _goalList)
            {
                string itemSerialized = item.SerializeToString();
                outputFile.WriteLine(itemSerialized);
            }
        }
    }

    public void LoadFromFile()
    {
        string filename = "json.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string items in lines)
        {
            string[] parts = items.Split("|");
            string goalType = parts[0];

            if (goalType == "G")
            {
                string name = parts[1];
                int points = Convert.ToInt32(parts[2]);
                string description = parts[3];
                bool isComplete = Convert.ToBoolean(parts[4]);
                Goal goal1 = new Goal(name,points,description,isComplete);
                this.AppendList(goal1);

            }    
            else if (goalType == "E")
            {
                string name = parts[1];
                int points = Convert.ToInt32(parts[2]);
                string description = parts[3];
                bool isComplete = Convert.ToBoolean(parts[5]);
                int timesCompleted = Convert.ToInt32(parts[4]);

                EternalGoal goal2 = new EternalGoal(name,points,description,timesCompleted,isComplete);
                this.AppendList(goal2);

            }
            else if (goalType == "C")
            {
                string name = parts[1];
                int points = Convert.ToInt32(parts[2]);
                string description = parts[3];
                bool isComplete = Convert.ToBoolean(parts[4]);
                int bonusPoints = Convert.ToInt32(parts[5]);
                int timesCompleted = Convert.ToInt32(parts[6]);
                int timesToComplete = Convert.ToInt32(parts[7]);

                ChecklistGoal goal3 = new ChecklistGoal(name,points,description,bonusPoints,timesCompleted,timesToComplete,isComplete);
                this.AppendList(goal3);
            }
        }
    }
}