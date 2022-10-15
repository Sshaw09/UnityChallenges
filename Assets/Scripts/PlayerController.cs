using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput = 1f;
    float verticalInput = 1f;
    public float speed = 10f;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);

        if(Input.GetMouseButtonDown(0))
        {
            Vector3 cursorpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(projectilePrefab, new Vector3(cursorpos.x, cursorpos.y, 0), Quaternion.identity);
        }


    }
    

        

}
