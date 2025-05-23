using TMPro;
using UnityEngine;

public class questview : MonoBehaviour
{
    public GameObject SideQuestNone;
    public GameObject SideQuest;
    public TextMeshProUGUI SideTitle;
    public TextMeshProUGUI SideDescription;

    void Start()
    {
        if (TaskDatabase.currentTask == null)
        {
            SideQuest.transform.position = new Vector3(SideQuest.transform.position.x + 10000, SideQuest.transform.position.y, 0);
        }
        else
        {
            SideDescription.text = TaskDatabase.currentTask.description;
            SideTitle.text = TaskDatabase.currentTask.subject;
            SideQuestNone.transform.position = new Vector3(SideQuestNone.transform.position.x + 10000, 0, 0);
        }
    }

    void Update()
    {
        
    }
}
