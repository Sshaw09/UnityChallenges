using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFire : MonoBehaviour
{
    private Vector3 mousePos;
    private Rigidbody rb;
    float lookAngle;
    public Vector3 lookDirection;

    public Transform bulletSpawn;
    public GameObject projectilePrefab;
    public float bulletSpeed = 10f;

    

     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Finds the position of the mouse in game 
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //Calculates the angle where the must look at to hit the mouse
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        //Makes the TurretRotator of the ship rotate and shot towards the mouse position
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        //Shoots the bullet if the Left mouse button is clicked 
        if (Input.GetMouseButtonDown(0))
        {
            Launch();
        }
    }

    void Launch()
    {
        //Spawns bullet and makes it go forward + adds speed
        var bullet = Instantiate(projectilePrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawn.forward * bulletSpeed;
    }
}
