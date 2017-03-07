using System;
using System.Collections.Generic;

public class School
{
    public Dictionary<int, List<string>> _roster = new Dictionary<int, List<string>>();

    public Dictionary<int, List<string>> Roster
    {
        get
        {    
            return _roster;
        }

    }
     public void Add(string nome, int grade)
    {
        if(!_roster.ContainsKey(grade))
            _roster.Add(grade, new List<string>());
            _roster[grade].Add(nome);
            _roster[grade].Sort();
    }
    public List<string> Grade (int grade)
    {
        if(!_roster.ContainsKey(grade))
            _roster.Add(grade, new List<string>());
            List<string> alunos = Roster [grade];

        return alunos;
    }
}