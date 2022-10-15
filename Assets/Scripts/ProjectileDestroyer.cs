using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroyer : MonoBehaviour
{

    public float timer;
    float timeLimit = 2f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Makes the timers = to time passed in game
        timer += Time.deltaTime;
        //When timer is greater then 2(timeLimit), it destroys the game object
        if (timer > timeLimit)
        {
            Destroy(gameObject);
        }
        
    }
}
