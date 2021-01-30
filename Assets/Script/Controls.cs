using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public bool isDragging;
    public Rigidbody2D rb;

    public void OnMouseDown()
    {
        isDragging = true;
        this.gameObject.tag = "Item";
        Debug.Log("MouseDown");

    }

    public void OnMouseUp()
    {
        isDragging = false;

    }















        void FixedUpdate()
    {
        if (isDragging)
        {
            rb.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
        }
    }
}