using TMPro;
using UnityEngine;

public class UpdateMoney : MonoBehaviour
{
    public TextMeshProUGUI textObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textObject.text = $"{MoneyManager.Money}";
    }
}
