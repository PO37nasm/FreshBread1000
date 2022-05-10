using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class F_Bell : MonoBehaviour
{

    FMOD.Studio.EventInstance Bell;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
                Bell = FMODUnity.RuntimeManager.CreateInstance("event:/Boat/BoatBell");
                Bell.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(transform.position));
                Bell.start();
                Bell.release();            
        }
    }
}
