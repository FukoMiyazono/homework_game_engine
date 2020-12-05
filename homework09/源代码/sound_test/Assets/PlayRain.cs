using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRain : MonoBehaviour
{
    public string play = null;
    public string stop = null;
    bool isplaying = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        GameObject mainCamera = GameObject.Find("Main Camera");
        if (isplaying == true)
        {
            AkSoundEngine.PostEvent(stop, mainCamera);
            isplaying = false;
        }
        else
        {
            AkSoundEngine.PostEvent(play, mainCamera);
            isplaying = true;
        }
        
    }
}
