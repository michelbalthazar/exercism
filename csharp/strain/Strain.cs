using System;
using System.Collections.Generic;
using System.Linq;

public static class Strain
{   
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        List<T> list = new List<T>();

        foreach (var item in collection)
        {
            if(predicate(item))
            {
                list.Add(item); 
                
            }
        }
        return list.AsEnumerable();
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        List<T> list = new List<T>();

        foreach (var item in collection)
        {
            if(!predicate(item))
            {
                list.Add(item); 
                
            }
        }
        return list.AsEnumerable();
    }
    
}