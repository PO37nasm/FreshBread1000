using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField]
    private TMP_Text score;

    public void UpdateScore(int newScore)
    {
        score.text = "Ducks Collected: " + newScore;
    }

}
