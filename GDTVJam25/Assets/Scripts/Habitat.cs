using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Habitat : MonoBehaviour
{

    public bool Rainforest;
    public bool Desert;
    public bool Water;
    public int Multiplier;

    public DragDrop.terraType[] ToTypes()
    {
        var types = new List<DragDrop.terraType>();
        if (Rainforest) types.Add(DragDrop.terraType.rainforest);
        if (Desert) types.Add(DragDrop.terraType.desert);
        if (Water) types.Add(DragDrop.terraType.water);
        return types.ToArray();
    }
    public int GetScore(DragDrop.terraType type)
    {
        var types = ToTypes();
        if (!types.Contains(type)) return 0;
        return Multiplier;
    }

}
