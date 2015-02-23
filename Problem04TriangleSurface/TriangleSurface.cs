//Problem 4. Triangle surface• Write methods that calculate the surface of a triangle by given:
//◦ Side and an altitude to it;
//◦ Three sides;
//◦ Two sides and an angle between them;
//• Use  System.Math .

using System;
using System.Collections.Generic;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Surface with side {0} and altitude {1} to it = {2:F2}", 4, 5, SideAndAltitude(4, 5));
        Console.WriteLine("Surface with three sides {0}, {1}, {2} = {3:F4}", 2, 2, 3, ThreeSides(2, 2, 3));
        Console.WriteLine("Surface with two sides and angle {0}, {1}, {2} = {3:F4}", 20.1, 28.5, 46, SidesAndAngle(20.1, 28.5, 46));
    }
    static double SideAndAltitude(double side, double altitude)
    {
        double result = side * altitude / 2;
        return result;
    }
    static double ThreeSides(double sideA, double sideB, double sideC)
    {
        double semiPerimeter = (sideA + sideB + sideC) / 2;
        double result = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        return result;
    }
    static double SidesAndAngle(double sideA, double sideB, double angle)
    {
        // http://www.mathopenref.com/triangleareasas.html
        //https://msdn.microsoft.com/en-us/library/system.math.sin(v=vs.110).aspx

        angle = Math.PI * angle / 180;
        double result = (sideA * sideB * Math.Sin(angle)) / 2;
        return result;
    }
}
