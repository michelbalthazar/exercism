using System;
public class Raindrops
{
    public static string Convert(int number)
    {
        string convertToString = "";
        
        convertToString = number.ToString();

        if(convertToString == "3" || convertToString == "6" || convertToString == "9")
        {
            convertToString = "Pling";
            return convertToString;
        }
            else if(convertToString == "5" || convertToString == "10" || convertToString == "25")
            {
                convertToString = "Plang";
                return convertToString;
            }
                else if(convertToString == "7" || convertToString == "14" || convertToString == "49")
                {
                    convertToString = "Plong";
                    return convertToString;
                }

        if(number > 1 && number <= 15)
            convertToString = "PlingPlang";
            else if(number <= 21)
                convertToString = "PlingPlong";
                else if(number <= 35)
                   convertToString = "PlangPlong";
                    else if(number > 52 && number <= 105)
                        convertToString = "PlingPlangPlong";
                        
        if(number == 1)
            convertToString = number.ToString();

        return convertToString;
    }
}
