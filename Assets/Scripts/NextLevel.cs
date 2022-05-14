using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField]
    private Animator transition;
    [SerializeField]
    private float transitionTime;
    [SerializeField]
    private int nextScene;
    public void LoadNextLevel()
    {
        StartCoroutine(Loading(nextScene));
    }

    public void LoadLevel(int levelID)
    {
        StartCoroutine(Loading(levelID));
    }

    IEnumerator Loading(int levelID)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelID);
    }
}
