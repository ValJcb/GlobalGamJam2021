using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoitePleine : MonoBehaviour
{
    public Text perdu;
    private void Start()
    {
        perdu.enabled = false;
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item_box")
        {
            Debug.Log("PERDU");

            perdu.enabled = true;
        }
    }
}
