using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


/* Xavier Poston
 * This script allows the camera to follow the golf ball 
 * First Updated: 4/23/25
 * Last Updated: 4/29/25
 */

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float followSpeed = 5f;
    public float rotateSpeed = 5f;
    public bool followRotation = true;

    // Separate offsets for club and ball
    public Vector3 clubOffset = new Vector3(0, 1, -6); // Made Z negative to position behind
    public Vector3 ballOffset = new Vector3(0, 5, -8);

    private Vector3 currentOffset;
    private Vector3 lastTargetForward;

    private void Start()
    {
        if (target != null)
        {
            lastTargetForward = target.forward;
        }
    }

    void LateUpdate()
    {
        if (target == null) return;

        // Update which offset to use
        currentOffset = followRotation ? clubOffset : ballOffset;

        Vector3 desiredPosition;

        if (followRotation)
        {
            // Store the last known forward direction when following the club
            lastTargetForward = target.forward;

            // Calculate position behind the target based on its rotation
            desiredPosition = target.position
                            - target.forward * Mathf.Abs(currentOffset.z) // Always position behind
                            + Vector3.up * currentOffset.y;

            // Look at the direction the club is facing
            Quaternion targetRot = Quaternion.LookRotation(target.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotateSpeed * Time.deltaTime);
        }
        else
        {
            // When following the ball, use the ball's position but maintain camera orientation
            desiredPosition = target.position
                            - lastTargetForward * Mathf.Abs(currentOffset.z) // Use stored forward direction
                            + Vector3.up * currentOffset.y;

            // When following the ball, look at the ball
            Vector3 dirToTarget = (target.position - transform.position).normalized;
            if (dirToTarget != Vector3.zero)
            {
                Quaternion lookRot = Quaternion.LookRotation(dirToTarget);
                transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, rotateSpeed * Time.deltaTime);
            }
        }

        // Smoothly move to desired position
        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;

        // When changing targets, we want to ensure smooth transitions
        if (target != null && !followRotation)
        {
            // When switching to the ball, store the current forward direction
            lastTargetForward = transform.forward;
        }
    }

    // Call this when switching to the club to realign the camera
    public void SnapBehindTarget(float distanceBack = 6, float height = 1)
    {
        if (target == null) return;

        // Calculate the position directly behind the target
        Vector3 newPosition = target.position
                            - target.forward * distanceBack
                            + Vector3.up * height;

        // Immediately move the camera to this position
        transform.position = newPosition;

        // Look in the direction the target is facing
        transform.rotation = Quaternion.LookRotation(target.forward);

        // Update the stored forward direction
        lastTargetForward = target.forward;
    }
}
