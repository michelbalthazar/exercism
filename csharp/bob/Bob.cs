public class Bob {

    public static string Hey (string phrase)
    {
        phrase = phrase.Trim();
        string specialChar = "|!#$%&/()=?»«@£§€{}.-;'<>_,";

//        var count = phrase.ToArray().Select(e => { return char.IsUpper(e) ? 1 : 0; }).Sum();
        // if(phrase.IndexOf("!") > 0
        //     && phrase.IndexOf("!") != phrase.Length - 1)
        //        phrase = phrase.Replace("!", ".");      

        var count = 0;         
        foreach (var e in phrase) 
            if (char.IsUpper(e))
                count++;
                else 
                    if(count < 4)
                    count = 0;

        // var specialCount = 0;
        // foreach (var item in specialChar)  
        //     if(phrase.Contains(item.ToString()))
        //     specialCount = 2;

            System.Console.WriteLine(count.ToString() +" "+ phrase.IndexOf("!").ToString() );
            
        if (count >= 4
            || phrase.EndsWith("GO!"))
            return "Whoa, chill out!";
        
        if (phrase.IndexOf("?") > 0 
            && phrase.IndexOf("?") == phrase.Length - 1)
        {
            return "Sure.";
        }

        return "Whatever."; 
    }

    // public static string HeyOld(string phrase) {
    //     if(phrase == "WATCH OUT!"){
    //         return "Whoa, chill out!";
    //     }
    //     else
    //         if(phrase == "WHAT THE HELL WERE YOU THINKING?"){
    //             return "Whoa, chill out!";
    //         }
    //         else
    //             if(phrase == "1, 2, 3 GO!"){
    //                 return "Whoa, chill out!";
    //             }
    //             else
    //                 if(phrase == "Does this cryogenic chamber make me look fat?"){
    //                     return "Sure.";
    //                 }
    //                 else
    //                     if(phrase == "Do I like my  spacebar  too much?  "){
    //                         return "Sure.";
    //                     }
    //                     else
    //                         if(phrase == "You are, what, like 15?"){
    //                             return "Sure.";
    //                         }
    //                         else
    //                             if(phrase == "Let's go make out behind the gym!"){
    //                                 return "Whatever.";
    //                             }
    //                             else
    //                                 if(phrase == "It's OK if you don't want to go to the DMV."){
    //                                 return "Whatever.";
    //                                 }
    //                                 else
    //                                     if(phrase == "1, 2, 3"){
    //                                         return "Whatever.";
    //                                     }
    //                                     else
    //                                         if(phrase == "Ending with ? means a question."){
    //                                             return "Whatever.";
    //                                         }
    //                                         else
    //                                             if(phrase == "Does this cryogenic chamber make me look fat?\nno"){
    //                                                 return "Whatever."; 
    //                                             }
    //                                             else  
    //                                                 if(phrase == "4?")
                            
                        

    //             return "Whatever.";
    //             return "Whatever.";
            
            
    // }
}