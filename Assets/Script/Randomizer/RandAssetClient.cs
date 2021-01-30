using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandAssetClient : MonoBehaviour

{

    // Start is called before the first frame update
    void Start()
    {
        Sprite[] spritesPeople = Resources.LoadAll<Sprite>("People") as Sprite[];
        int rand = Random.Range(0, spritesPeople.Length);
        SpriteRenderer spriteR = GetComponent<SpriteRenderer>();
        spriteR.sprite = spritesPeople[rand];
        gameObject.AddComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
