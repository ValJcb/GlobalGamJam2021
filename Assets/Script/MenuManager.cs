﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
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
}
