using System;
using System.Collections.Concurrent;

class Refrence
{
    private string _book;
    private int _chapter;
    private int _verseNumber;

    public Refrence(string book, int chapter,int verseNumber)
    {
        _book = book;
        _chapter = chapter;
        _verseNumber = verseNumber;
    }

    public string GetRefrence()
    {
        return $"{_book} {_chapter}, {_verseNumber}";
    }
}