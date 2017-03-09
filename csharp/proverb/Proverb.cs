using System;
using System.Collections.Generic;

public static class Proverb
{
    public static string Line(int line)
    {
        Dictionary<int, string> allPhrase = new Dictionary<int, string>();
        allPhrase.Add(1, "For want of a nail the shoe was lost.");
        allPhrase.Add(2, "For want of a shoe the horse was lost.");
        allPhrase.Add(3, "For want of a horse the rider was lost.");
        allPhrase.Add(4, "For want of a rider the message was lost.");
        allPhrase.Add(5, "For want of a message the battle was lost.");
        allPhrase.Add(6, "For want of a battle the kingdom was lost.");
        allPhrase.Add(7, "And all for the want of a horseshoe nail.");

        if (allPhrase.ContainsKey(line))
            return allPhrase[line];

        return "Failed!";
    }

    public static string AllLines()
    {
        string expected = "";
        int i = 1;
        Dictionary<int, string> allPhrase = new Dictionary<int, string>();
        allPhrase.Add(1, "For want of a nail the shoe was lost.\n");
        allPhrase.Add(2, "For want of a shoe the horse was lost.\n");
        allPhrase.Add(3, "For want of a horse the rider was lost.\n");
        allPhrase.Add(4, "For want of a rider the message was lost.\n");
        allPhrase.Add(5, "For want of a message the battle was lost.\n");
        allPhrase.Add(6, "For want of a battle the kingdom was lost.\n");
        allPhrase.Add(7, "And all for the want of a horseshoe nail.");

        foreach (var item in allPhrase)
        {
            expected += allPhrase[i++];
        }

        return expected;
    }
}