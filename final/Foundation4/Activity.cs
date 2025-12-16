using System;
using System.Diagnostics.Contracts;

abstract class Activity
{
    protected DateTime _date;
    protected int _duration;

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string convertDate()
    {
        string dateString = _date.ToString("dd,MM yyyy");
        return dateString;
    }
    public virtual string getSummary()
    {
        return "";
    }
}