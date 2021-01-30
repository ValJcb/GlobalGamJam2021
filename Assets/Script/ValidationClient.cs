using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidationClient : MonoBehaviour
{
    public GameObject objet;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            SpriteRenderer spriteR = objet.GetComponent<SpriteRenderer>();
            string clientWant = spriteR.sprite.name;

            SpriteRenderer spriteRItem = collision.gameObject.GetComponent<SpriteRenderer>();
            string itemName = spriteRItem.sprite.name;
             
            Debug.Log(clientWant + "    " + itemName);

            if (clientWant == itemName)
            {
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
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
