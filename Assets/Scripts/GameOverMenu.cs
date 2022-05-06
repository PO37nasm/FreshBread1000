using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverUI;
    public static bool GameIsOver = false;
    public int currentScene;

    public void GameOver()
    {
        //Pause the game and display the game over menu, telling the PauseMenu script to not accept escape inputs to prevent possible overlap
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
        GameIsOver = true;
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
}
