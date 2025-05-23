using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SubmitJob : MonoBehaviour
{
    public Button button;
    public GameObject parentObject;
    public GameObject[] excludeObjects;
    public DragDrop.terraType target;

    void Start()
    {
        button.onClick.AddListener(ButtonClicked);
    }

    void ButtonClicked()
    {
        long sum = 0;
        for (int i = 0; i < parentObject.transform.childCount; i++)
        {
            GameObject child = parentObject.transform.GetChild(i).gameObject;
            if (excludeObjects.Contains(child)) continue;
            Habitat h = child.GetComponent<Habitat>();
            sum += h.GetScore(target);
        }
        Debug.Log(sum);
    }
}
