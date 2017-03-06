
using System.Linq;
public class Pangram
{
    public static bool IsPangram(string pangram)
    {
        pangram = pangram.Trim().Replace(".","").Replace("\"","").Replace("_","").Replace("/","");
        if (pangram == "")
            return false;

        string alphabet = "öäüßabcdefghijklmnopqrstuvwxyz";      
        bool ret = false;

        int cont = 0;
       
        foreach (var validaAlphabet in alphabet)
        {
            foreach (var validaPangram in pangram)
            {
                if (validaAlphabet == validaPangram)
                {
                    cont++;
                    break;
                }
                if(cont > 24)
                {
                     ret = true;
                }
                else
                    ret = false;
            }
        
        }

        return ret;

        // return alphabet.All(pangram.ToLower().Contains);

    }           
}
