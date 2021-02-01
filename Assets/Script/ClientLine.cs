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

    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        Debug.Log("merde");
        yield return new WaitForSeconds(3);

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
        spawnRate = spawnRate * 0.99995f;
        
    }
}
