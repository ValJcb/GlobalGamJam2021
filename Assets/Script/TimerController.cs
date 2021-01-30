using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{

    public Text timeCounter1;
    public Text timeCounter2;
    private TimeSpan timePlaying;
    public float elapsedTime;
    //public ValidationClient valider;



    void Start()
    {

        timeCounter1.text = "Time: 00:00.00";
        timeCounter2.text = "Time: 00:00.00";
        elapsedTime = 0f;
    }

    void Update()
    {


            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timeCounter1.text = timePlayingStr;
            timeCounter2.text = timePlayingStr;

        //if(valider.isWrong == true)
        //{
            //Debug.Log("NTM");
           // elapsedTime = 0f;
        //}

    }


}
