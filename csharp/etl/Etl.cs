using System;
using System.Collections.Generic;

public class ETL
{
    public Dictionary<int, List<string>> _etl = new Dictionary<int, List<string>> ();
    public void AddList (int key, string value)
    {
        if(this._etl.ContainsKey (key))
        {
            List<string> list = this._etl [key];
            if (list.Contains (value) == false)
                list.Add (value);
        }
        else
        {
            List<string> list = new List<string>();
            list.Add(value);
            this._etl.Add (key, list);
        }
    }

    internal static object Transform(Dictionary<int, IList<string>> old)
    {
        
       
        return old;
    }
}