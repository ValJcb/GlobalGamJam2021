using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientLine : MonoBehaviour
{
    public GameObject objet;

    public Transform spawner;
    public BoxCollider2D colliderSpawn;
    public float spawnRate = 1;
    public bool canPop = true;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMethod", 1.0f, spawnRate);
    }

    void SpawnMethod()
    {
        if(canPop)
            Instantiate(objet, spawner);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Client")
            canPop = true;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Client")
        {
            canPop = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
