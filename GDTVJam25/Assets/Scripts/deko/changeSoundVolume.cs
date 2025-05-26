using UnityEngine;

public class changeSoundVolume : MonoBehaviour
{ 

    void Start()
    {
        gameObject.GetComponent<AudioSource>().volume = staticmusic.volume;
    }

}
