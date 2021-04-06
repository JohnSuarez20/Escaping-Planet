using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JugadorCompmortamiento : MonoBehaviour
{
    public float velocidad;
    private Rigidbody rb;
    public float tiempovelocidad = 5;
    public float tiemposalto = 5;
    public float fuerzasalto= 8;
    public bool puedosaltar;
    public int numvidas = 0;
    public GameObject jugador;
    public GameObject escudo;
    private AudioSource motor;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        puedosaltar = false;
        escudo.gameObject.SetActive(false);
        motor = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movHorizontal*Time.deltaTime, 0.0f, movVertical*Time.deltaTime);
        rb.AddForce(movimiento*velocidad);

        if (puedosaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, fuerzasalto, 0), ForceMode.Impulse);
            }
        }

            
        
        if(velocidad == 180 || velocidad == 220 || velocidad == 260)
        {
            if(tiempovelocidad > 0)
            {
                tiempovelocidad -= Time.deltaTime;
            }
            else
            {
                velocidad -= 20;
                tiempovelocidad = 5;
            }
        }
        if(fuerzasalto == 5)
        {
            if(tiemposalto > 0)
            {
                tiemposalto -= Time.deltaTime;
            }
            else
            {
                fuerzasalto = 3;
                tiemposalto = 5;
            }
        }

    
           
    }

    void OnTriggerEnter(Collider otro)
    {
        if(otro.gameObject.CompareTag("Enemigo"))
        {
            if(numvidas > 0)
            {
                numvidas -= 1;
                escudo.gameObject.SetActive(false);
            }
            else
            {
                jugador.gameObject.SetActive(false);
                Over.show();
            }
            
        }

       
        if(otro.gameObject.CompareTag("Velocidad"))
        {
            otro.gameObject.SetActive(false);
            velocidad += 40;   
            motor.Play();
        }
        if(otro.gameObject.CompareTag("Salto"))
        {
            otro.gameObject.SetActive(false);
            fuerzasalto = 5;
        }
        if(otro.gameObject.CompareTag("Escudo"))
        {
            otro.gameObject.SetActive(false);
            numvidas += 2;
            escudo.gameObject.SetActive(true);
        
        

        }
        

    }   
    private void OnTriggerStay(Collider other) 
    {
        puedosaltar = true;
    }
    private void OnTriggerExit(Collider other)  
    {
        puedosaltar = false;
    }
}
