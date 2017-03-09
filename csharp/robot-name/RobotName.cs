using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
public class Robot
{
    private static Random random = new Random((int)DateTime.Now.Ticks);

    public Robot()
    {
        Reset();
    }

    public string Name
    {
        get;
        private set;
    }

    public void Reset()
    {
        int listaResultado;
        StringBuilder builder = new StringBuilder();


        listaResultado = random.Next(100, 999);
        char ch;
        for (int i = 0; i < 2; i++)
        {
            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
            builder.Append(ch);
        }

        Name = builder.ToString() + listaResultado;
    }
}