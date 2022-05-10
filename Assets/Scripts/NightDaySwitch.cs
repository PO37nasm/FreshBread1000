using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightDaySwitch : MonoBehaviour
{

    public Material DaySky;
    public Material NightSky;

    public bool day = true;
    public bool night = false;

    public GameObject DayLight;
    public GameObject NightLight;

    public GameObject DayNightArt;
    public GameObject CrossfadePanel;

    float timer = 0;
    float duration = 1f;

    private void ExecuteTrigger (string trigger)
    {
        var animator = DayNightArt.GetComponent<Animator>();
        if(animator != null)
        {
            animator.SetTrigger(trigger);
        }

        var animator2 = CrossfadePanel.GetComponent<Animator>();
        if (animator2 != null)
        {
            animator2.SetTrigger(trigger);
        }
    }

    public void ChangeDayNight()
    {
        if (day)
        { // if it is currently day, change to night
            day = false;
            night = true;

            //animate spin and crossfade
            ExecuteTrigger("DayToNight");
            ExecuteTrigger("Crossfade");

            //timer += Time.deltaTime;
            //if (timer >= duration)
            //{
            //    timer = 0;
            RenderSettings.skybox = NightSky;
                NightLight.SetActive(true);
                DayLight.SetActive(false);
                RenderSettings.fogColor = new Color32(33, 28, 49, 255);

            //}


        }

        else if (night)
        { // if it is currently night, change to day
            night = false;
            day = true;
            RenderSettings.skybox = DaySky;
            DayLight.SetActive(true);
            NightLight.SetActive(false);
            RenderSettings.fogColor = new Color32(139, 203, 211, 255);
            DayNightArt.transform.Rotate(0f, 0f, 180f);
            ExecuteTrigger("NightToDay");
            ExecuteTrigger("Crossfade");

        }
    }

}