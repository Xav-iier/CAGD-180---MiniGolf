using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FanController : MonoBehaviour
{

    public Rigidbody ballRb;
    public float FanSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (ballRb)
        {
            ballRb.AddForce(Vector3.up * FanSpeed);
        }
    }

}
