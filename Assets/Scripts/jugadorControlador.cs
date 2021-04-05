using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugadorControlador : MonoBehaviour
{
    public float velocidad;
    public float velocidad_salto = 5;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       float MovHorizontal = Input.GetAxis("Horizontal");
        float MovVertical = Input.GetAxis("Vertical");
        Vector3 Movimiento = new Vector3(MovHorizontal,0.0f,MovVertical);
        rb.AddForce(Movimiento*velocidad);
        


        if (Input.GetKeyDown(KeyCode.Space))
         {
               {rb.AddForce(Vector3.up * velocidad, ForceMode.Impulse);}

         }
    }
}
