using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
public class Journal
{

    List<JournalEntry> _entryList = new List<JournalEntry> { };
    Date nowTime = new Date();
    
    PromptGenerator myPrompt = new PromptGenerator();
    public void AddEntry()
    {
        JournalEntry entry1 = new JournalEntry();
        entry1._date = nowTime.GetDateTime();
        entry1._prompt = myPrompt.GeneratePrompt();
        Console.WriteLine(entry1._prompt);
        Console.Write(">");
        entry1._entry = Console.ReadLine();
        _entryList.Add(entry1);
    }

    public void DisplayJournal()
    {
        foreach (JournalEntry item in _entryList)
        {
            item.DisplayEntry();
        }


    }

    public void SaveEntries(string filename)
    {

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            if (File.Exists(filename))
            {
                outputFile.WriteLine("Date|Prompt|Entry");
                foreach (JournalEntry items in _entryList)
                {
                    string csv_entry = $"{items._date}|{items._prompt}|{items._entry}";
                    outputFile.WriteLine(csv_entry);
                }
            }
            else
            {
                Console.WriteLine("ERROR: INVALID FILE");
            }
        }


    }
    
    public void LoadEntries(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            JournalEntry entry2 = new JournalEntry();
            entry2._date = parts[0];
            entry2._prompt = parts[1];
            entry2._entry = parts[2];
            _entryList.Add(entry2);
        }
    }
}