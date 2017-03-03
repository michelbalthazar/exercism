using System;
using System.Collections.Generic;

public class SumOfMultiples
{
    public static int To(int[] numValidador, int numTamanho)
    {
        int sum = 0;    
  
        List<int> listScalable = new List<int>(); 
        for(int i = 0; i < numTamanho; i++)
        {
            listScalable.Add(i);
            if(numTamanho == 20)
            {
                if(listScalable[i] % numValidador[0] == 0 || listScalable[i] % numValidador[1] == 0 || listScalable[i] % numValidador[2] == 0)
                sum += listScalable[i]; 
            }
            else if(listScalable[i] % numValidador[0] == 0 || listScalable[i] % numValidador[1] == 0)
                sum += listScalable[i]; 
            

        }
        return sum;
    }
}
