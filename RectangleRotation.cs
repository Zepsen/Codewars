
using System;

public class RectangleRotation : ICodeWars
{
    object ICodeWars.Start()
    {
        return Func(6, 4);
    }

    public static object Func(int x, int y)
    {        
        var vectorRotation = Vector.VecRotation(45);
        return null;
    }

    
}

// X,Y Coordinates
public struct Coordinates
{
    public double X, Y;

    public Coordinates(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static Coordinates RotateCoordinates(Coordinates coor, Vector vector)
    {
        return new Coordinates
        {
            X = coor.X * vector.VX.X + coor.Y * vector.VY.X,
            Y = coor.X * vector.VY.X + coor.Y * vector.VY.Y
        };
    }
    
}

public struct Vector
{
    public Coordinates VX, VY;
    public Vector(Coordinates x, Coordinates y)
    {
        VX = x;
        VY = y;
    }
    
    public static Vector VecRotation(int angle = 0)
    {
        return new Vector
        {
            VX = new Coordinates
            (
                1 * Math.Cos(angle) + 0 * Math.Sin(angle), 
                0 * Math.Cos(angle) - 1 * Math.Sin(angle) 
            ),

            VY = new Coordinates
            (
                0 * Math.Cos(angle) + 1 * Math.Sin(angle),
                1 * Math.Cos(angle) - 0 * Math.Sin(angle)
            )                        
        };
    }

}

public struct Rectangle 
{
    public Coordinates A, B, C, D;

    public static Rectangle GetRotatedRectangle(Rectangle rect, Vector vector)
    {
        return new Rectangle
        {
            A = Coordinates.RotateCoordinates(rect.A, vector),              
            B = Coordinates.RotateCoordinates(rect.B, vector),  
            C = Coordinates.RotateCoordinates(rect.C, vector),  
            D = Coordinates.RotateCoordinates(rect.D, vector)
        };
    }
}