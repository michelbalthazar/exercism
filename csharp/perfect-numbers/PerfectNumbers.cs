using System;

public enum NumberType
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static NumberType Classify(int number)
    {
       NumberType result;
       int sum = 0;
       for(int i = 0; i <= number; i++)
       {
           if(number % i == 0)
           {
                sum += 1;
           }
       }
       if(sum == number)
        return Enum.GetNames.GetType.Perfect;

        return result;
    }
}
