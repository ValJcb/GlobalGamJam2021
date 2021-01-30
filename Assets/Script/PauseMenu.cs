using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool isPaused;
    public BoitePleine gameOver;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused == true && gameOver.isOver == false)
        {
            ActivateMenu();
        }
        else if (isPaused == false && gameOver.isOver == false)
        {
            DeactiveMenu();
        }
    }

    void ActivateMenu()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void DeactiveMenu()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
    }
}
