using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidationClient : MonoBehaviour
{
    public GameObject objet;
    public GameObject bubble;
    public Rigidbody2D rb;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item" && !collision.gameObject.GetComponent<Controls>().isDragging)
        {
            SpriteRenderer spriteR = objet.GetComponent<SpriteRenderer>();
            string clientWant = spriteR.sprite.name;

            SpriteRenderer spriteRItem = collision.gameObject.GetComponent<SpriteRenderer>();
            string itemName = spriteRItem.sprite.name;
             
            if (clientWant == itemName)
            {
                Destroy(collision.gameObject);
                Destroy(bubble);
                Destroy(objet);
                //Destroy(this.gameObject);
                rb.velocity = new Vector2(-2, 0);
                Destroy(this.gameObject.GetComponent<Collider2D>());
            }
            else
            {
                Debug.Log(collision.gameObject.tag);
                GameObject.Find("Timer").GetComponent<TimerController>().elapsedTime -= 10f;
                collision.gameObject.tag = "Item_cursed";
                GameObject.Find("Main Camera").SendMessage("DoShake");
                Debug.Log(collision.gameObject.tag);
                //isWrong = true;
            }
        }
    }



    void Update()
    {

    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
        Debug.Log("Ciao");
    }
}
