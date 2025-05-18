using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComputerUIManager : MonoBehaviour
{
    public GameObject taskButtonPrefab; // Prefab mit AuftragEintragUI
    public Transform contentParent;        // Inhalt der ScrollView
    public TextMeshProUGUI descriptionText; // Infotext

    private Task currentlySelected;

    void Start()
    {
        foreach (var task in TaskDatabase.All)
        {
            GameObject entry = Instantiate(taskButtonPrefab, contentParent);
            entry.GetComponent<TaskEntryUI>().Setup(task, this);
        }
    }

    public void ShowDescription(Task task)
    {
        currentlySelected = task;
        descriptionText.text = task.description;
    }

    public void Accept(Task task)
    {
        Debug.Log("Task accepted: " + task.title);
        // z.?B. speichern im GameManager oder n�chste Szene laden
        // GameManager.Instance.aktiverAuftrag = auftrag;
        SceneManager.LoadScene("TerrariumSelect"); // oder was auch immer
    }

    public void Decline()
    {
        currentlySelected = null;
        descriptionText.text = "";
    }
}
