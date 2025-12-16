using System;

class Running : Activity
{
    protected double _distance;

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = (_distance / _duration) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _duration / _distance;
        return pace;
    }

    public override string getSummary()
    {
        // double distance = _distance;
        double speed = this.GetSpeed();
        double pace = this.GetPace();
        string dateString = this.convertDate();

        string fullString = $"{dateString} Running ({_duration} min)-Distance: {_distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
        return fullString;
    }
}