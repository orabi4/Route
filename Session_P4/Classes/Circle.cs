using TaskSession_P4.Interfaces;

namespace TaskSession_P4.Classes;

public class Circle:ICircle
{
    public double Area { get; set; }
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public double CalculateArea()
    {
       return Area=Math.PI*Radius*Radius;
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"AreaOfCircle: {CalculateArea()} Radius: {Radius}");
    }
}