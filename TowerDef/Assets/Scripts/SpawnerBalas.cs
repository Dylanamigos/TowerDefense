using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBalas : MonoBehaviour
{
    public GameObject prefab;
    private double tiempo = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 5f)
        {
            tiempo = 0f;
            Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
        }

    }
}
