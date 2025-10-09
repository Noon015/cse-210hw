using System;
using System.Collections.Generic;

class randomPrompt
{
    static string GeneratePrompt()
    {
        // Create a list of prompts
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had to do one thing over today, what would it be?"
        };

        // Create a Random object
        Random random = new Random();


        int index = random.Next(prompts.Count);

        // Get the random prompt
        string ranGenPrompt = prompts[index];
        return ranGenPrompt;

    }
}
