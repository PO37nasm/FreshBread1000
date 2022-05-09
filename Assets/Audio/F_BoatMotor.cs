using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_BoatMotor : MonoBehaviour
{

    FMOD.Studio.EventInstance BoatMotor;
    FMOD.Studio.EventInstance BoatRevs;

    // Start is called before the first frame update
    void Start()
    {
        BoatMotor = FMODUnity.RuntimeManager.CreateInstance("event:/Boat/BoatMotor");
        BoatMotor.start();
        BoatRevs = FMODUnity.RuntimeManager.CreateInstance("event:/Boat/BoatRevs");
        BoatRevs.start();
    }

    // Update is called once per frame
    void Update()
    {
        
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(BoatMotor, GetComponent<Transform>(), GetComponent<Rigidbody>());
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(BoatRevs, GetComponent<Transform>(), GetComponent<Rigidbody>());

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (vertical >= 0.1f || horizontal >= 0.1f || horizontal <= -0.1f)
        {
            BoatMotor.setParameterByName("BoatMotion", 0f, false);
            BoatRevs.setParameterByName("BoatAccelDecel", 0f);
        }
        else
        {
            BoatMotor.setParameterByName("BoatMotion", 10f, false);
            BoatRevs.setParameterByName("BoatAccelDecel", 1f);
        }
    }
}
