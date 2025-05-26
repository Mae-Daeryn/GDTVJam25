using UnityEngine;
using UnityEngine.EventSystems;

public class select : MonoBehaviour, IPointerDownHandler
{

    private RectTransform rectTransform;
    public GameObject edit;
    public GameObject selected = null;

    public GameObject trash;
    public GameObject rotate_left;
    public GameObject rotate_right;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // // Debug.log(.*)

        if (eventData.pointerCurrentRaycast.gameObject == trash)
        {
            // // Debug.log(.*)
            Destroy(selected);
            Vector3 posi = edit.transform.position;
            posi.y = -1000f;
            edit.transform.position = posi;
            MoneyManager.Money += selected.GetComponent<DragDrop>().costs;
        }
        if (eventData.pointerCurrentRaycast.gameObject == this.gameObject)
        {
            Vector3 pos = edit.transform.position;
            pos.y = -1000f;
            edit.transform.position = pos;
            selected = null;
        }
        else if (eventData.pointerCurrentRaycast.gameObject == rotate_left)
        {
            selected.transform.rotation *= Quaternion.Euler(0f, 0f, 22.5f);
        }
        else if (eventData.pointerCurrentRaycast.gameObject == rotate_right)
        {
            selected.transform.rotation *= Quaternion.Euler(0f, 0f, -22.5f);
        }
        else if (eventData.pointerCurrentRaycast.gameObject != rectTransform.gameObject)
        {
                if (eventData.pointerCurrentRaycast.gameObject != edit)
                {
                    selected = eventData.pointerPressRaycast.gameObject;
                    edit.transform.position = selected.gameObject.transform.position;
                    Vector3 pos = edit.transform.position;
                    pos.y = selected.transform.position.y + 150f;
                    edit.transform.position = pos;
                }




            
        }
    }
}
