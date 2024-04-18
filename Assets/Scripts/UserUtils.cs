using System.Collections.Generic;
using UnityEngine;

public class UserUtils
{
    public static T GetRandomValueFromList<T>(List<T> list)
    {
        int index = Random.Range(0, list.Count);
        return list[index];
    }
}