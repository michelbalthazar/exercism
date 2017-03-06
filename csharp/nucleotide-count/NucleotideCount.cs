using System;
using System.Collections.Generic;

public class DNA
{
    private string _nucleo;
    public DNA(string nucleo)
    {
       this._nucleo = nucleo;
    }
  
    public Dictionary<char, int> NucleotideCounts()
    {
        
        return new Dictionary<char, int> { { 'A', Count('A') }, { 'T', Count('T')} , { 'C', Count('C') }, { 'G', Count('G') } };       
    }

    internal int Count(char v)
    {      
        
        int count = 0;
        foreach(var validateDna in _nucleo)
        {
            if(validateDna == v)
                count++;
                
           if(v != 'A' && v != 'C' && v != 'T' && v != 'G')  
             throw new InvalidNucleotideException();
        }
        
               
        return count;
    }
}