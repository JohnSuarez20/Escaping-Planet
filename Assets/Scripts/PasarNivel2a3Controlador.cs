using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarNivel2a3Controlador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col) { {
            Debug.Log("Collision Detected It Works");
            SceneManager.LoadScene("Nivel3");
        }
    }
}
