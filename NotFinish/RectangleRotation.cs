
using System;

public class RectangleRotation : ICodeWars
{
    object ICodeWars.Start()
    {
        return Func(6 ,4);
    }

    public object Func(int x, int y)
    {        
        var angl = Math.PI * 45 / 180.0;   
        var vector = Vector.VecRotation(angl);
        var rectangle = Rectangle.DefaultRectangle(x, y);
        var rotatedRectangle = Rectangle.GetRotatedRectangle(rectangle, vector);
        var res = Rectangle.CountPoints(rotatedRectangle, x,y );
        return res;
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
            Y = coor.X * vector.VY.Y + coor.Y * vector.VY.Y
        };
    }
    
}

public struct Vector
{
    public Coordinates VX, VY;
    
    public static Vector VecRotation(double angle = 0.0)
    {             
        return new Vector
        {
            VX = new Coordinates
            {
               X =  (Math.Cos(angle) * 1) - (Math.Sin(angle) * 0) , 
               Y =  (Math.Cos(angle) * 0) + (Math.Sin(angle) * 1) 
            },

            VY = new Coordinates
            {
               X = (0 * Math.Cos(angle)) - (1 * Math.Sin(angle)),
               Y =  (1 * Math.Cos(angle)) + (0 * Math.Sin(angle))
            }                        
        };
    }

}

public struct Rectangle 
{
    public Coordinates A, B, C, D;

    public Rectangle(Coordinates a, Coordinates b, Coordinates c, Coordinates d)
    {
        A = a; 
        B = b;
        C = c;
        D = d;       
    }

    public static Rectangle DefaultRectangle(int x, int y)
    {
        return new Rectangle
        {
            A = new Coordinates(-(x/2), y/2),
            B = new Coordinates(x/2, y/2),
            C = new Coordinates(x/2, -(y/2)),
            D = new Coordinates(-(x/2), -(y/2))
        };
    }

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

    public static int CountPoints(Rectangle rect, int x , int y)
    {
        int res = 0;
        for(int i = (int)rect.A.X; i < (int)rect.C.X; i++)
        {
            for(int j = (int)rect.D.Y; i < (int)rect.B.Y; i++)
            {                
                if(
                    rect.A.X > i && rect.A.Y > j &&
                    rect.B.X > i && rect.B.Y > j &&
                    rect.C.X > i && rect.C.Y > j &&
                    rect.D.X > i && rect.D.Y > j )
                {
                    res++;
                }
            }
        }

        return res;

        // var ab = Math.Sqrt(Math.Pow(rect.B.X - rect.A.X, 2) + Math.Pow(rect.B.Y - rect.A.Y, 2));
        // var bc = Math.Sqrt(Math.Pow(rect.C.X - rect.B.X, 2) + Math.Pow(rect.C.Y - rect.B.Y, 2));
        
        // var rect2 = new Rectangle
        // {
        //     A = new Coordinates{ X = (int)rect.A.X, Y = Math.Round(rect.A.Y) },
        //     B = new Coordinates{ X = Math.Round(rect.B.X), Y = (int)rect.B.Y },
        //     C = new Coordinates{ X = (int)rect.C.X, Y = Math.Round(rect.C.Y) },
        //     D = new Coordinates{ X = Math.Round(rect.D.X), Y = (int)rect.D.Y },
        // };
        
        // var ab = Math.Sqrt(Math.Pow(rect2.B.X - rect2.A.X, 2) + Math.Pow(rect2.B.Y - rect2.A.Y, 2));
        // var bc = Math.Sqrt(Math.Pow(rect2.C.X - rect2.B.X, 2) + Math.Pow(rect2.C.Y - rect2.B.Y, 2));
        // var s = ab*bc;
        // var gcd = 2 * (GCD(rect2.A) + GCD(rect2.B));        
        // var insidePoints = Convert.ToInt32(s - gcd/2 + 1);
        // var borderPoints = 2 * ab + 2 * bc;        
        // var insidePoints = (ab - 1) * (bc - 1);
        // var res = insidePoints + borderPoints; 
        // return Convert.ToInt32(res);
    }

    public static double GCD(Coordinates coor)
    {       
        var a = (int)coor.X;
        var b = (int)coor.Y;
        while (b != 0) 
        {
            b = a % (a = b);
        }
        
        return a;
    }
}