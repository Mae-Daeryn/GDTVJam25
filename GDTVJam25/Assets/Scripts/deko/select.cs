using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class select : MonoBehaviour, IPointerClickHandler
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

    public void OnPointerClick(PointerEventData eventData)
    {


        if (eventData.pointerCurrentRaycast.gameObject == trash)
        {
            Destroy(selected);
            Vector3 posi = edit.transform.position;
            posi.y = -1000f;
            edit.transform.position = posi;
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
            if (selected != eventData.pointerCurrentRaycast.gameObject)
            {
                if(eventData.pointerCurrentRaycast.gameObject != edit)
                {
                if (selected != null)
                {
                    Destroy(selected.GetComponent<Outline>());
                    selected = null;
                }
                selected = eventData.pointerCurrentRaycast.gameObject;
                selected.AddComponent<Outline>().effectColor = Color.yellow;
                selected.GetComponent<Outline>().effectDistance = new Vector2(0.05f, 0.05f);
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
                Destroy(selected.GetComponent<Outline>());
                selected = null;
            }

        }
    }
}
