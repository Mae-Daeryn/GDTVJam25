using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TaskEntryUI : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI shortDescriptionText;
    public Button acceptButton;
    public Button declineButton;

    private Task task;
    private ComputerUIManager manager;

    public void Setup(Task t, ComputerUIManager m)
    {
        task = t;
        manager = m;

        titleText.text = t.title;
        shortDescriptionText.text = t.shortDescription;

        acceptButton.onClick.AddListener(() => manager.Accept(task));
        declineButton.onClick.AddListener(() => manager.Decline());
        GetComponent<Button>().onClick.AddListener(() => manager.ShowDescription(t));
    }
}
