using UnityEngine;
using UnityEngine.UI;

public class musicAtSceneChange : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Slider>().value = staticmusic.volume;
    }

}
