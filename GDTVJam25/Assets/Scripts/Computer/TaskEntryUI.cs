using TMPro;
using UnityEngine;

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
