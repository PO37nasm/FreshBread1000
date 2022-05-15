using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Timer: MonoBehaviour
{
    [SerializeField]
    private float totalTime = 10f;
    private float startTime = 0f;
    [SerializeField]
    private TMP_Text timer;
    private bool countDownStarted = false;
    [SerializeField]
    private float countDownStartTime = 60.5f;
    [SerializeField]
    public UnityEvent onTimeUpEvent;

    private bool done = false;

    private void Start()
    {
        startTime = Time.fixedTime;
        countDownStarted = false;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        int timeLeft = Mathf.RoundToInt(totalTime - (Time.fixedTime - startTime));
        if (timer != null)
        {
            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;

            switch (timeLeft > 0)
            {
                case true when minutes >= 10 && seconds >= 10:
                    timer.text = minutes + ":" + seconds;
                    break;
                case true when minutes < 10 && seconds >= 10:
                    timer.text = "0" + minutes + ":" + seconds;
                    break;
                case true when minutes >= 10 && seconds < 10:
                    timer.text = minutes + ":" + "0" + seconds;
                    break;
                case true when minutes < 10 && seconds < 10:
                    timer.text = "0" + minutes + ":" + "0" + seconds;
                    break;
            }

            if (timeLeft < countDownStartTime)
            {
                timer.color = new Color(255, 0, 0);
            }
        }

        if (Time.timeSinceLevelLoad > totalTime && done == false)
        {
            onTimeUpEvent.Invoke();
            done = true;
        }
        if (Time.timeSinceLevelLoad > totalTime - countDownStartTime && !countDownStarted)
        {
            //if (FindObjectOfType<MusicControl>() != null) { FindObjectOfType<MusicControl>().StopMusic(); }
            countDownStarted = true;
        }
        
    }

    public int GetTimePassed()
    {
        return Mathf.RoundToInt((Time.fixedTime - startTime));
    }

    public int GetTimeLeft()
    {
        return Mathf.RoundToInt(totalTime - (Time.fixedTime - startTime));
    }
}
