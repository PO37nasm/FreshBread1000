using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_Creak : MonoBehaviour
{

    FMOD.Studio.EventInstance Creak;

    // Start is called before the first frame update
    void Start()
    {
        Creak = FMODUnity.RuntimeManager.CreateInstance("event:/Boat/BoatCreak");
        Creak.start();
        Creak.release();
    }

    // Update is called once per frame
    void Update()
    {
        Creak.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(transform.position));
    }

    private void OnDestroy()
    {
        Creak.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }
}
