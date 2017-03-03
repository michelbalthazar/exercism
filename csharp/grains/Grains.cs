using System;

public class Grains
 {
     
    public static decimal Square(decimal num)
    {
        
        decimal total = 1; 
       for(int i = 1; i < num; i++)
       {
                total *= 2;
       }

        return total;
    }
    public static decimal Total()
    {        
        return Convert.ToUInt64(Square(65) - 1);
    }     
 }
