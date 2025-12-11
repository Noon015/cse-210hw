using System;

class Reception : Event
{
    string _email;

    public Reception(string eventTitle, string description, DateTime date, TimeSpan time,Address address, string email) : base(eventTitle, description, date, time, address)
    {
        _email = email;
    }

    public override string FullDetails()
    {
        string addressString = _address.DisplayAddress();
        string dateString = _date.ToString("yyyy-MM-dd");
        string timeString = _time.ToString();
        string eventType = "Reception";

        string fullDetails = $"----------\n{_eventTitle}\nDescription: {_description}\nEvent Type: {eventType}\nEmail: {_email}\nDate: {dateString}, {timeString}\nAddress: {addressString}";
        return fullDetails;
    }

    public override string ShortDetails()
    {
        string eventType = "Lecture";
        string dateString = _date.ToString("yyyy-MM-dd");
        string shortDetails = $"Event Type: {eventType}\nTitle: {_eventTitle}\nDate: {dateString}";
        return shortDetails;
    }
}