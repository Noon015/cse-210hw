using System;
using System.Dynamic;
using System.Net.Http.Headers;

public class JournalEntry
{
    public string _entry;
    public string _date;
    public string _prompt;
    
    public void DisplayEntry()
    {
        string full_entry = $"Date: {_date}-Prompt:{_prompt}\n{_entry}";
        Console.WriteLine(full_entry);
        Console.WriteLine();
    }
}
