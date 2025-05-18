using System.Collections.Generic;
using UnityEngine;

public class Habitat : MonoBehaviour
{

    public bool Rainforest;
    public bool Desert;
    public bool Water;

    public TerrariumType[] ToTypes()
    {
        var types = new List<TerrariumType>();
        if (Rainforest) types.Add(TerrariumType.Rainforest);
        if (Desert) types.Add(TerrariumType.Desert);
        if (Water) types.Add(TerrariumType.Water);
        return types.ToArray();
    }

}
