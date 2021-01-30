using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadomizerClient : MonoBehaviour

{
    public GameObject posClients;

    // Start is called before the first frame update
    void Start()
    {

        Transform spawn = this.transform;
        Debug.Log(Spawn_Client.posClientsT.Length);

        Transform newPos = Spawn_Client.posClientsT[Random.Range(0, Spawn_Client.posClientsT.Length)];

        Debug.Log(newPos.position);

        spawn.position = newPos.position;

        //spawn = Spawn_Client.posClientsT[Random.Range(0, Spawn_Client.posClientsT.Length)];

        //spawn.position = new Vector3(spawn.position.x + Random.Range(-variationSpawn, variationSpawn), spawn.position.y, spawn.position.z);

        Sprite[] spritesPeople = Resources.LoadAll<Sprite>("People") as Sprite[];
        int rand = Random.Range(0, spritesPeople.Length);
        SpriteRenderer spriteR = GetComponent<SpriteRenderer>();
        spriteR.sprite = spritesPeople[rand];
        gameObject.AddComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
