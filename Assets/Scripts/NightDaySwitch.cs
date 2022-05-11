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

    private bool clockPressed;
    float timer = 0;
    float duration = 0.8f;

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
            //animate spin and crossfade
        {
            if (day)
            { // if it is currently day, change to night
                clockPressed = true;
                ExecuteTrigger("DayToNight");
                ExecuteTrigger("Crossfade");
            }

            else if (night)
            { // if it is currently night, change to day
                clockPressed = true;
                ExecuteTrigger("NightToDay");
                ExecuteTrigger("Crossfade");
            }
        }


    void Update ()
    {
        if (clockPressed)
        {
            //wait for 0.5 seconds
            timer += Time.deltaTime;
            if (timer >= duration)
            {
                //after delay, change skybox, lights and fog
                if (day)
                { // if it is currently day, change to night
                    RenderSettings.skybox = NightSky;
                    DayLight.SetActive(false);
                    NightLight.SetActive(true);
                    RenderSettings.fogColor = new Color32(33, 28, 49, 255);
                    day = false;
                    night = true;
                }

                else if (night)
                { // if it is currently night, change to day
                    RenderSettings.skybox = DaySky;
                    DayLight.SetActive(true);
                    NightLight.SetActive(false);
                    RenderSettings.fogColor = new Color32(139, 203, 211, 255);
                    night = false;
                    day = true;
                }

                timer = 0;
                clockPressed = false;
            }
        }

    }

}