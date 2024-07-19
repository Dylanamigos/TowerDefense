using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Pixeles : MonoBehaviour
{
    public float spritex, spritey;

    // Start is called before the first frame update
    void Start()
    {
        spritex = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        spritey = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size.y;

        Debug.Log("Largo Sprite en unidades " + spritex);
        Debug.Log("Altura Sprite en unidades " + spritey);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
