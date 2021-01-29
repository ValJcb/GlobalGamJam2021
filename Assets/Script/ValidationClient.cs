using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidationClient : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        { 
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
           
        }
    }
}
