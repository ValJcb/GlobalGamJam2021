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
            SpriteRenderer spriteR = GetComponent<SpriteRenderer>();
            string clientWant = spriteR.sprite.name;

            SpriteRenderer spriteRItem = collision.gameObject.GetComponent<SpriteRenderer>();
            string itemName = spriteRItem.sprite.name;

            Debug.Log(clientWant + "    " + itemName);

            if (clientWant == itemName)
            {
                Destroy(collision.gameObject);
                //Destroy(this.gameObject);
                rb.velocity = new Vector2(-2, 0);
            }
            else
            {
                //Actions si c'est pas le bon
            }
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
        Debug.Log("Ciao");
    }
}
