using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Sprite[] spritesObjets;
    public static Sprite[] spritesClients;

    // Start is called before the first frame update
    void OnEnable()
    {
        spritesObjets = Resources.LoadAll<Sprite>("Objets") as Sprite[];
        spritesClients = Resources.LoadAll<Sprite>("People") as Sprite[];
        Debug.Log(spritesObjets.Length + " objets et " + spritesClients.Length + " clients chargés");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
