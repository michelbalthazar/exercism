using System;

public class School
{
    private string _nome {get; set;}
    private int _grade {get; set;} 
    public School ()
    {
        
    }

    public int Roster (int grade)
    {
        this._grade = grade;
        return _grade;
    }
    
    public int Count (int counter)
    {
        return counter;
    }

    internal void Add(string v1, int v2)
    {
        throw new NotImplementedException();
    }
}