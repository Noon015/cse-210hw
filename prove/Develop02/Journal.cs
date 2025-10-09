using System;
using System.Runtime.InteropServices;
using System.IO;
public class Journal
{
    public JournalEntry generic_entry = new JournalEntry();


    public void AddEntry()
    {
        //get the title
        Console.WriteLine("Please Enter a Title: ");
        generic_entry._entryTitle = Console.ReadLine();
        //Prompt goes here
        string myPrompt = generic_entry.GeneratePrompt();
        Console.WriteLine($"Your Prompt: \n{myPrompt}");
        //actual journal entry here
        Console.WriteLine("Please enter your journal entry: ");
        generic_entry._entry = Console.ReadLine();
        //get the time
        string time = generic_entry.GetDateTime();
        //hopefully add it all together
        string csv_string = $"{time}|{generic_entry._entryTitle}|{myPrompt}|{generic_entry._entry}";
        //autosave feature for the files, nice
        string filename = "entries.csv";

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            outputfile.WriteLine("Date|Title|Prompt|Entry");

            outputfile.WriteLine($"{csv_string}");
        }
        
    }
    
}