using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    public RectTransform targetRect;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

        if (rectTransform.tag == "Items")
        {
            RectTransform clone = Instantiate(rectTransform, rectTransform.parent);
            rectTransform.name = clone.name;
            clone.name = "item";
            rectTransform.tag = "used_Items";
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 MousePos = Input.mousePosition;
        rectTransform.position = MousePos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Image image = rectTransform.GetComponent<Image>();
        image.color = Color.red;
        if(!RectTransformUtility.RectangleContainsScreenPoint(targetRect, Input.mousePosition, eventData.pressEventCamera)) {
            Destroy(rectTransform.gameObject);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    
}
