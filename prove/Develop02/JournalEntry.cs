using System;

public class JournalEntry
{
    public string _entry;
    public string _entryTitle;
    public string GetDateTime()
    {
        DateTime currentTime = DateTime.Now;
        string dateString = currentTime.ToShortDateString();
        return dateString;
    }
    
    public string GeneratePrompt()
    {
       
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had to do one thing over today, what would it be?"
        };

       
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string ranGenPrompt = prompts[index];
        return ranGenPrompt;

    }


    }
