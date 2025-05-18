using System.Linq;
using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class AnimalProperties : MonoBehaviour
{
    // [SerializeField]
    // public GameObject[] PLUS;
    // [SerializeField]

    // public GameObject[] MINUS;
    [SerializeField]
    public TerrariumTyp[] typ;

    // public int GetPointsForObject(GameObject go)
    // {
    //     int i = 0;
    //     if (PLUS.Contains(go))
    //     {
    //         i = 1;
    //     }
    //     else if (MINUS.Contains(go))
    //     {
    //         i = -1;
    //     }
    //     return i;
    // }
    // public int GetPointsForAllObjects(GameObject[] gos)
    // {
    //     int sum = 0;
    //     foreach (var go in gos)
    //     {
    //         sum += GetPointsForObject(go);
    //     }
    //     return sum;
    // }
}
