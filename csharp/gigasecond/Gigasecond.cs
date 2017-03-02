using System;

class Gigasecond 
{

    public static DateTime Date (DateTime tempo)
    {
        int secondLive = 1000000000;
        return  tempo.AddSeconds(1000000000);
    }
}