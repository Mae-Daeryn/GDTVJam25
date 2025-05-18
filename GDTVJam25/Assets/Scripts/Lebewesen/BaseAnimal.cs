using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAnimal
{
    public List<GameObject> PLUS;
    public List<GameObject> MINUS;

    public int GetPointsForObject(GameObject go)
    {
        int i = 0;
        if (PLUS.Contains(go))
        {
            i = 1;
        }
        else if (MINUS.Contains(go))
        {
            i = -1;
        }
        return i;
    }
    public int GetPointsForAllObjects(GameObject[] gos)
    {
        int sum = 0;
        foreach (var go in gos)
        {
            sum += GetPointsForObject(go);
        }
        return sum;
    }
}
