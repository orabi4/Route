using System.Diagnostics;

namespace TaskSession_P2;

public struct St_Point
{
    #region Attributes

    private double x;
    private double y;

    #endregion
    #region Methods

    public St_Point(double X, double Y)
    {
        x = X;
        y = Y;
    }

    public double CalculateDistance
    {
        get { return Math.Sqrt(x * x + y * y); }
    }
    #endregion
}