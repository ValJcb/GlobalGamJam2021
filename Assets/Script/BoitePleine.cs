using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoitePleine : MonoBehaviour
{
    public GameObject perdu;
    public bool isOver;
    public GameObject otherTimer;

    private void Start()    
    {
        isOver = false;
        perdu.SetActive(false);
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item_box" && isOver == false)
        {
            isOver = true;
            Time.timeScale = 0;
            perdu.SetActive(true);
            otherTimer.SetActive(false);
        }
    }
}
