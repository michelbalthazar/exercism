using System;

public class SpaceAge
{
    private double _second;

    public SpaceAge(double second)
    {
        this._second = second;
    }

    public double Seconds()
    {
        double age = _second;
        return age;
    }

    public double OnEarth()
    {
        double age = 31557600;
        age = _second / age;
        return age;
    }

    public double OnMercury()
    {
        double age = 7600543.81992;
        age = _second / age;
        return age;
    }

    public double OnVenus()
    {
        double age = 19414149.052176;
        age = _second / age;
        return age;
    }

    public double OnMars()
    {
        double age = 59354032.69008;
        age = _second / age;
        return age;
    }

    public double OnJupiter()
    {
        double age = 374355659.124;
        age = _second / age;
        return age;
    }

    public double OnSaturn()
    {
        double age = 929292362.8848;
        age = _second / age;
        return age;
    }

    public double OnUranus()
    {
        double age = 2651370019.3296;
        age = _second / age;
        return age;
    }

    public double OnNeptune()
    {
        double age = 5200418560.032;
        age = _second / age;
        return age;
    }
}
