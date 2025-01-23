namespace TaskSession_P5;

public class Duration
{
    public int Minutes { get; set; }
    public int Seconds { get; set; }
    public int Hours { get; set; }

    public Duration(int hours, int minutes, int seconds )
    {
        Minutes = minutes;
        Seconds = seconds;
        Hours = hours;
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

    public Duration()
    {
        
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
}