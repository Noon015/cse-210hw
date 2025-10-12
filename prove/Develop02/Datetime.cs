using System;

class Date
{
    public string GetDateTime()
    {
        DateTime currentTime = DateTime.Now;
        string dateString = currentTime.ToShortDateString();
        return dateString;
    }
}