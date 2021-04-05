using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour

{   public string nombreEscena;
    public float speed;
     public float jumpSpeed;
     bool CanJump;
     bool jump;
  
    private Rigidbody rb; 
 
    private int conteo;
    private int gameOver;
    // Start is called before the first frame update
    void Start()
    {
  
        rb = GetComponent<Rigidbody>();
        CanJump = true;
         jump = false;
        
    }
    void OnCollisionExit(Collision collisionInfo)
     {
         CanJump = false;
         jump = false;
     }
     void OnCollisionEnter(Collision collisionInfo)
     {
         CanJump = true;
     }
     void Update() {
        if (gameOver==9)
        {
            SceneManager.LoadScene("GameOver");
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && CanJump == true)
         {
            jump = true;
         }                
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float MovHorizontal = Input.GetAxis("Horizontal");
        float MovVertical = Input.GetAxis("Vertical");
        Vector3 Movimiento = new Vector3(MovHorizontal,0.0f,MovVertical);
        rb.AddForce(Movimiento*speed);

        rb.AddForce(Movimiento * speed * Time.deltaTime);
 
         if (jump == true)
         {
             rb.AddForce(Vector3.up * jumpSpeed);
         }

        
        
        } 
    void OnTriggerEnter(Collider otro)
        {
        if(otro.gameObject.CompareTag("Meta"))
        {
            otro.gameObject.SetActive(false);
            SceneManager.LoadScene(nombreEscena);     
        }    
    }

    
    
}

