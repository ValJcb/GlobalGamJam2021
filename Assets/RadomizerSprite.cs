using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadomizerSprite : MonoBehaviour

{
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, sprites.Length);
        SpriteRenderer spriteR = GetComponent<SpriteRenderer>();
        spriteR.sprite = sprites[rand];
        gameObject.AddComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
