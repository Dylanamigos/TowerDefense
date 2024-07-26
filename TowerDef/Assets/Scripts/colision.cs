using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    
    public int damage = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    /*void OnColliderEnter2D(Collision2D collision)
    {

        if (collision.collider.CompareTag("enemy"))
        {
            
            enemigo enemigo = collision.collider.GetComponent<enemigo>();
            if (enemigo != null)
            {
                
                enemigo.TakeDamage(damage);
            }

            
            Destroy(gameObject);
        }
    }*/
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            enemigo enemigo = collision.GetComponent<enemigo>();
            if (enemigo != null)
            {
                enemigo.TakeDamage(damage);
            }

            Destroy(gameObject);
        }
    }
}
