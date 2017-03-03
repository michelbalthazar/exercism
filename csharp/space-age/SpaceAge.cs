using System;

public class SpaceAge
{
    private int _second;

    public SpaceAge(int second)
    {
        this._second = second;
    }

    public int Seconds()
    {
        int age = _second;
        return age;
    }

    public double OnEarth()
    {
        double age = 31557600;
        age = _second / age;

        return age;
    }
}
