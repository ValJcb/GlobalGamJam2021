    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Objet : MonoBehaviour
{
    public GameObject[] objets;
    public Transform spawner;
    public float spawnRate = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ffef");
        InvokeRepeating("SpawnMethod", 1.0f, spawnRate);
    }

    void SpawnMethod()
    {
        Instantiate(objets[Random.Range(0, objets.Length)], spawner);
    }
    // Update is called once per frame
    void Update()
    {


    }
} 
