using System;

public static class Beer
{
    public static string Verse(int number)
    {
        int numberTo = number;
        numberTo -= 1;
        
            string song1, song2;
            // song1 = number.ToString() + " bottles of beer on the wall, " + number.ToString() 
            // + " bottles of beer.\nTake one down and pass it around, ";
            // song2 = numberTo.ToString() + "bottles of beer on the wall.\n";
            
            song1 = number.ToString() + " bottles of beer on the wall, " + 
            number.ToString() + " bottles of beer.\nTake one down and pass it around, " + 
            numberTo.ToString() + " bottles of beer on the wall.\n";

            // if(number == 0)
            // {
            //     song1.Replace("*", number1);
            //     song2.Replace("/", number2);
            //     song1 = "* bottles of beer on the wall, * bottles of beer.\nTake one down and pass it around, / bottles of beer on the wall.\n";
            //     song2 = "/ bottles of beer on the wall.\n";
            //     number = 99;
            // }

    string teste = "testandoS";
    teste.Replace("test", "seils");
            Console.WriteLine("TESTEEEE:  "+ teste.Replace("T", "MM") +"  "+ numberTo);
            return song1;
    }

    public static string Sing(int start, int stop)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}