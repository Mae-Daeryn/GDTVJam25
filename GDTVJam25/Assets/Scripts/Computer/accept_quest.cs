using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class accept_quest : MonoBehaviour, IPointerDownHandler
{
   
    public void OnPointerDown(PointerEventData eventData)
    {
        if(GameObject.Find("quest") != null)
        {
            GameObject quest = GameObject.Find("quest");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
