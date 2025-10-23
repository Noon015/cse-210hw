using System;
using System.Runtime.CompilerServices;

class Word
{
    private string _word;
    private bool _isVisible = true;

    public Word(string word)
    {
        _word = word;
    }

    public void HideWord()
    {
        _isVisible = false;
    }

    public void UnHideWord()
    {
        _isVisible = true;
    }

    public string DisplayWord()
    {
        if (_isVisible)
        {
            return _word;
        }
        else
        {
            string blankWord = "";
            for (int i = 0; i < _word.Length; i++)
            {
                blankWord += "_";
            }
            return blankWord;
        }
    }

    public bool IsHidden()
    {
        if (_isVisible)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}