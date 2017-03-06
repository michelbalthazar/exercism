// public class NucleotideCounts
// {
//     char[] _dna;
//     public string DNA(char[] dna)
//     {  
//         this._dna = dna;
//         return "x";
//     }
//     public int Dictionary() 
//     {
//         int count;
//         string[] dictionary = new string[] {"A", "T", "C", "G"};
//         foreach(var validate in DNA())
//         {
//             if(validate == dictionary)
//             count++;
//         }
//         if(count < 1)
//             return "Expected";

//         return "Expected";

//     }       
// }

using System;

public class DNA
{
      private string _nucleo;
    public DNA(string nucleo)
    {
       this._nucleo = nucleo;
    }
  
    public string NucleotideCounts()
    {
        return null;       
    }

    internal object Count(char v)
    {
        throw new NotImplementedException();
    }
}