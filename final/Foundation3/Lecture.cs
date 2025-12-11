using System;

class Lecture: Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string eventTitle,string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) : base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        string addressString = _address.DisplayAddress();
        string dateString = _date.ToString("yyyy-MM-dd");
        string timeString = _time.ToString();
        string eventType = "Lecture";

        string fullDetails = $"----------\n{_eventTitle}\nDescription: {_description}\nEvent Type: {eventType}\nSpeaker: {_speaker}\nCapacity: {_capacity}\nDate: {dateString}, {timeString}\nAddress: {addressString}";
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