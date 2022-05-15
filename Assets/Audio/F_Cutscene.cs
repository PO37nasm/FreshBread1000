using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_Cutscene : MonoBehaviour
{

    FMOD.Studio.EventInstance CS;

    // Start is called before the first frame update
    void Start()
    {
        CS = FMODUnity.RuntimeManager.CreateInstance("event:/Cutscenes/Cutscene");
        CS.start();
        CS.release();
    }

    private void OnDestroy()
    {
        CS.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }
}
