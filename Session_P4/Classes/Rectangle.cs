using TaskSession_P4.Interfaces;

namespace TaskSession_P4.Classes;

public class Rectangle:IRectangle
{
    public double Area { get; set; }
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double CalculateArea()
    {
        return Area = Length*Width;
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"AreaOfRectangle: {CalculateArea()} Lenth: {Length} Width: {Width}");
    }
    
}