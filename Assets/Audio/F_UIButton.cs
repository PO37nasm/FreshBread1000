using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_UIButton : MonoBehaviour
{

    FMOD.Studio.EventInstance UIButton;

    public void ClickSFX()
    {
        UIButton = FMODUnity.RuntimeManager.CreateInstance("event:/UI/ButtonClick");
        UIButton.start();
        UIButton.release();
        Debug.Log("Button SFX Played");
    }

}
