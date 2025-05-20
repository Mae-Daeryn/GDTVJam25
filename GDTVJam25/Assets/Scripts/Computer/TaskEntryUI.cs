using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TaskEntryUI : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI sender;

    private Task task;
    private ComputerUIManager manager;

    public void Setup(Task t, ComputerUIManager m)
    {
        task = t;
        manager = m;

        titleText.text = t.subject;
        sender.text = t.sender;

    }
}
