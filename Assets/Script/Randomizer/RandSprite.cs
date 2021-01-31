using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSprite : MonoBehaviour

{
    public float variationSpawn = 1.5f;
    public int chanceHors = 10;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag != "Client")
        {
            Transform spawn = this.transform;
            spawn.position = new Vector3(spawn.position.x + Random.Range(-variationSpawn, variationSpawn), spawn.position.y, spawn.position.z);

        }

        if (gameObject.tag == "Item")
        {
            Sprite[] sprites = Resources.LoadAll<Sprite>("Objets") as Sprite[];
            int rand = Random.Range(0, sprites.Length);
            SpriteRenderer spriteR = GetComponent<SpriteRenderer>();
            spriteR.sprite = sprites[rand];
        }

        if (gameObject.tag == "Client")
        {

            int hors = Random.Range(0, chanceHors);


            if (hors < 7) {
                GameObject[] allItem = GameObject.FindGameObjectsWithTag("Item_box");
                if (allItem.Length == 0)
                {

                    Sprite[] sprites = Resources.LoadAll<Sprite>("Objets") as Sprite[];
                    int rand2 = Random.Range(0, sprites.Length);
                    SpriteRenderer spriteR2 = GetComponent<SpriteRenderer>();
                    spriteR2.sprite = sprites[rand2];
                }

                int rand = Random.Range(0, allItem.Length);
                GameObject aAfficher = allItem[rand];

                Sprite sprite = aAfficher.GetComponent<SpriteRenderer>().sprite;

                SpriteRenderer spriteR = GetComponent<SpriteRenderer>();
                spriteR.sprite = sprite;
            }
            else
            {
                Sprite[] sprites = Resources.LoadAll<Sprite>("Objets") as Sprite[];
                int rand = Random.Range(0, sprites.Length);
                SpriteRenderer spriteR = GetComponent<SpriteRenderer>();
                spriteR.sprite = sprites[rand];
            }

        }




        if (gameObject.tag != "Client")
            gameObject.AddComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
