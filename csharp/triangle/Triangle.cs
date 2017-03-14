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
        return TriangleKind.Isosceles;
    }
}

public class TriangleException : Exception { }