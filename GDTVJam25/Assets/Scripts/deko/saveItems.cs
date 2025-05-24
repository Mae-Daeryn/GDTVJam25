using System.Collections.Generic;
using UnityEngine;

public static class saveItems
{

    public static List<GameObject> all = new List<GameObject>();
    public static Dictionary<GameObject, Vector3> sizes = new Dictionary<GameObject, Vector3>();

    public static List<GameObject> getAllItems(GameObject obj)
    {
        return all;
    }

    public static void RemoveList()
    {
        all.Clear();
        sizes.Clear();
    }

    public static void AddToList(GameObject obj)
    {
        all.Add(obj);
        sizes.Add(obj, obj.transform.localScale);
    }

    public static void SaveSize(GameObject obj)
    {
        sizes.Add(obj, obj.transform.localScale);
    }

}
