using System;
using System.Text.RegularExpressions;

public class Clock
{
    private int _hours;
    private int _minutes;
    public TimeSpan _time { get; private set; }
    public Clock(int hours)
    {
        _hours = hours;
        this._time = new TimeSpan(_hours, 0, 0);
    }

    public Clock(int hours, int minutes)
    {
        _hours = hours;
        _minutes = minutes;
        this._time = new TimeSpan(_hours, _minutes, 0);
    }

    public override string ToString()
    {
        string timeFormat = _time.ToString(@"hh\:mm");

        return timeFormat;
    }

    public Clock Add(int minutesToAdd)
    {
        TimeSpan minutesAdd = TimeSpan.FromMinutes(minutesToAdd);
        this._time = this._time.Add(minutesAdd);

        return this;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        TimeSpan minutesSubtract = TimeSpan.FromMinutes(minutesToSubtract);
        TimeSpan day = TimeSpan.FromTicks(TimeSpan.TicksPerDay);
        this._time = this._time.Add(day).Subtract(minutesSubtract);

        return this;
    }

    // override object.Equals
    public override bool Equals(object obj)
    {

        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        // TODO: write your implementation of Equals() here

        var oTime = ((Clock)obj)._time;
        return _time.Hours.Equals(oTime.Hours) &&
                _time.Minutes.Equals(oTime.Minutes);
    }

    // override object.GetHashCode
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
        throw new System.NotImplementedException();
        return base.GetHashCode();
    }
    public static bool operator ==(Clock a, Clock b)
    {
        return a._time == b._time;
    }
    public static bool operator !=(Clock a, Clock b)
    {
        return a._time != b._time;
    }
}