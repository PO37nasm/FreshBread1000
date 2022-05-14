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
    

    public void GameOver()
    {
        //Pause the game and display the game over menu, telling the PauseMenu script to not accept escape inputs to prevent possible overlap
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
        GameIsOver = true;
        scoreUI.text = GetScore();
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
        return "Ducks Collected: " + GameManager.ducksCollected;
    }
}
