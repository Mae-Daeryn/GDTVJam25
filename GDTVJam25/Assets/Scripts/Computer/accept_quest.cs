using UnityEngine;
using UnityEngine.UI;

public class accept_quest : MonoBehaviour
{

    public Button accept;
    public GameObject manager;

    void Start()
    {
        accept.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        if (TaskDatabase.currentTask == null)
        {
            ComputerUIManager mng = manager.GetComponent<ComputerUIManager>();
            TaskDatabase.currentTask = mng.selected;
            mng.SideQuest.transform.position = new Vector3(mng.SideQuest.transform.position.x - 10000, mng.SideQuest.transform.position.y, 0);
            mng.SideQuestNone.transform.position = new Vector3(mng.SideQuest.transform.position.x + 10000, mng.SideQuest.transform.position.y, 0);


            mng.SideDescription.text = TaskDatabase.currentTask.description;
            mng.SideTitle.text = TaskDatabase.currentTask.subject;


            this.gameObject.GetComponent<Image>().color = new Color((float)171 / 255, (float)171 / 255, (float)171 / 255);
        }
        else
        {
        }
    }

}
