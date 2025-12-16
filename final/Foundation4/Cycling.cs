using System;

class Cycling : Activity
{
    protected double _speed;

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = _speed * _duration;
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }

    public override string getSummary()
    {
        double distance = this.GetDistance();
        // double speed = this.GetSpeed();
        double pace = this.GetPace();
        string dateString = this.convertDate();

        string fullString = $"{dateString} Cycling({_duration} min)-Distance: {distance} miles, Speed: {_speed} mph, Pace: {pace} min per mile";
        return fullString;
    }
}