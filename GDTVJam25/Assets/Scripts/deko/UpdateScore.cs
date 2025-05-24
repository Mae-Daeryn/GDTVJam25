using System.Linq;
using TMPro;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    public GameObject parentObject;
    public GameObject[] excludeObjects;
    public GameObject TerraPanel;

    public TextMeshProUGUI scoreObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var task = TaskDatabase.currentTask;
        if (task == null)
        {
            scoreObject.text = "Select a Job";
            return;
        }
        var target = task.type;
        long sum = 0;
        for (int i = 0; i < parentObject.transform.childCount; i++)
        {
            GameObject child = parentObject.transform.GetChild(i).gameObject;
            if (excludeObjects.Contains(child)) continue;
            Habitat h = child.GetComponent<Habitat>();
            sum += h.GetScore(target);
        }
        if (TerraPanel.CompareTag(target.ToString()))
        {

            sum *= 2;
        }
        else
        {
            sum /= 2;
        }
        scoreObject.text = $"{sum}/{task.requiredScore}";
    }
}
