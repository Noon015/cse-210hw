using System;
using System.Collections.Concurrent;

class Refrence
{
    private string _book = "Isaiah";
    private string _chapter = "5";
    private string _verseNumber = "20";

    public string GetRefrence()
    {
        return $"{_book} {_chapter}, {_verseNumber}";
    }
}