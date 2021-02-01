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
    public AudioClip voix;
    public AudioClip[] voixClientsValide;
    public AudioClip[] voixClientsErreur;

    //public float wrongLength = 3f;
    //public float wrongTime = 0f;

    public int patience = 30;
    private bool isWaiting = true;
    public float spawnT;

    //private float clicCounter;
    public float clicLength = 0.1f;

    public Animator oofAnim;

    void Start()
    {
        voixClientsValide = Resources.LoadAll<AudioClip>("VoixValide") as AudioClip[];
        voixClientsErreur = Resources.LoadAll<AudioClip>("VoixErreur") as AudioClip[];
        spawnT = Time.time;
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item" && !collision.gameObject.GetComponent<Controls>().isDragging)
        {
            SpriteRenderer spriteR = objet.GetComponent<SpriteRenderer>();
            string clientWant = spriteR.sprite.name;

            SpriteRenderer spriteRItem = collision.gameObject.GetComponent<SpriteRenderer>();
            string itemName = spriteRItem.sprite.name;
             
            if (clientWant == itemName)
                success(collision);
 
            if (clientWant != itemName)
                badItem(collision);
        }
    }

    void success(Collider2D collision)
    {
        audioSource.PlayOneShot(sonValidation);
        int rand = Random.Range(0, voixClientsValide.Length);
        audioSource.PlayOneShot(voixClientsValide[rand]);
        Destroy(collision.gameObject);
        leave();
    }

    void badItem(Collider2D collision)
    {
        collision.gameObject.tag = "Item_cursed";
        nrv(true);
    }

    void nrv(bool shake)
    {
        oofAnim.SetTrigger("oof");
        GameObject.Find("Timer").GetComponent<TimerController>().elapsedTime -= 10f;
        audioSource.PlayOneShot(sonEchec);
        int rand = Random.Range(0, voixClientsErreur.Length);
        audioSource.PlayOneShot(voixClientsErreur[rand]);
        if(shake)
            GameObject.Find("Main Camera").SendMessage("DoShake");
    }

    void leave()
    {
        isWaiting = false;
        Destroy(bubble);
        Destroy(objet);
        Destroy(detector);
        Destroy(this.GetComponent<Collider2D>());
        body.GetComponent<SpriteRenderer>().flipX = true;
        rb.velocity = new Vector2(-2, 0);
    }
    void tooLong()
    {
        nrv(false);
        leave();
        patience = 600;
    }

    void Update()
    {

        if(Time.time - spawnT > patience && isWaiting)
        {
            tooLong();
        }

        if(transform.position.x < -11)
        {
            Destroy(this.gameObject);
        }

        /*
        if (wrongTime > 0)
        {
            wrongTime -= Time.deltaTime;
            clicCounter -= Time.deltaTime;

            if(clicCounter <= 0)
            {
                body.active = !body.active;
                clicCounter = clicLength;
            }

            if(wrongTime <= 0)
            {
                body.active = true;
            }
        }*/
    }

    /*
    public void DoRed()
    {
        wrongTime = wrongLength;
    }
    */
}
