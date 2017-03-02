public class Bob
{
    public static string Hey (string phrase)
    {
       if (string.IsNullOrWhiteSpace(phrase))
            return "Fine. Be that way!";
        
        phrase = phrase.Trim();
        var count = 0;         
        foreach (var e in phrase)
        {
            if (char.IsUpper(e))
                count++;
            else if (count < 4)
                count = 0;
        }

        if (count >= 4 || phrase.EndsWith("GO!"))
            return "Whoa, chill out!";
        
        if (phrase.IndexOf("?") > 0 
            && phrase.IndexOf("?") == phrase.Length - 1)
            return "Sure.";
        
        return "Whatever."; 
    }
}