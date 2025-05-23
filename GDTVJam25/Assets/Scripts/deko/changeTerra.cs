using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class changeTerra : MonoBehaviour, IPointerClickHandler
{

    public GameObject TerraPanel;
    public Sprite Rainforest_Terra;
    public Sprite Desert_Terra;
    public Sprite Water_Terra;
    private Dictionary<int, Sprite> images = new Dictionary<int, Sprite>();
    void Start()
    {
        images.Add(0, Rainforest_Terra);
        images.Add(1, Desert_Terra);
        images.Add(2, Water_Terra);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (this.transform.name == "terra_left")
        {
            if (TerraPanel.GetComponent<Image>().sprite.name.Contains("Agame"))
            {
                TerraPanel.GetComponent<Image>().sprite = Rainforest_Terra;
            }
            if (TerraPanel.GetComponent<Image>().sprite.name.Contains("axolotl"))
            {
                TerraPanel.GetComponent<Image>().sprite = Desert_Terra;
            }
            
        }
        if (this.transform.name == "terra_right")
        {
            if (TerraPanel.GetComponent<Image>().sprite.name.Contains("Agame"))
            {
                TerraPanel.GetComponent<Image>().sprite = Water_Terra;
            }
            if (TerraPanel.GetComponent<Image>().sprite.name.Contains("gecko"))
            {
                TerraPanel.GetComponent<Image>().sprite = Desert_Terra;
            }
        }


    }
}
