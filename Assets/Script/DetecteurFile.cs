using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecteurFile : MonoBehaviour
{
    public bool haveToMove = true;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInParent<Rigidbody2D>();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "FinFile" || other.gameObject.tag == "Client")
            haveToMove = true;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "FinFile" || collision.gameObject.tag == "Client")
        {
            haveToMove = false;
            rb.velocity = new Vector2(0, 0);

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (haveToMove)
            rb.velocity = new Vector2(2, 0);
    }
}
