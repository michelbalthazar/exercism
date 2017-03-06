using System;
using System.Collections.Generic;
public static class AccumulateExtension
{
    public static IEnumerable<int> Accumulate(this IEnumerable<int> numbers, Func<int, int> accumulateFunction )
    {
        foreach(var num in numbers)
        {
            yield return accumulateFunction(num);            
        }
    }
  
    public static IEnumerable<string> Accumulate(this IEnumerable<string> phrase, Func<string, string> accumulateFunction)
    {
         var ret = new List<string>();

         foreach(var letter in phrase)
             ret.Add(accumulateFunction(letter));

        return ret;
    }
}