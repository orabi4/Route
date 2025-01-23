using System.Collections.Immutable;
using System;
using System.Runtime.Serialization;

namespace TaskSession_P5;

class Program
{
    static void Main(string[] args)
    {
        #region FirstProject

        // Point3D p = new Point3D(10, 10, 10);
        // Console.WriteLine(p.ToString());
        // //**************************************
        // Point3D p1 = new Point3D();
        // p1.ReadPointFromUser();
        // Point3D p2 = new Point3D();
        // p2.ReadPointFromUser();
        // Console.WriteLine(p1.ToString()); //(6,6,6)
        // Console.WriteLine(p2.ToString());// (6,6,6)
        // Console.WriteLine(p1==p2 ? "The two point are equal":"the two points are not equal"); // NO, It doesn't work 
        // //********************************************
        // Point3D[] ArrayOfPoints =
        // {
        //     new Point3D(12, 11, 10),
        //     new Point3D(8, 7, 6),
        //     new Point3D(7, 6, 5),
        // };
        // Array.Sort(ArrayOfPoints);
        // foreach (var i in ArrayOfPoints)
        // {
        //     Console.WriteLine(i);
        // }
        //
        // p2 =(Point3D) p1.Clone();
        // Console.WriteLine(p2);
        #endregion
        #region SecondProject
        // Maths maths = new Maths();
        // maths.Add(5, 6);
        // maths.Substract(8, 6);
        // maths.Multiply(8, 6);
        // maths.Divide(8, 6);
        // Modify the program so that you do not have to create an instance of class: the solution is to make it abstract class 

        #endregion
        #region ThirdProject

        // Duration duration = new Duration();
        // Console.WriteLine($"Duration = {duration}");
        // Console.WriteLine($"Equal: {duration.Equals(new Duration())}");
        // Console.WriteLine($"HashCode: {duration.GetHashCode()}");
        // Duration d1 =new  Duration (1,10,15);
        // Console.WriteLine(d1.ToString());
        // Duration D1 =new Duration (3600);
        // Console.WriteLine(D1.ToString()); 
        // Duration D2 =new Duration (7800);
        // Console.WriteLine(D2.ToString());
        // Duration D3 =new Duration (666);
        // Console.WriteLine(D3.ToString());


        #endregion
    }
}
