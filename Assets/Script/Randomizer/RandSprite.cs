using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSprite : MonoBehaviour

{
    public float variationSpawn = 1.5f;
    public int chancePresentSur10 = 10;

    // Start is called before the first frame update
    void Start()
    {

        if (gameObject.tag == "Item")
        {
            Transform spawn = this.transform;
            spawn.position = new Vector3(spawn.position.x + Random.Range(-variationSpawn, variationSpawn), spawn.position.y, spawn.position.z);
            gameObject.AddComponent<PolygonCollider2D>();
            spawnRandomItem();
        }

        if (gameObject.tag == "Client")
        {
            int hors = Random.Range(0, 10);

            if (hors < chancePresentSur10) {
                GameObject[] allItem = GameObject.FindGameObjectsWithTag("Item_box");
                if (allItem.Length == 0)
                {
                    spawnRandomItem();
                }
                else
                {
                    spawnItemInScene(allItem = GameObject.FindGameObjectsWithTag("Item_box"));
                }

            }
            else
            {
                spawnRandomItem();
            }
        }
    }

    void spawnRandomItem()
    {
        int rand = Random.Range(0, GameManager.spritesObjets.Length);
        SpriteRenderer spriteR = GetComponent<SpriteRenderer>();
        spriteR.sprite = GameManager.spritesObjets[rand];
    }

    void spawnItemInScene(GameObject[] allItem)
    {
        int rand = Random.Range(0, allItem.Length);
        GameObject aAfficher = allItem[rand];

        Sprite sprite = aAfficher.GetComponent<SpriteRenderer>().sprite;

        SpriteRenderer spriteR = GetComponent<SpriteRenderer>();
        spriteR.sprite = sprite;
    }

}
