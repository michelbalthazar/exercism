using System;

public enum TriangleKind
{
    Equilateral,
    Isosceles,
    Scalene
}

public static class Triangle
{
    public static TriangleKind Kind(decimal side1, decimal side2, decimal side3)
    {
        if (!Validate(side1, side2, side3))
            throw new TriangleException();
        if( side1 == side2 && side2 == side3)
        {
            return TriangleKind.Equilateral;    
        }
        if(side1 != side2 && side2 != side3 && side1 != side3)
        {
            return TriangleKind.Scalene;
        }

        return TriangleKind.Isosceles;
    }
    private static bool Validate(decimal a, decimal b, decimal c)
    {
        if (a < 0 || b < 0 || c < 0)
            return false;
        if (a < b + c && b < a + c && c < a + b)
            return true;

        return false;
    }
}

public class TriangleException : Exception { }