public class Year
{
    public static bool IsLeap(int year)
    {
        if(year % 4 == 0){
            return true;
        }
        return false;
    }  
}
