using UnityEngine;
using UnityEngine.EventSystems;

public class PlatzierbareObjekt : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Transform originalParent;

    public string objektTyp; // z. B. "Wüstenpflanze", "Deko"

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = Object.FindFirstObjectByType<Canvas>();

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;
        transform.SetParent(canvas.transform);
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;

        if (!eventData.pointerEnter || eventData.pointerEnter.tag != "DropZone")
        {
            transform.SetParent(originalParent); // zurück in Liste
            rectTransform.anchoredPosition = Vector2.zero;
        }
        else
        {
            transform.SetParent(eventData.pointerEnter.transform); // platzieren
        }
    }
}
