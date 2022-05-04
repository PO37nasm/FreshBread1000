using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using FMOD.Studio;
using FMODUnity;

public class F_Slider : MonoBehaviour
{
    private Slider Slider;
    EventInstance LevelTest;
    PLAYBACK_STATE pb;

    private VCA vca;
    public string vcaPath;
    private float vcaVolume;

    // Start is called before the first frame update
    void Start()
    {
        vca = RuntimeManager.GetVCA("vca:/" + vcaPath);
        vca.getVolume(out vcaVolume);
        Slider = GetComponent<Slider>();
        Slider.value = vcaVolume;


        if (vcaPath == "Master")
        {
            LevelTest = RuntimeManager.CreateInstance("event:/UI/AudioSlider");
        }
        else
            LevelTest.release();
    }

    public void VolumeLevel(float SliderValue)
    {
        vca.setVolume(SliderValue);
        if (vcaPath == "Master")
        {
            LevelTest.getPlaybackState(out pb);
            if (pb != PLAYBACK_STATE.PLAYING)
                LevelTest.start();
        }
    }

    void OnDestroy()
    {
        if (vcaPath == "Master")
            LevelTest.release();
    }
}
