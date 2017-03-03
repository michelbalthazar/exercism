using System;

public class SumOfMultiples
{
    public static int To(int[] num, int num2)
    {
        int sum = 0;
        // int[4] array; 
        int[] array;
        array = new int[4];
        
        for(int i = 0; i < 4; i++)
        {
            array[i] = i;
            if(array[i] % 3 == 0 || array[i] % 5 == 0)
                sum = sum + i;           
        }
        return sum;
    }
}
