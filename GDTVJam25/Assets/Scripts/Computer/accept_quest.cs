using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static UnityEngine.UI.Button;

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
        if(TaskDatabase.currentTask != null)
        {
            ComputerUIManager mng = manager.GetComponent<ComputerUIManager>();
            mng.selected = TaskDatabase.currentTask;
        }
        else
        {

        }
    }

}
