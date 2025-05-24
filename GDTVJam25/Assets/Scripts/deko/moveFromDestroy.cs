using UnityEngine;

public class moveFromDestroy : MonoBehaviour
{

    public RectTransform dropzone;
    public GameObject edit;
    void Start()
    {
        for (int i = 0; i < saveItems.all.Count; i++)
        {
            GameObject child = saveItems.all[i];

            if (child.name.Contains("item"))
            {
                child.GetComponent<DragDrop>().dropzone = dropzone;
                child.GetComponent<DragDrop>().edit = edit;
                child.transform.localScale = new Vector3(600,300,1);
                child.transform.SetParent(dropzone.transform, false);
            }
        }
        saveItems.RemoveList();
    }
}
