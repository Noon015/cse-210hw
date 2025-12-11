using System;

class Event
{
    protected string _eventTitle;
    protected string _description;
    protected DateTime _date;
    protected TimeSpan _time;
    protected Address _address;
    

    public Event(string eventTitle, string description, DateTime date, TimeSpan time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        string addressString = _address.DisplayAddress();
        string dateString = _date.ToString("yyyy-MM-dd");
        string timeString = _time.ToString();

        string standDetails = $"----------\n{_eventTitle}\n{_description}\n{dateString}, {timeString}\n{addressString}";
        return standDetails;
    }

    public virtual string FullDetails()
    {
        string addressString = _address.DisplayAddress();
        string dateString = _date.ToString("yyyy-MM-dd");
        string timeString = _time.ToString("HH:mm");

        string fullDetails = $"----------\n{_eventTitle}\n{_description}\n{dateString}, {timeString}\n{addressString}";
        return fullDetails;
    }

    public virtual string ShortDetails()
    {
        string addressString = _address.DisplayAddress();
        string dateString = _date.ToString("yyyy-MM-dd");
        string timeString = _time.ToString("HH:mm");

        string shortDetails = $"{addressString}\n{dateString}, {timeString}";
        return shortDetails;
    }
}
