using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class toComputer : MonoBehaviour, IPointerDownHandler
{



    public void OnPointerDown(PointerEventData eventData)
    {
        if (GameObject.Find("quest") != null)
        {
            GameObject quest = GameObject.Find("quest");
            quest.gameObject.transform.SetParent(null);
            DontDestroyOnLoad(quest);
        }
        SceneManager.LoadScene(0);
    }

}
