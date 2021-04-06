using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraComportamiento : MonoBehaviour
{
    public Transform player;
    public Vector3 camOffset;

    [Range(0.1f, 1.0f)]
    public float SmoothFactor = 0.1f;
    public bool rotacionActive;
    public float velrotacion = 5.0f;
    public bool LookatPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        camOffset = transform.position - player.position;
       

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(rotacionActive)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") *velrotacion, Vector3.up);
            camOffset= camTurnAngle * camOffset;
            Quaternion camTurnAngleY = Quaternion.AngleAxis(Input.GetAxis("Mouse Y")* velrotacion, Vector3.up);
            camOffset = camTurnAngleY * camOffset;
        }

        Vector3 newPos = player.position + camOffset; 
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor); 
        if (LookatPlayer || rotacionActive) { transform.LookAt(player); } 
        if (Input.GetButton("Fire1")) 
        { 
            rotacionActive = true; 
        } 
        else 
        { 
            rotacionActive = false; 
            transform.LookAt(player);        
        }
    }
}
