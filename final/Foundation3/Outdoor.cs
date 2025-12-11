using System;

class Outdoor : Event
{
    string _weather;

    public Outdoor(string eventTitle, string description, DateTime date, TimeSpan time, Address address, string weather) : base(eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        string addressString = _address.DisplayAddress();
        string dateString = _date.ToString("yyyy-MM-dd");
        string timeString = _time.ToString();
        string eventType = "Outdoor";

        string fullDetails = $"----------\n{_eventTitle}\nDescription: {_description}\nEvent Type: {eventType}\nWeather: {_weather}\nDate: {dateString}, {timeString}\nAddress: {addressString}";
        return fullDetails;
    }

    public override string ShortDetails()
    {
        string eventType = "Outdoor";
        string dateString = _date.ToString("yyyy-MM-dd");
        string shortDetails = $"Event Type: {eventType}\nTitle: {_eventTitle}\nDate: {dateString}";
        return shortDetails;
    }
}