    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Client : MonoBehaviour
{
    public GameObject objet;
    public GameObject posClients;
    public static Transform[] posClientsT;
    public Transform spawner;
    public float spawnRate = 1;
    // Start is called before the first frame update
    void Start()
    {
        Transform[] allChildren = posClients.GetComponentsInChildren<Transform>();
        foreach (Transform child in allChildren)
        {
            child.gameObject.SetActive(false);
            Debug.Log(child.position);
        }
        posClientsT = allChildren;

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
