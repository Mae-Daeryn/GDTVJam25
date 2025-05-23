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
    public GameObject TerraPanel;
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
        if (TerraPanel.CompareTag(target.ToString()))
        {

            sum *= 2;
        }
        else
        {
            sum /= 2;
        }
        MoneyManager.Money += 100;
        if (sum > 100)
        {
            MoneyManager.Money += 50;
        }
        Debug.Log(TerraPanel.tag);
        Debug.Log(target.ToString());
        Debug.Log(sum);
    }
}
