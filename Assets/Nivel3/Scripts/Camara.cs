using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject Jugador;
    private Vector3 diferencia;
    private Camera cam;
    private float starting;
    public float min;
    public float max;
    public float zoomRate;
    private float current;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        starting = cam.fieldOfView;

        diferencia = transform.position - Jugador.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    
    {
        current = cam.fieldOfView;
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        current -= scroll * zoomRate;
        current = Mathf.Clamp(current,min,max);
        cam.fieldOfView = current;
        Vector3 NuevaPos = Jugador.transform.position + diferencia;
        transform.position = NuevaPos;
        
    }
}
