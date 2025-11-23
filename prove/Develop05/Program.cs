using System;
using System.Collections;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
      int totalPoints = 0;
      List<Goal> goalList = new List<Goal>();
      File saveFile = new File(goalList);
      while (true)
        {
            
            Console.WriteLine("Goal Program");
            Console.WriteLine();
            Console.WriteLine($"Points: {totalPoints}");
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            string answer = Console.ReadLine();

            if (answer == "1")
            {
               //Goal Creation section
               Console.WriteLine("The Types of Goals are: \n1. Simple Goal \n2. Eternal Goal \n3.CheckList Goal\n");
               Console.Write("Which Goal would you like to create: ");
               string choice = Console.ReadLine();

               if (choice == "1")
               { 
                  //simple goal
                  Console.WriteLine("What Would you like to name the goal: ");
                  string name = Console.ReadLine();
                  Console.WriteLine("Write a short description: ");
                  string description = Console.ReadLine();
                  Console.WriteLine("How many points will assign this goal: ");
                  int points = Convert.ToInt32(Console.ReadLine());

                  Goal goal1 = new Goal(name,points,description,false);
                  saveFile.AppendList(goal1);
                    
               }
               else if (choice == "2")
               { 
                  //eternal goal
                  Console.WriteLine("What Would you like to name the goal: ");
                  string name = Console.ReadLine();
                  Console.WriteLine("Write a short description: ");
                  string description = Console.ReadLine();
                  Console.WriteLine("How many points will assign this goal: ");
                  int points = Convert.ToInt32(Console.ReadLine());
                  int timesCompleted = 0;

                  EternalGoal goal2 = new EternalGoal(name,points,description,timesCompleted,false);
                  saveFile.AppendList(goal2);
                    
               }
               else if (choice == "3")
               { 
                  //checklist goal
                  Console.WriteLine("What Would you like to name the goal: ");
                  string name = Console.ReadLine();
                  Console.WriteLine("Write a short description: ");
                  string description = Console.ReadLine();
                  Console.WriteLine("How many points will assign this goal: ");
                  int points = Convert.ToInt32(Console.ReadLine());
                  int timesCompleted = 0;  
                  Console.WriteLine("How times would you need to complete this goal: ");
                  int timesToComplete = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("How many bonus point will be awarded upon total completion: ");
                  int bonusPoints = Convert.ToInt32(Console.ReadLine());

                  ChecklistGoal goal3 = new ChecklistGoal(name,points,description,bonusPoints,timesCompleted,timesToComplete,false);
                  saveFile.AppendList(goal3);
               }
                
            }
            else if (answer == "2")
            {
               //Look at all them goals, boi
               saveFile.DisplayList();
                
            }
            else if (answer == "3")
            {
               //save the whales? nah save the goals instead.
               saveFile.SaveToFile();
               Console.WriteLine("Goals Saved");
                
            }
            else if (answer == "4")
            {
               //a whole LOAD of goals...... he he.
               saveFile.LoadFromFile();
               Console.WriteLine("Goals Loaded");
                
            }
            else if (answer == "5")
            {
               //now for the hard part. goal completeion and point tallying
               Console.WriteLine("Current Goals: ");
               saveFile.NumberedDisplay();
               Console.WriteLine("Which Goal did you complete: ");
               int completedIndex = Convert.ToInt32(Console.ReadLine()) - 1;
               Goal obj = goalList[completedIndex];
               obj.CompleteGoal();
               totalPoints += obj.ComputePoints(); 
               //well.... that took less work than I thougt it would. still a pain tho
            }
            else if (answer == "6")
            {
               Console.WriteLine("\nGoodbye");
               break;
            }
            
        }
    }
}