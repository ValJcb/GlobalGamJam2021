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

    public float wrongLength = 3f;
    public float wrongTime;
    private float clicCounter;
    public float clicLength = 0.1f;

    void Start()
    {
        voixClientsValide = Resources.LoadAll<AudioClip>("VoixValide") as AudioClip[];
        voixClientsErreur = Resources.LoadAll<AudioClip>("VoixErreur") as AudioClip[];
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
            {
                audioSource.PlayOneShot(sonValidation);
                int rand = Random.Range(0, voixClientsValide.Length);
                audioSource.PlayOneShot(voixClientsValide[rand]);
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
                Debug.Log(collision.gameObject.tag);
                GameObject.Find("Timer").GetComponent<TimerController>().elapsedTime -= 10f;
                audioSource.PlayOneShot(sonEchec);
                int rand = Random.Range(0, voixClientsErreur.Length);
                audioSource.PlayOneShot(voixClientsErreur[rand]);
                DoRed();
                collision.gameObject.tag = "Item_cursed";
                GameObject.Find("Main Camera").SendMessage("DoShake");
                Debug.Log(collision.gameObject.tag);
                //isWrong = true;
            }
        }
    }



    void Update()
    {
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
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
        Debug.Log("Ciao");
    }

    public void DoRed()
    {
        wrongTime = wrongLength;
    }
}
