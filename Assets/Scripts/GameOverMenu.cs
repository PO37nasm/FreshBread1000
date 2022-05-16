using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverUI;
    public static bool GameIsOver = false;
    public int currentScene;
    [SerializeField]
    private TMP_Text scoreUI;
    [SerializeField]
    private TMP_Text creditsScoreUI;

    public void GameOver()
    {
        //Pause the game and display the game over menu, telling the PauseMenu script to not accept escape inputs to prevent possible overlap
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
        GameIsOver = true;
        SetScoreUI();
        PauseMenu.GameIsPaused = true;
    }

    public void Restart()
    {
        //Restart the current scene
        //SceneManager.UnloadSceneAsync(currentScene
        SceneManager.LoadScene(currentScene);
        GameIsOver = false;
        Time.timeScale = 1f;
    }

    public static string GetScore()
    {
        return  " " + GameManager.ducksCollected + " ";
    }

    public void SetScoreUI()
    {
        scoreUI.text = "Hand in" + GetScore() + "ducks?";
    }

    public void SetCreditsScore()
    {
        if (GameManager.ducksCollected == 1000)
        {
            creditsScoreUI.text = "You collected" + GetScore() + "out of 1000 ducks... Incredible! You know I really thought that would be impossible.";
            FMODUnity.RuntimeManager.PlayOneShot("event:/Cutscenes/1000Collected");
        }
        else if (GameManager.ducksCollected >= 900)
        {
            creditsScoreUI.text = "You collected" + GetScore() + "out of 1000 ducks, not too many left...";
            FMODUnity.RuntimeManager.PlayOneShot("event:/Cutscenes/900Collected");
        }
        else if (GameManager.ducksCollected >= 500)
        {
            creditsScoreUI.text = "You collected" + GetScore() + "out of 1000 ducks, an impressive effort...";
            FMODUnity.RuntimeManager.PlayOneShot("event:/Cutscenes/500Collected");

        }
        else if (GameManager.ducksCollected < 1)
        {
            creditsScoreUI.text = "You collected" + GetScore() + "out of 1000 ducks, come on, really?";
            FMODUnity.RuntimeManager.PlayOneShot("event:/Cutscenes/NoneCollected");
        }
        else
        {
            creditsScoreUI.text = "You collected" + GetScore() + "out of 1000 ducks, but there are still so many left...";
            FMODUnity.RuntimeManager.PlayOneShot("event:/Cutscenes/Collected");
        }


    }
}
