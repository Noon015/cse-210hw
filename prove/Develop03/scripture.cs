using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;

class Scripture
{
    List<Word> _wordList = new List<Word>();
    Refrence _refrence;

    public Scripture(string text, Refrence refrence)
    {
        _refrence = refrence;
        List<string> _list = text.Split(" ").ToList();

        foreach (string item in _list)
        {
            Word newWord = new Word(item);
            _wordList.Add(newWord);
        }
    }

    public string DisplayScripture()
    {
        string refrence_string = _refrence.GetRefrence();
        string verseString = "";
        foreach (Word wordItem in _wordList)
        {
            verseString += wordItem.DisplayWord() + " ";
        }
        return $"{refrence_string}: {verseString}";
    }

    public void HideScripture()
    {
        Random Number = new Random();
        int ranIndex = Number.Next(_wordList.Count);
        _wordList[ranIndex].HideWord();

    }

    public bool AllWordsHidden()
    {
        List<bool> truthList = new List<bool>();
        foreach (Word item in _wordList)
        {
            if (item.IsHidden())
            {
                truthList.Add(true);
            }
            else
            {
                truthList.Add(false);
            }
        }
        bool allTrue = truthList.All(f => f);

        if (allTrue)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}