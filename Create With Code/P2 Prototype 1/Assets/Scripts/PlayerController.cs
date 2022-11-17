using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 5.0f;
    private float turnSpeed = 25;
    private float horizontalInput;
    private float fowardInput;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
       horizontalInput = Input.GetAxis("Horizontal");
       fowardInput = Input.GetAxis("Vertical");

       // We move the vechile forward 
       transform.Translate(Vector3.forward * Time.deltaTime *speed * fowardInput);
       //We turn the vechile
       transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }   
}    
