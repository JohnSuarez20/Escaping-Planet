using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugadorControlador : MonoBehaviour
{
    public float velocidad;
    public float velocidad_salto ;
    private Rigidbody rb;
    bool isJump = false;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isJump = Input.GetButtonDown("Jump");
        if (isJump)
        {
            Vector3 jumpMov = new Vector3(0, velocidad_salto, 0);
            rb.AddForce((jumpMov), ForceMode.Impulse);
        }
        float MovHorizontal = Input.GetAxis("Horizontal");
        float MovVertical = Input.GetAxis("Vertical");
        Vector3 Movimiento = new Vector3(MovHorizontal,0.0f,MovVertical);
        rb.AddForce(Movimiento*velocidad);
        

    }
}
