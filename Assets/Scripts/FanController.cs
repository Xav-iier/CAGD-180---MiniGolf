using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/* Joshua Holdenried
 * This script allows the golf ball to be shot in any direction by the fan
 * First Updated: 4/29/25
 * Last Updated: 4/29/25
 */

public class FanController : MonoBehaviour
{

    public Rigidbody ballRb;
    public float FanSpeed;
    public bool up = false;
    public bool down = false;
    public bool left = false;
    public bool right = false;

    void OnTriggerStay(Collider other)
    {

        if (up is true)
        {
            if (ballRb)
            {
                ballRb.AddForce(Vector3.up * FanSpeed);
            }
        }

        if (down is true)
        {
            if (ballRb)
            {
                ballRb.AddForce(Vector3.down * FanSpeed);
            }
        }

        if (left is true)
        {
            if (ballRb)
            {
                ballRb.AddForce(Vector3.left * FanSpeed);
            }
        }

        if (right is true)
        {
            if (ballRb)
            {
                ballRb.AddForce(Vector3.right * FanSpeed);
            }
        }
    }



}
