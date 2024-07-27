using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBalas : MonoBehaviour
{
    public GameObject prefab;
    private double tiempo = 0f;
    private bool enemyInLine = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            Disparar();
        

    }
    void Disparar()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 1.37)
        {
            tiempo = 0f;
            Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
        }
    }
    /*void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            enemyInLine = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            enemyInLine = false;
        }
    }*/
}
