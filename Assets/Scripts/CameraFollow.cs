using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


/* Xavier Poston
 * This script allows the camera to follow the golf ball 
 * First Updated: 4/23/25
 * Last Updated: 4/23/25
 */

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float Speed = 5f;
    public Vector3 offset;
     public bool followRotation = true;

    void LateUpdate()
    {
        if (target != null)
        {
            // Move the camera to follow target position and the offset
            Vector3 desiredPosition = target.position + target.rotation * offset;
            Vector3 betterPosition = Vector3.Lerp(transform.position, desiredPosition, Speed * Time.deltaTime);
            transform.position = betterPosition;

            // Rotate with the target
            if (followRotation)
            {
                Quaternion desiredRotation = Quaternion.LookRotation(target.forward);
                transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, Speed * Time.deltaTime);
            }
        }
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}





