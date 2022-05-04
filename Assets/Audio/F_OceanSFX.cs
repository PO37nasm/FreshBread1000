using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_OceanSFX : MonoBehaviour
{

    FMOD.Studio.EventInstance OceanSFX;

    void Start()
    {
        OceanSFX = FMODUnity.RuntimeManager.CreateInstance("event:/Enviroment/OceanWaves");
        OceanSFX.start();
        OceanSFX.release();
    }

    private void OnDestroy()
    {
        OceanSFX.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }

}
