using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //check if the player collided with this hazard
        if (collision.gameObject.GetComponent<BallController>())
        {
            collision.gameObject.GetComponent<BallController>().KillPlayer();
        }
    }

    // Checks if the player collided with a hazardous object
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<BallController>())
        {
            other.gameObject.GetComponent < BallController>().KillPlayer();
        }
    }

}
