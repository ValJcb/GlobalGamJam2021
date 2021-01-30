using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientPositionning : MonoBehaviour
{
    //public GameObject client;
    public Rigidbody2D rb;
    public bool touchedLeBout = false;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(2, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "FinFile" || collision.gameObject.tag == "Client")
        {
            touchedLeBout = true;
            rb.velocity = new Vector2(0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!touchedLeBout)
        rb.velocity = new Vector2(2, 0);

    }
}
