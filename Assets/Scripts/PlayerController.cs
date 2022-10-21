using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    Vector3 movement;
    public Rigidbody rb;

    
    // Start is called before the first frame update
    void Start()
    {
        //crossPlatformInput = GetComponent<>();
    }

    // Update is called once per frame
    void Update()
    {
        //WASD player movement
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        
    }

    private void FixedUpdate()
    {
        //Using the rigidbody of the ship to move the position and add speed
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);

    }

}



