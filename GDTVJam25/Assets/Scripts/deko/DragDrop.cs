using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IPointerClickHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    public RectTransform dropzone;
    public GameObject edit;

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
        rectTransform.transform.SetParent(dropzone);

    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 MousePos = Input.mousePosition;
        rectTransform.position = MousePos;

        if(rectTransform.transform.parent == dropzone)
        {
            edit.transform.position = rectTransform.gameObject.transform.position;
            Vector3 pos = edit.transform.position;
            pos.y = rectTransform.transform.position.y + 100f;
            edit.transform.position = pos;
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Image image = rectTransform.GetComponent<Image>();
        if(!RectTransformUtility.RectangleContainsScreenPoint(dropzone, Input.mousePosition, eventData.pressEventCamera)) {
            Destroy(rectTransform.gameObject);
            Vector3 pos = edit.transform.position;
            pos.y = -1000f;
            edit.transform.position = pos;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
    }

    
}
