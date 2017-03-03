public class Complement
{
     public static string OfDna(string letters)
     {
            // G -> C
            // C -> G
            // T -> A
            // A -> U
         string ret = "";
         foreach (var letter in letters.ToUpper())
         {
            if (letter == 'C')
                 ret += "G";
            else if ( letter == 'G')
                 ret += "C";
            else if (letter == 'T')
                ret += "A";
            else if (letter == 'A')
                ret += "U";                         
         }
         return ret;     
     }     
}
