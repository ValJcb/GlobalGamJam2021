using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public PauseMenu paused;
    public Animator transitionAnim;
    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    public void Quitter()
    {
        Application.Quit();
    }

    public void Retry()
    {
        Time.timeScale = 1;
        paused.isPaused = false;
        StartCoroutine(CoRetry());
    }

    public void BackMenu()
    {
        Time.timeScale = 1;
        paused.isPaused = false;
        StartCoroutine(CoBack());
    }

    public void Resume()
    {
        paused.isPaused = !paused.isPaused;
    }

    IEnumerator CoRetry()
    {
        transitionAnim.SetTrigger("endtrans");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Main_Scene");
    }

    IEnumerator CoBack()
    {
        transitionAnim.SetTrigger("endtrans");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Main_Menu");
    }
}
