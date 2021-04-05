using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform checkpoint;
    GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Jugador");

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider plyr) 
    {
        player.transform.position = checkpoint.position;
        player.transform.rotation = checkpoint.rotation;
        
    }
}
