using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class toRaumAnsicht : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData eventData)
    {

        if(SceneManager.GetActiveScene().name == "Dekorieren")
        {
            Transform dropZone = GameObject.Find("DropZone").transform;


            for (int i = dropZone.childCount - 1; i >= 0; i--)
            {
                Transform child = dropZone.GetChild(i);

                if (child.name != "edit")
                {
                    child.SetParent(null);
                    saveItems.AddToList(child.gameObject);
                    DontDestroyOnLoad(child.gameObject);
                }
            }
        }
        SceneManager.LoadScene(3);
    }
}
