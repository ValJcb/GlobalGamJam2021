using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientLine : MonoBehaviour
{
    public GameObject objet;

    public Transform spawner;
    public float spawnRate = 1;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMethod", 1.0f, spawnRate);
    }

    void SpawnMethod()
    {
        Instantiate(objet, spawner);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
