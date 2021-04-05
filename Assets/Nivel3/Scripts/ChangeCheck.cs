using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCheck : MonoBehaviour
{
    public GameObject checkpoint;
    void OnTriggerEnter(Collider plyr) 
    {
     if (plyr.gameObject.tag == "Jugador")
        
        Destroy(checkpoint);
        Destroy(gameObject);
        

    }
}    
