using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int ducksCollected = 0;

    private static ScoreTracker scoreTracker;

    private void Start()
    {
        scoreTracker = FindObjectOfType<ScoreTracker>();
    }
    public static void AddDuck()
    {
        ducksCollected++;
        Debug.Log("Collected " + ducksCollected + " Ducks.");
        scoreTracker.UpdateScore(ducksCollected);
    }
}
