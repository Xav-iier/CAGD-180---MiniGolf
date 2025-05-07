using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimgWall : MonoBehaviour
{
  
  private float moveSpeed = 2;
  private float maxDistance = 50;
    private float resetDelay = 5;
    private string targetTag = "Ball";

    private Vector3 startPosition;
    private bool isMoving = true;
    private bool isWaiting = false;

    private void Start()
    {
        // Store the initial position for resetting
        startPosition = transform.position;
    }

    private void Update()
    {
        if (isMoving && !isWaiting) //bool
        {
            // Move the wall along the X-axis
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

            // Check if the wall has reached the maximum distance
            if (transform.position.x >= startPosition.x + maxDistance)
            {
                isMoving = false;
                StartCoroutine(ResetAfterDelay());
            }
        }
    }

    private IEnumerator ResetAfterDelay()
    {
        isWaiting = true;

        // Wait for the delay time
        yield return new WaitForSeconds(resetDelay);

        // Reset the wall position
        transform.position = startPosition;

        isWaiting = false;
        isMoving = true;
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the target tag
        if (collision.gameObject.CompareTag(targetTag))
        {
            // Instead of destroying the ball, call the LoseLife method
            BallController ballController = collision.gameObject.GetComponent<BallController>();
            if (ballController != null)
            {
                ballController.KillPlayer();
            }
        }
    }
}

