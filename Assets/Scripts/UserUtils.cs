using System;
using System.Collections.Generic;

public class UserUtils
{
    private static Random s_random = new Random();

    public static T GetRandomValueFromList<T>(List<T> list)
    {
        int index = s_random.Next(list.Count);
        return list[index];
    }
}