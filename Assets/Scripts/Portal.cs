using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform teleportPoint;   // where the ball should appear

    private void OnTriggerEnter(Collider other)
    {
        // send anything that enters straight to the teleport point
        other.transform.position = teleportPoint.position;
    }
}
