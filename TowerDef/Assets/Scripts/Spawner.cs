using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    private Vector3 spawnPosition;
    private double tiempo = 0f;
    private double tiempoaparicion = 3f;
    private Quaternion spawnRotation = Quaternion.identity;
    public int Posicion;
    public double tiemposoles = 0f;
    public GameObject Sol;

    // Start is called before the first frame update

    void SpawnerZombies()
    {
        tiempo += Time.deltaTime;

        if (tiempo >= tiempoaparicion)
        {
            Instantiate(prefab, spawnPosition, spawnRotation);
            tiempo = 0f;
            tiempoaparicion = Random.Range(4f, 10f);
            Posicion = Random.Range(0, 5);
            spawnPosition = new Vector3(16.5f, 9.891f - (Posicion * 4.396f), 0);
        }
    }
    void Start()
    {
        tiempoaparicion = Random.Range(4f, 10f);
        Posicion = Random.Range(0, 5);
        spawnPosition = new Vector3(16.5f, 9.891f - (Posicion * 4.396f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        SpawnerZombies();
        SpawnearSoles();
    }
    void SpawnearSoles()
    {
        tiemposoles += Time.deltaTime;

        if (tiemposoles >= 7.5f)
        {
            Instantiate (Sol, spawnPosition, spawnRotation);
            tiemposoles = 0f;
        }

    }
}
