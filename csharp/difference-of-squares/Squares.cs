using System;
public class Squares
{
    private int _num;

    public Squares(int num)
    {
       this._num = num;
        if (_num < 0 )
        throw new ArgumentOutOfRangeException();
    }
    
    public int SquareOfSums()
    {
        int sum = 0;
        for (int i = 0; i <= _num; i++)
            sum += i;
        
        return sum * sum;
    }

    public int SumOfSquares()
    {
        int sum = 0;
        for (int i = 0; i <= _num; i++)
            sum += i*i;
        
        return sum;
    }
    public int DifferenceOfSquares()
    {
        return SquareOfSums() - SumOfSquares();
    }
}