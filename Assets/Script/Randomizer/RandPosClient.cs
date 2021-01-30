using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandPosClient : MonoBehaviour

{
    private Transform spawn;
    private Transform newPos;
    public GameObject posClients;
    public float speedComing = 2f;

    // Start is called before the first frame update
    void Start()
    {

        spawn = this.transform;
        newPos = Spawn_Client.posClientsT[Random.Range(0, Spawn_Client.posClientsT.Length)];

    }

    // Update is called once per frame
    void Update()
    {
        spawn.position = Vector3.MoveTowards(spawn.position, newPos.position, Time.deltaTime * speedComing);
    }
}
