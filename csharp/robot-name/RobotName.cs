using System;

public class Robot
{
    public string Name
    {
        get
        {
            return @"[A-Z]{2}\d{3}";
        }
    }

    public void Reset()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}