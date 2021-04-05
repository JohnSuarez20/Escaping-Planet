using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraControlador : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 diferencia;
    public float velocidad;
    private Rigidbody rbcam; 
    // Start is called before the first frame update
    void Start()
    {
        diferencia = transform.position - jugador.transform.position ;
        rbcam = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 nuevaPos = jugador.transform.position + diferencia; 
        transform.position = nuevaPos; 
    }
}
