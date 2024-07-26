using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class spawnerbalasx2 : MonoBehaviour
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
        Disparar();

    }
    void Disparar()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 3.00)
        {
            tiempo = 0f;
            Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
            
        }
        if (tiempo >= 0.23)
        {
            tiempo = 0f;
            Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
        }
    }
}*/
public class spawnerbalasx2 : MonoBehaviour
{
    public GameObject prefab;
    private float tiempo = 0f;
    public float intervaloEntreBalas = 0.23f; // Intervalo de tiempo entre las dos balas

    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 3.0f)
        {
            tiempo = 0f;
            StartCoroutine(DispararConRetraso());
        }
    }

    IEnumerator DispararConRetraso()
    {
        Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(intervaloEntreBalas);
        Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
    }
}
