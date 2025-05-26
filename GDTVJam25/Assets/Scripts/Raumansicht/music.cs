using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour 
{

    public static music instance;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Update()
    {
        if(GameObject.Find("musicslider"))
        {
            Slider slider = GameObject.Find("musicslider").GetComponent<Slider>();
            gameObject.GetComponent<AudioSource>().volume = slider.value;
            staticmusic.volume = slider.value;
        }
    }
}
