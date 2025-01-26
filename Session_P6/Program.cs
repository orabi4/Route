namespace TaskSession_P6;

class Program
{
    static void Main(string[] args)
    {
        #region Q2
        
        // Duration duration = new Duration();
        // Console.WriteLine($"Duration = {duration}");
        // Console.WriteLine($"Equal: {duration.Equals(new Duration())}");
        // Console.WriteLine($"HashCode: {duration.GetHashCode()}");

        #endregion
        #region Q3
        Duration d1 =new  Duration (1,10,15);
        Console.WriteLine(d1.ToString());
        Duration D1 =new Duration (3600);
        Console.WriteLine(D1.ToString()); 
        Duration D2 =new Duration (7800);
        Console.WriteLine(D2.ToString());
        Duration D3 =new Duration (666);
        Console.WriteLine(D3.ToString());
        #endregion
        #region Q4
        D3 = D1 + D2;
        Console.WriteLine(D3.ToString());
        D3= D1 + 7800;
        Console.WriteLine(D3.ToString());
        D3 = 666 + D3;
        Console.WriteLine(D3.ToString());
        D3 = ++D1;
        Console.WriteLine(D3.ToString());
        D3 = --D2;
        Console.WriteLine(D3.ToString());
        D1 = D1 - D2;
        Console.WriteLine(D1.ToString());
        if(D1>D2) Console.WriteLine("D1 is greater than D2");
        if(D1<=D2) Console.WriteLine("D1 is less than or equal D2");
        if(D1) Console.WriteLine("D1 is True");
        DateTime obj =(DateTime) D1; // i will make overload operator from type Explicit Casting to convert from Datatype Duration to DateTime

        #endregion

    }
}