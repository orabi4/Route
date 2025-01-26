using System.Data.SqlTypes;

namespace TaskSession_P6;

public class Duration
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    public Duration()
    {
        
    }
    public Duration(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
    public Duration(int NumberInSeconds)
    {
        Hours = NumberInSeconds / 3600;
        Minutes = (NumberInSeconds % 3600) / 60;
        Seconds = NumberInSeconds % 60;
        
        if (Seconds >= 60)
        {
            Minutes += Seconds / 60;
            Seconds %= 60;
        }

        if (Minutes >= 60)
        {
            Hours += Minutes / 60;
            Minutes %= 60;
        }
    }
    
    public override string ToString()
    {
        return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Duration other) return Minutes==other.Minutes&&Seconds==other.Seconds&&Hours==other.Hours;
        return false;
    
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Minutes, Seconds, Hours);
    }

    public static Duration operator +(Duration left, Duration right)
    {
        return new Duration()
        {
            Hours = (left?.Hours??0) + (right?.Hours??0),
            Minutes = (left?.Minutes??0) + (right?.Minutes??0),
            Seconds = (left?.Seconds??0) + (right?.Seconds??0)
        };
    }
    public static Duration operator +(Duration left,int number)
    {
        return new Duration()
        {
            Hours = (left?.Hours??0) + (number>0?number:0),
            Minutes = (left?.Minutes??0) + (number>0?number:0),
            Seconds = (left?.Seconds??0) + (number>0?number:0)
        };
    }
    public static Duration operator +(int number,Duration right)
    {
        return new Duration()
        {
            Hours = (right?.Hours??0) + (number>0?number:0),
            Minutes = (right?.Minutes??0) + (number>0?number:0),
            Seconds = (right?.Seconds??0) + (number>0?number:0)
        };
    }
    public static Duration operator ++(Duration duration)
    {
        return new Duration()
        {
            Minutes = duration?.Minutes+1??0,
            Seconds = duration?.Seconds??0,
            Hours = duration?.Hours??0
        };
    }
    public static Duration operator --(Duration duration)
    {
        return new Duration()
        {
            Minutes = duration?.Minutes-1??0,
            Seconds = duration?.Seconds??0,
            Hours = duration?.Hours??0
        };
    }
    public static Duration operator -(Duration left, Duration right)
    {
        return new Duration()
        {
            Hours = (left?.Hours??0) - (right?.Hours??0),
            Minutes = (left?.Minutes??0) - (right?.Minutes??0),
            Seconds = (left?.Seconds??0) - (right?.Seconds??0)
        };
    }
    public static bool operator >(Duration left, Duration right)
    {
        return (left.Hours == right.Hours) ? (left.Minutes==right.Minutes) ? (left.Seconds>right.Seconds) : (left.Minutes>right.Minutes) : (left.Hours>right.Hours);
    }
    public static bool operator <(Duration left, Duration right)
    {
        return (left.Hours == right.Hours) ? (left.Minutes==right.Minutes) ? (left.Seconds<right.Seconds) : (left.Minutes<right.Minutes) : (left.Hours<right.Hours);
        
    }
    public static bool operator <=(Duration left, Duration right)
    {
        return left.Hours <= right.Hours||left.Minutes <= right.Minutes||left.Seconds <= right.Seconds;
    }
    public static bool operator >=(Duration left, Duration right)
    {
        return left.Hours >= right.Hours||left.Minutes >= right.Minutes||left.Seconds >= right.Seconds;
    }

    public static bool operator true(Duration duration)
    {
        return duration.Hours!=0||duration.Minutes!=0||duration.Seconds!=0;
    }
    public static bool operator false(Duration duration)
    {
        return duration.Hours==0&&duration.Minutes==0&&duration.Seconds==0;
    }

    public static explicit operator DateTime(Duration duration)
    {
       return new DateTime(duration.Hours, duration.Minutes, duration.Seconds);
    }
    
    
    
}