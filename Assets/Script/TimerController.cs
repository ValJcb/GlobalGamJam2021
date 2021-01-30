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
    private bool timerGoing;

    private float elapsedTime;


    private void Start()
    {
        timeCounter1.text = "Time: 00:00.00";
        timeCounter2.text = "Time: 00:00.00";
        timerGoing = true;
        elapsedTime = 0f;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timeCounter1.text = timePlayingStr;
            timeCounter2.text = timePlayingStr;

            yield return null;
        }
    }
}
