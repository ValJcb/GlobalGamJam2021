using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSprite : MonoBehaviour

{
    public float variationSpawn = 1.5f;
    private int chancePresent;

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
            int hors = Random.Range(0, 100);
            chancePresent = GameObject.Find("ClientLine").GetComponent<ClientLine>().chanceExisting;

            if (hors < chancePresent) {
                GameObject[] allItem = GameObject.FindGameObjectsWithTag("Item_box");
                if (allItem.Length == 0)
                {
                    Debug.Log("Spawn random car pas d'objet");
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
