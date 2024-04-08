using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 0.1f;
    public KeyCode teclaDerecha;
    public KeyCode teclaIzquierda;
    public KeyCode teclaArriba;
    public KeyCode teclaAbajo;
    public KeyCode teclaRotar;
    public KeyCode teclaRotar2;

    public Transform target;

    void Update()
    {
        if (Input.GetKey(teclaRotar))
            target.transform.Rotate(new Vector3(0,0, velocidad));

        if (Input.GetKey(teclaRotar2))
            target.transform.Rotate(new Vector3(0,0,-velocidad));

        if (Input.GetKey(teclaDerecha))
            target.Translate(Vector3.right * velocidad);
        
        if (Input.GetKey(teclaIzquierda))
            target.Translate(Vector3.left * velocidad);
        
        if (Input.GetKey(teclaArriba))
            target.Translate(Vector3.up * velocidad);
        
        if (Input.GetKey(teclaAbajo))
            target.Translate(Vector3.down * velocidad);
        
    }
}
