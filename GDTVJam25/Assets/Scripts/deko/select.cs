using UnityEngine;
using UnityEngine.EventSystems;

public class select : MonoBehaviour, IPointerDownHandler
{

    private RectTransform rectTransform;
    public GameObject edit;
    private GameObject selected;

    public GameObject trash;
    public GameObject rotate_left;
    public GameObject rotate_right;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("test");

        if (eventData.pointerCurrentRaycast.gameObject == trash)
        {
            Debug.Log("test");
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
            Debug.Log("test");
            if (selected != eventData.pointerCurrentRaycast.gameObject)
            {
                if (eventData.pointerCurrentRaycast.gameObject != edit)
                {
                    if (selected != null)
                    {
                        selected = null;
                    }
                    selected = eventData.pointerPressRaycast.gameObject;
                    edit.transform.position = selected.gameObject.transform.position;
                    Vector3 pos = edit.transform.position;
                    pos.y = selected.transform.position.y + 100f;
                    edit.transform.position = pos;
                }




            }
            else
            {
                Vector3 pos = edit.transform.position;
                pos.y = -1000f;
                edit.transform.position = pos;
                selected = null;
            }

        }
    }
}
