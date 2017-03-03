using System;

public class Hamming
{
    public static int Compute(string dna1, string dna2)
    {
        int validar = 0;
        
        if (dna1.Length != dna2.Length)
        {
            // -1 = erro de tamanho de DNA
             return -1;
        }

        for (int i = 0; i < dna1.Length; i++)
        {
            if (dna1[i] != dna2[i])
            {
                validar++;
            }
        }

        return validar;
    }       
}