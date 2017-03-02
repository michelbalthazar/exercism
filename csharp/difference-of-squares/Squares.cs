using System;
public class Squares
{
    private int _num;

    public Squares(int num)
    {
       this._num = num;
    }
    
    public int SquareOfSums ()
    {
        int sum = 0;

        for(int i = 0; i <= _num; i++)
            sum += i;
        
        return sum * sum;
    }

    public int SumOfSquares()
    {
        int sum = 0;
        for(int i = 0; i <= _num; i++)
            sum += i*i;
        
        return sum;
    }
}