using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sol : MonoBehaviour
{
    enum SolSpawneadoPor
    {
        cielo,
        girasol,
        girasol_doble,
        hongo,
    }
    Vector3 PosicionCaida;
    // Start is called before the first frame update
    void Start()
    {
        PosicionCaida = new Vector3(Random.Range(-15f, 15f), Random.Range(-9f, 9f), 0);
        gameObject.transform.position = new Vector3(PosicionCaida.x, 11.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y > PosicionCaida.y) {
            gameObject.transform.Translate(0f, -5.5f * Time.deltaTime, 0);
        }

    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
