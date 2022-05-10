using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_DeweyVM : MonoBehaviour
{

    FMOD.Studio.EventInstance VM;

    // Start is called before the first frame update

    private void Awake()
    {
        VM = FMODUnity.RuntimeManager.CreateInstance("event:/DX/VoiceMessages");
        VM.start();
        VM.release();
    }

}
