using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgujeroComportamiento : MonoBehaviour

{
    public Transform target;
    public float velocidad;
    public float temporizador = 7;
    private float conteo = 7;
    public Text contador;
    public Text enunciado;
    public Text corre;
    
    void Start() 
    {
        conteo = 7;
        cambiarTexto();
    }

   

    // Update is called once per frame
    void Update()
    {
        float step = velocidad * Time.deltaTime;
        temporizador -= Time.deltaTime;
        if(temporizador < 0)
        {
            temporizador = 0;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            transform.Rotate(new Vector3(0,0,15) *Time.deltaTime);
        }
        conteo -= Time.deltaTime;
        if(conteo < 0)
        {
            enunciado.text = " ";
            corre.text= " ";
            contador.text =" ";

        }
        else{
            cambiarTexto();
        }
        

    }
    void cambiarTexto()
    {
        contador.text = " " + conteo.ToString();
    }
}
