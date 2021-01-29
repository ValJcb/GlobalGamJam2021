using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidationClient : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Item"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
