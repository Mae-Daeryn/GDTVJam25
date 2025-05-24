using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class toTerras : MonoBehaviour, IPointerDownHandler
{

    public void OnPointerDown(PointerEventData eventData)
    {
        if (GameObject.Find("quest") != null)
        {
            GameObject quest = GameObject.Find("quest");
            quest.gameObject.transform.SetParent(null);
            DontDestroyOnLoad(quest);
        }
        SceneManager.LoadScene(2);
    }

}
