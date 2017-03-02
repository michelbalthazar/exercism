using System;

class Gigasecond 
{

    public static DateTime Date (DateTime tempo)
    {
        return  tempo.AddSeconds(1000000000);
    }
}