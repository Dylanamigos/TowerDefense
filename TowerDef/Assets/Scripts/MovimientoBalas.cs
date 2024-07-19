using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBalas : MonoBehaviour
{
    float Timer = 0f;
    public int vida = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moverse();
    }
    void Moverse()
    {
        Timer += Time.deltaTime;
        gameObject.transform.Translate(10f * Time.deltaTime, 0f, 0f);
        if (Timer > 10f)
        {
            Destroy(gameObject);
        }
    }
}
