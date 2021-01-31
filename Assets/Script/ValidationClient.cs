using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidationClient : MonoBehaviour
{
    public GameObject objet;
    public GameObject bubble;
    public GameObject detector;
    public GameObject body;
    public Rigidbody2D rb;
    public AudioSource audioSource;
    public AudioClip sonValidation;
    public AudioClip sonEchec;

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
                audioSource.PlayOneShot(sonValidation);
                Destroy(collision.gameObject);
                Destroy(bubble);
                Destroy(objet);
                Destroy(detector);
                body.GetComponent<SpriteRenderer>().flipX = true;
                //Destroy(this.gameObject);
                Destroy(this.gameObject.GetComponent<Collider2D>());
                rb.velocity = new Vector2(-2, 0);
            }
            else
            {
                GameObject.Find("Timer").GetComponent<TimerController>().elapsedTime -= 10f;
                audioSource.PlayOneShot(sonEchec);
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
