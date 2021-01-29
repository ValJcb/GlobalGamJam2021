using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSol : MonoBehaviour
{
    public Transform spawner;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            collision.gameObject.transform.position = spawner.transform.position;
        }
    }
}
