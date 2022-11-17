using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject projectilePrefab;

   // Start is called before the first frame update
  void Start()
    {
        
    }

    // Keep Players in Bounds
  void Update()
    {
      if (transform.position.x < -xRange)
      {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
      }

      if(transform.position.x > xRange)
      {
       transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
      }
      // Move Player
      horizontalInput = Input.GetAxis ("Horizontal");  
      transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

      if (Input.GetKeyDown(KeyCode.Space))
      {
       Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
      }
    }
}
