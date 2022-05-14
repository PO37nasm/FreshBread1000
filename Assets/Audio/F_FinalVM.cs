using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_FinalVM : MonoBehaviour
{

    FMOD.Studio.EventInstance FinalVM;

    // Start is called before the first frame update
    void Start()
    {
        FinalVM = FMODUnity.RuntimeManager.CreateInstance("event:/DX/FinalVoiceMail");
        FinalVM.start();
        FinalVM.release();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
