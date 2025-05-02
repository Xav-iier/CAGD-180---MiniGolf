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

    public Vector3 clubOffset = new Vector3(0, 1, 6);
    public Vector3 ballOffset = new Vector3(0, 5, -8);

    private Vector3 currentOffset;

    void LateUpdate()
    {
        if (target == null) return;

        currentOffset = followRotation ? clubOffset : ballOffset;

        Vector3 desiredPosition;

        if (followRotation)
        {
            desiredPosition = target.position + target.rotation * currentOffset;
        }
        else
        {
            desiredPosition = target.position + currentOffset;
        }

        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

        if (followRotation)
        {
            Quaternion targetRot = Quaternion.LookRotation(target.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotateSpeed * Time.deltaTime);
        }
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    // Call this when switching to the club to realign the camera
    public void SnapBehindTarget(float distanceBack = 6, float height = 1)
    {
        if (target == null) return;

        Vector3 backOffset = -target.forward * distanceBack + Vector3.up * height;
        clubOffset = Quaternion.Inverse(target.rotation) * backOffset;
    }
}






