using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            gameObject.transform.Translate(-1f * Time.deltaTime, 0, 0); 
        
    
    }
}
