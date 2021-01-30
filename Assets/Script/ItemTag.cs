using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTag : MonoBehaviour
{
    public Controls dragg;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Item_box" | collision.gameObject.tag == "Box") && dragg.isDragging == false)
        {
            this.gameObject.tag = "Item_box";
        }
    }
}
