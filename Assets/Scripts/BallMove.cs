using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb.AddForce(10, 0, 0, ForceMode.Impulse);
    }

    void Update()
    {
        
    }
}
