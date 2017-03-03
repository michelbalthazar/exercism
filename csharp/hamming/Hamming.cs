public class Hamming
{
    public static int Compute(string dna1, string dna2)
    {
        int ret = 0;
        foreach (var dnaTeste1  in dna1)
            foreach(var dnaTeste2 in dna2)
            {
                if(dnaTeste1 == dnaTeste2)
                    ret++;
            }
            return ret;
    }        
}