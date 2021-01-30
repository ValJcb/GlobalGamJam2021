using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadomizerSprite : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>("Objets") as Sprite[];
        int rand = Random.Range(0, sprites.Length);
        SpriteRenderer spriteR = GetComponent<SpriteRenderer>();
        spriteR.sprite = sprites[rand];
        if (gameObject.tag != "Client")
        gameObject.AddComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
