using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 100f;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Unity likes using FixedUpdate function name when using physics
    // FixedUpdate/Update is called every frame
    void FixedUpdate()

    {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) 
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -4f) 
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
