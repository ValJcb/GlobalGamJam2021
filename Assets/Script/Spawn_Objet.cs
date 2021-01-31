    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Objet : MonoBehaviour
{
    public GameObject objet;

    public Transform spawner;


    public float timeoutDuration = 2;

    private float timeout = 2;
    public float multiply = 0.995f;
    public float limit = 0.3f;

    void Update()
    {
        Debug.Log(timeoutDuration);

        if (timeout > 0)
        {
            timeout -= Time.deltaTime;
            return;
        }

        Instantiate(objet, spawner);

        timeout = timeoutDuration;

        if(timeoutDuration>limit)
            timeoutDuration = timeoutDuration * multiply;

    }

} 
