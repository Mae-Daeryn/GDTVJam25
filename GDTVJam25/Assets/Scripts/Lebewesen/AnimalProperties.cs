using System.Linq;
using UnityEngine;

public class AnimalProperties : MonoBehaviour
{
    [SerializeField]
    public GameObject[] PLUS;
    [SerializeField]

    public GameObject[] MINUS;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


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
