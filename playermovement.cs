using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
    }

    void FixedUpdate()
    {
        rb.AddForce(0,0,600 * Time.deltaTime);

        if (Input.GetKey("a")){
            rb.AddForce(-1000*Time.deltaTime,0,0);
        }
        if (Input.GetKey("d")){
            rb.AddForce(1000*Time.deltaTime,0,0);
        }
    }
}
