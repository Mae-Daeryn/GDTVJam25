using UnityEngine;

public class quests : MonoBehaviour
{
    void Start()
    {
        if(GameObject.Find("quest") != null) 
        {
            GameObject.Find("quest").transform.SetParent(this.transform);
            GameObject quest = GameObject.Find("quest");
        }
    }

    void Update()
    {
        
    }
}
