using System;
using System.Collections.Generic;
using System.Linq;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class Garden
{
    private List<string> _children;
    private Dictionary<string, string> childrenPlants = new Dictionary<string, string>();
    public Garden(IEnumerable<string> children, string windowSills)
    {
        _children = children.ToList();
        _children.Sort();

        var lines = windowSills.Split('\n');
        var count = 0;
        foreach (var child in children)
        {
            childrenPlants[_children.ToArray()[count]] = "";
            foreach (var line in lines)
            {
                childrenPlants[_children.ToArray()[count]] =
                 childrenPlants[_children.ToArray()[count]] + line.Substring(count * 2, 2);
            }

            count += 1;
            if (count >= (windowSills.Length - 1) / 4)
                break;
        }
    }

    public IEnumerable<Plant> GetPlants(string child)
    {
        var isfound = false;
        foreach (var item in _children)
        {
            if (item == child)
                isfound = true;
        }

        if (isfound)
        {
            foreach (var plant in childrenPlants[child])
            {
                foreach (var namePlant in Enum.GetNames(typeof(Plant)))
                {
                    if(namePlant.StartsWith(plant.ToString()))
                        yield return (Plant) Enum.Parse(typeof(Plant), namePlant);
                }
            }
        }
    }

    public static Garden DefaultGarden(string windowSills)
    {
        List<string> names = new List<string>();

        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");
        names.Add("David");
        names.Add("Eve");
        names.Add("Fred");
        names.Add("Ginny");
        names.Add("Harriet");
        names.Add("Ileana");
        names.Add("Joseph");
        names.Add("Kincaid");
        names.Add("Larry");
        Garden jardim = new Garden(names, windowSills);

        return jardim;
    }
}