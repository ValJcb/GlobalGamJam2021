using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidationClient : MonoBehaviour
{

    public Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            Destroy(collision.gameObject);
            //Destroy(this.gameObject);
            rb.velocity = new Vector2(-2, 0);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
