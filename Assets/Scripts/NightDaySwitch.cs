using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightDaySwitch : MonoBehaviour
{

    public Material DaySky;
    public Material NightSky; 

    public void ChangeDayNight()
    {
        if (day)
        { // if it is currently day, change to night
            day = false;
            night = true;
            RenderSettings.skybox = NightSky;
        }

        else if (night)
        { // if it is currently night, change to day
            night = false;
            day = true;
            RenderSettings.skybox = DaySky;
        }
    }

}