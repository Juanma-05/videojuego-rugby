using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncajarImagen : MonoBehaviour
{
    public Vector3 Rompecabezas;

    private void Awake()
    {
        Rompecabezas = transform.position;
    }
    private void Start()
    {
        transform.position = new Vector3(Random.Range(1, 5), Random.Range(1, 5), 0);
    }

    void Update()
    {
        float distacia = Vector3.Distance(transform.position, Rompecabezas);

        if (distacia <0.5f)
        {
            transform.position = Rompecabezas;
        }
    }
}
