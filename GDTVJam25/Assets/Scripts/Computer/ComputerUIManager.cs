using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.EventSystems.EventTrigger;

public class ComputerUIManager : MonoBehaviour, IPointerDownHandler
{
    public GameObject taskButtonPrefab;
    public Transform contentParent;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI sender;
    public TextMeshProUGUI subject;
    private Dictionary<GameObject, Task> mails = new Dictionary<GameObject, Task>();

    void Start()
    {
        int currentEntry = -1;
        foreach (var task in TaskDatabase.All)
        {
            currentEntry++;
            GameObject entry = Instantiate(taskButtonPrefab, contentParent);
            entry.transform.position = new Vector3(taskButtonPrefab.transform.position.x, taskButtonPrefab.transform.position.y - (currentEntry * 100), 0);
            entry.GetComponent<TaskEntryUI>().Setup(task, this);
            entry.GetComponent<Image>().color = new Color((float)180/255, (float)180 / 255, (float)180 / 255);
            mails.Add(entry, task);
            if (currentEntry == 0)
            {
                entry.GetComponent<Image>().color = Color.white;
                descriptionText.text = task.mailContent;
                sender.text = task.sendermail;
                subject.text = task.subject;
            }
        }
        taskButtonPrefab.transform.position = new Vector3(taskButtonPrefab.transform.position.x + 10000, 0, 0);
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        if (mails.ContainsKey(eventData.pointerCurrentRaycast.gameObject))
        {
            foreach (var mail in mails)
            {
                if (mail.Key == eventData.pointerCurrentRaycast.gameObject)
                {
                    Task t = mail.Value;
                    descriptionText.text = t.mailContent;
                    sender.text = t.sendermail;
                    subject.text = t.subject;
                    mail.Key.GetComponent<Image>().color = Color.white;
                }
                else
                {

                    mail.Key.GetComponent<Image>().color = new Color((float)180 / 255, (float)180 / 255, (float)180 / 255);
                }
            }
        }
        else if(mails.ContainsKey(eventData.pointerCurrentRaycast.gameObject.transform.parent.gameObject))
        {
            GameObject mail = eventData.pointerCurrentRaycast.gameObject.transform.parent.gameObject;
            if(mails.TryGetValue(mail, out Task task))
                {
                Task t = task;
                descriptionText.text = t.mailContent;
                sender.text = t.sendermail;
                subject.text = t.subject;
                foreach (var allmail in mails)
                {
                    allmail.Key.GetComponent<Image>().color = new Color((float)180 / 255, (float)180 / 255, (float)180 / 255);
                }
                    mail.GetComponent<Image>().color = Color.white;
            }

        }
    }
}
