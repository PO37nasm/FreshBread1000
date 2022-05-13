using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_GameMusic : MonoBehaviour
{

    FMOD.Studio.EventInstance Music;

    void Start()
    {
        Music = FMODUnity.RuntimeManager.CreateInstance("event:/Music/GameMusic");
        Music.start();
        Music.release();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
