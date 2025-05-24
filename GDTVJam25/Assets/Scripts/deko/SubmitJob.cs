using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SubmitJob : MonoBehaviour
{
    public Button button;
    public GameObject parentObject;
    public GameObject[] excludeObjects;
    void Start()
    {
        button.onClick.AddListener(ButtonClicked);
    }

    void ButtonClicked()
    {

        var task = TaskDatabase.currentTask;
        if (task == null)
        {
            // Panel: Kein auftrag angenommen
            return;
        }
        if (ScoreManager.score < task.requiredScore)
        {
            // Panel: Score nicht hoch genug
            return;
        }
        for (int i = 0; i < parentObject.transform.childCount; i++)
        {
            GameObject child = parentObject.transform.GetChild(i).gameObject;
            if (excludeObjects.Contains(child)) continue;
            DragDrop dd = child.GetComponent<DragDrop>();
            MoneyManager.Money += dd.costs;
            Destroy(child);
        }
        MoneyManager.Money += 100;
        SceneManager.LoadScene(3);
        // Panel: Abgegeben
        Debug.Log($"{ScoreManager.score}");
    }
}
