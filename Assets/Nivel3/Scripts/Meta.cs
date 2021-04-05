using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    public string nombreEscena;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnTriggerEnter(Collider otro){

        if(otro.gameObject.CompareTag("Meta"))
        {
            otro.gameObject.SetActive(false);
            SceneManager.LoadScene(nombreEscena);     
        }
        
    }
}
