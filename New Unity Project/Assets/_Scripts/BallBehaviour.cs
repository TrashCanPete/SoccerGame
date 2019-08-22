using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private Rigidbody rb;
    public float ballThrust;

   



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent < Rigidbody>();
        Invoke("BallMovement", 2);
    }

    void BallMovement()
    {       
          rb.AddForce(transform.forward * ballThrust, ForceMode.Acceleration);
    }


  }
