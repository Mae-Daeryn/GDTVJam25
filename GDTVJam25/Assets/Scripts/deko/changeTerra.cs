using System.Collections.Generic;
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
        if (transform.name == "terra_left")
        {
            // Debug.log(.*)
            switch (TerraPanel.GetComponent<Image>().sprite.name)
            {
                case "Agame-terra_0":
                    TerraPanel.GetComponent<Image>().sprite = Rainforest_Terra;
                    TerraPanel.tag = "rainforest";
                    break;
                case "axolotl-terra_0":
                    TerraPanel.GetComponent<Image>().sprite = Desert_Terra;
                    TerraPanel.tag = "desert";
                    break;
                case "gecko-terra_0":
                    TerraPanel.GetComponent<Image>().sprite = Water_Terra;
                    TerraPanel.tag = "water";
                    break;
            }

        }
        if (transform.name == "terra_right")
        {
            switch (TerraPanel.GetComponent<Image>().sprite.name)
            {
                case "Agame-terra_0":
                    TerraPanel.GetComponent<Image>().sprite = Water_Terra;
                    TerraPanel.tag = "water";
                    break;
                case "axolotl-terra_0":
                    TerraPanel.GetComponent<Image>().sprite = Rainforest_Terra;
                    TerraPanel.tag = "rainforest";
                    break;
                case "gecko-terra_0":
                    TerraPanel.GetComponent<Image>().sprite = Desert_Terra;
                    TerraPanel.tag = "desert";
                    break;
            }
        }


    }
}
