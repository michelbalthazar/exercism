using System;
using System.Collections.Generic;
public static class AccumulateExtension
{
    public static IEnumerable<m> Accumulate<n, m>(this IEnumerable<n> numbers, Func<n, m> accumulateFunction )
    {
        foreach(var num in numbers)
        {
            yield return accumulateFunction(num);            
        }
    }
}