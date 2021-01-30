using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool isPaused;

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

        if (isPaused)
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
