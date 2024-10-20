using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//appliying forces to rigid bodies

public class initialScript : MonoBehaviour
{
    public Rigidbody rb;  
    public float forceAmount = 10f;  

    void Start()
    {
        
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }

    void Update()
    {
        
        rb.AddForce(Vector3.forward * forceAmount);
    }
}


