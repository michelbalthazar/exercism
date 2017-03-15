using System;

public static class Beer
{
    private static string[] _song = new string[] 
            {
                "8 bottles of beer on the wall, 8 bottles of beer.\nTake one down and pass it around, 7 bottles of beer on the wall.\n",

                "7 bottles of beer on the wall, 7 bottles of beer.\nTake one down and pass it around, 6 bottles of beer on the wall.\n",

                "6 bottles of beer on the wall, 6 bottles of beer.\nTake one down and pass it around, 5 bottles of beer on the wall.\n",

                "5 bottles of beer on the wall, 5 bottles of beer.\nTake one down and pass it around, 4 bottles of beer on the wall.\n",

                "4 bottles of beer on the wall, 4 bottles of beer.\nTake one down and pass it around, 3 bottles of beer on the wall.\n",

                "3 bottles of beer on the wall, 3 bottles of beer.\nTake one down and pass it around, 2 bottles of beer on the wall.\n",

                "2 bottles of beer on the wall, 2 bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.\n",

                "1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.\n",

                "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.\n"
            };
    public static string Verse(int number)
    {

        foreach(var item in _song)
        {
            if(item.StartsWith(number.ToString()))
            {
                return item;
            }

        }
        return _song[_song.Length - 1];
    }

    public static string Sing(int start, int stop)
    {
         foreach(var item in _song)
            {
                if(item.Contains(start.ToString()) && item.Contains(start.ToString()))
                {
                    for(int i = start; i <= stop; i++)
                        return item;
                }

            }
            return _song[_song.Length - 1];
    }
}