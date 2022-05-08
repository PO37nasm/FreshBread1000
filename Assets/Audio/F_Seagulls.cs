using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_Seagulls : MonoBehaviour
{

    FMOD.Studio.EventInstance Gulls;
    public GameObject Ship;

    void Start()
    {
        Gulls = FMODUnity.RuntimeManager.CreateInstance("event:/Enviroment/Seagulls");
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(Gulls, Ship.transform);
        Gulls.start();
        Gulls.release();
    }

    private void OnDestroy()
    {
        Gulls.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }
}
