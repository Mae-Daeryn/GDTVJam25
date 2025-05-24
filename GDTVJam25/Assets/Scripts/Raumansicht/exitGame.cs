using UnityEngine;
using UnityEngine.EventSystems;

public class exitGame : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Application.Quit();
    }
}
