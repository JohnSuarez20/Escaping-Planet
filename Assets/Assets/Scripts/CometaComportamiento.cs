using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometaComportamiento : MonoBehaviour
{
    public GameObject objetorotar;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        OrbitAround ();
        
    }
    void OrbitAround()
    {
        transform.RotateAround (objetorotar.transform.position, Vector3.up, velocidad *Time.deltaTime);
    }
}
