using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightControlador : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 diferencia;
   
    private Rigidbody rbluz;
    // Start is called before the first frame update
    void Start()
    {
        diferencia = transform.position - jugador.transform.position ;
        rbluz = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 nuevaPos = jugador.transform.position + diferencia; 
        transform.position = nuevaPos;
    }
}
