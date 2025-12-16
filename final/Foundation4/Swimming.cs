using System;

class Swimming : Activity
{
    int _laps;

    public Swimming(DateTime date, int duration, int laps) : base(date,duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = ((_laps * 50) / 1000) * 0.62;
        return distance;
    }

    public override double GetSpeed()
    {
        double distance = this.GetDistance();
        double speed = (distance / _duration) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double speed = this.GetSpeed();
        double pace = 60/speed;
        double roundedPace = Math.Round(pace,2);
        return roundedPace;
    }

    public override string getSummary()
    {
        double distance = this.GetDistance();
        double speed = this.GetSpeed();
        double pace = this.GetPace();
        string dateString = this.convertDate();

        string fullString = $"{dateString} Swimming({_duration} min)-Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
        return fullString;
    }
}