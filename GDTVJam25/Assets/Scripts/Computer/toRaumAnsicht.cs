using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class toRaumAnsicht : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData eventData)
    {

        if(GameObject.Find("quest") != null)
        {
            GameObject quest = GameObject.Find("quest");
            quest.gameObject.transform.SetParent(null);
            DontDestroyOnLoad(quest);
        }
        SceneManager.LoadScene(3);
    }
}
