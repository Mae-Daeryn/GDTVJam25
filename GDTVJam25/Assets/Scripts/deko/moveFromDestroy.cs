using UnityEngine;

public class moveFromDestroy : MonoBehaviour
{

    public GameObject dropzone;
    void Start()
    {
        GameObject dontDestroyContainer = GameObject.Find("DontDestroyOnLoad");
        for (int i = dontDestroyContainer.transform.childCount - 1; i >= 0; i--)
        {
            Transform child = dontDestroyContainer.transform.GetChild(i);

            if (child.name.Contains("item"))
            {
                child.SetParent(dropzone.transform, false);
            }
        }
    }
}
