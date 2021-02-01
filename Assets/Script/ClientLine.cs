using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientLine : MonoBehaviour
{
    public GameObject objet;

    public Transform spawner;
    public BoxCollider2D colliderSpawn;
    public bool canPop;
    public int chanceExisting = 100;


    public float waitTillSpawn = 3.7f;

    private float timeout = 2;
    public float multiply = 0.995f;
    public float limit = 0.3f;


    void Start()
    {
        canPop = false;
        StartCoroutine(WaitCoroutine());
    }

    IEnumerator WaitCoroutine()
    {
        yield return new WaitForSeconds(3);    
        canPop = true;
    }


    void SpawnMethod()
    {
        if(canPop == true)
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
            canPop = false;
    }


    void Update()
    {
        if (timeout > 0)
        {
            timeout -= Time.deltaTime;
            return;
        }
        SpawnMethod();
        timeout = waitTillSpawn;
        if (waitTillSpawn > limit)
            waitTillSpawn = waitTillSpawn * multiply;
    }
        
    }

