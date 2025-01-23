namespace TaskSession_P5;

public class Point3D:ICloneable, IComparable
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public Point3D(double x, double y):this(x,y,0){}
    public Point3D() : this(0,0,0){}
    public override string ToString()
    {
       return $"Point Coordinates: ({X}, {Y}, {Z})";
    }

    public int CompareTo(object? obj)
    {
        Point3D? others=(Point3D?)obj;
        if (others == null) return 1;
        if (this.X > others.X && this.Y > others.Y) return 1;
        else if (this.X < others.X && this.Y < others.Y) return -1; 
        return 0;
    }

    public object Clone()
    {
        return new Point3D()
        {
           X=this.X,
           Y=this.Y,
           Z=this.Z
        };
    }

    public void ReadPointFromUser()
    {
        Console.WriteLine("Please Enter the (x,y,z) for the Two point");
        Console.Write("Enter x: ");
        X = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        Y = double.Parse(Console.ReadLine());
        Console.Write("Enter z: ");
        Z = double.Parse(Console.ReadLine());
    }
    
}