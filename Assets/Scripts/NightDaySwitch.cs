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

    public void ChangeDayNight()
    {
        if (day)
        { // if it is currently day, change to night
            day = false;
            night = true;
            RenderSettings.skybox = NightSky;
            NightLight.SetActive(true);
            DayLight.SetActive(false);
            // Set the fog color to be blue
            RenderSettings.fogColor = Color.blue;
        }

        else if (night)
        { // if it is currently night, change to day
            night = false;
            day = true;
            RenderSettings.skybox = DaySky;
            DayLight.SetActive(true);
            NightLight.SetActive(false);
            RenderSettings.fogColor = Color.blue;
        }
    }

}