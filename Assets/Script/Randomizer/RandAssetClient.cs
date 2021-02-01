using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandAssetClient : MonoBehaviour

{

    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, GameManager.spritesClients.Length);
        SpriteRenderer spriteR = GetComponent<SpriteRenderer>();
        spriteR.sprite = GameManager.spritesClients[rand];
    }

    // Update is called once per frame
    void Update()
    {
    }
}
