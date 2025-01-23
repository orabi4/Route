namespace TaskSession_P5;

public class Duration
{
    public double Minutes { get; set; }
    public double Seconds { get; set; }
    public double Hours { get; set; }

    public Duration(double minutes, double seconds, double hours)
    {
        Minutes = minutes;
        Seconds = seconds;
        Hours = hours;
    }

    public Duration(double NumberInSeconds)
    {
        Hours = NumberInSeconds / 3600;
        Minutes = (NumberInSeconds % 3600) / 60;
        Seconds = NumberInSeconds % 60;
    }

    public Duration()
    {
        
    }
    public override string ToString()
    {
        return $"Minutes = {Minutes}, Seconds = {Seconds}, Hours = {Hours}";
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
}