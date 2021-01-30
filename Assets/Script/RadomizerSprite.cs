using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadomizerSprite : MonoBehaviour

{
    public float variationSpawn = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag != "Client")
        {
            Transform spawn = this.transform;
            spawn.position = new Vector3(spawn.position.x + Random.Range(-variationSpawn, variationSpawn), spawn.position.y, spawn.position.z);

        }

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
