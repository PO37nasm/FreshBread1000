using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_MenuMusic : MonoBehaviour
{

    FMOD.Studio.EventInstance MenuMusic;

    void Start()
    {
        MenuMusic = FMODUnity.RuntimeManager.CreateInstance("event:/Music/MenuMusic");
        MenuMusic.start();
        MenuMusic.release(); 
    }

    private void OnDestroy()
    {
        MenuMusic.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }
}
