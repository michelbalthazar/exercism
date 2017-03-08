using System;
using System.Collections.Generic;

public class ETL
{
    internal static Dictionary<string, int> Transform(Dictionary<int, IList<string>> old)
    {
        Dictionary<string, int> expected = new Dictionary<string, int>();

        foreach (var older in old)
        {
            foreach (var item in older.Value)
            {                
                expected.Add(item.ToLower(), older.Key);
            }
        }

        return expected;
    }
}