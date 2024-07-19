using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    private Vector3 spawnPosition = new Vector3(0, 0, 0);
    private double tiempo = 0f;
    private double tiempoaparicion = 3f;
    private Quaternion spawnRotation = Quaternion.identity;

    // Start is called before the first frame update
    void Start()
    {
        tiempoaparicion = Random.Range(1f, 4f);
        spawnPosition = new Vector3(11f, Random.Range(-4f, 4f), 0);
    }

    // Update is called once per frame
    void Update()
    {
      
        tiempo += Time.deltaTime;
        
        if (tiempo >= tiempoaparicion)
        {
            Instantiate(prefab, spawnPosition, spawnRotation);
            tiempo = 0f;
            tiempoaparicion = Random.Range(1f, 4f);
            spawnPosition = new Vector3(11f, Random.Range(-4f, 4f), 0);
        }
    }
}
