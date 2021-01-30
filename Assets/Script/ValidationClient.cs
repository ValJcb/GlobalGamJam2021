﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidationClient : MonoBehaviour
{
    public GameObject objet;
    private bool isOk = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            SpriteRenderer spriteR = objet.GetComponent<SpriteRenderer>();
            string clientWant = spriteR.sprite.name;

            SpriteRenderer spriteRItem = collision.gameObject.GetComponent<SpriteRenderer>();
            string itemName = spriteRItem.sprite.name;
             
            if (clientWant == itemName)
            {
                isOk = true;
                //Destroy(collision.gameObject);
                //Destroy(this.gameObject);
            }
            else
            {
                //Actions si c'est pas le bon
            }
        }
    }

    void Update()
    {
        if(isOk)
        this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, new Vector3(-10, 0, 0), Time.deltaTime * 2f);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
        Debug.Log("Ciao");
    }
}
