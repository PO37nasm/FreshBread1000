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
    float duration = 0.5f;

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


            //trying to get unity to wait for 0.5 seconds before doing the next bit, but no luck so far!
            //timer = 0;
            //int count = 0;
            //while (timer < duration && count < 10000)
            //{
            //    timer += Time.deltaTime;
            //    count++;
            //}
            //timer = 0;


            RenderSettings.skybox = NightSky;
            DayLight.SetActive(false);
            NightLight.SetActive(true);
            RenderSettings.fogColor = new Color32(33, 28, 49, 255);
            ExecuteTrigger("DayToNight");
            ExecuteTrigger("Crossfade");

        }

        else if (night)
        { // if it is currently night, change to day
            night = false;
            day = true;
            RenderSettings.skybox = DaySky;
            DayLight.SetActive(true);
            NightLight.SetActive(false);
            RenderSettings.fogColor = new Color32(139, 203, 211, 255);
            ExecuteTrigger("NightToDay");
            ExecuteTrigger("Crossfade");

        }
    }

}