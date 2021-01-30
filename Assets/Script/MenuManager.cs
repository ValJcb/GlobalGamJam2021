using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public PauseMenu paused;
    // Start is called before the first frame update
    private void Start()
    {

    }
    public void Play()
    {
        SceneManager.LoadScene("Main_Scene");
    }

    // Update is called once per frame
    public void Quitter()
    {
        Application.Quit();
    }

    public void Retry()
    {
        paused.isPaused = false;
        SceneManager.LoadScene("Main_Scene");
    }

    public void BackMenu()
    {
        paused.isPaused = !paused.isPaused;
        SceneManager.LoadScene("Main_Menu");
    }

    public void Resume()
    {
        paused.isPaused = !paused.isPaused;
    }
}
