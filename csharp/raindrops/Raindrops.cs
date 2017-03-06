using System;
public class Raindrops
{
    public static string Convert(int number)
    {
        string convertToString = "";
        
        if (number % 3 == 0)
            convertToString += "Pling";

        if (number % 5 == 0)
            convertToString += "Plang";

        if (number % 7 == 0)
            convertToString += "Plong";

        if (convertToString == "")
            convertToString = number.ToString();
            
        return convertToString;
    }
}
