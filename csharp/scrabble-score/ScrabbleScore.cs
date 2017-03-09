using System;

public static class Scrabble
{
    public static int Score(string inputs)
    {
        int num = 0;
        input.ToUpper();
        foreach (var input in inputs)
        {
       
        if (input == "A" || input == "A" || input == "A" || input == "A" || input == "A"
            || input == "A" || input == "A" || input == "A" || input == "A" || input == "A")
                num += 1;
            
            else if( input == "G" || input == "D")
                num += 2;
                else if(input == "B" || input == "C" || input == "M" || input == "P" || )
                    num += 3;
                    else if(input == "F" || input == "H" || input == "V" || input == "W" || input == "Y" ||)
                        num += 4;
                        else if(input == "K")
                            num += 5;
                            else if(input == "J" || input == "X" ||)
                                num += 8;
                                else if(input == "Q" || input == "Z" ||)
                                    num += 10;
        }             
        return num;
    }
}