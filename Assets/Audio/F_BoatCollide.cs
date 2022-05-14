using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_BoatCollide : MonoBehaviour
{

    FMOD.Studio.EventInstance Crash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Crash.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(transform.position));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Terrain")
        {
            Crash = FMODUnity.RuntimeManager.CreateInstance("event:/Interactables/BoatCrash");
            Crash.start();
            Crash.release();
        }
        
    }
}
