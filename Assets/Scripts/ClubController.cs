using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;
using UnityEngine.UI;

/* Xavier Poston & Joshua Holdenried
 * This script allows the club to move around, when hitting the golf ball
 * First Updated: 4/23/25
 * Last Updated: 4/23/25
 */

public class ClubController : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public Transform club;
    public Transform clubPivot; // The pivot used to rotate the club visually
    public Rigidbody ballRb;

    public float maxPower = 20f;
    public float chargeSpeed = 10f;

    private float powerCharge = 0f;
    private bool isCharging = false;


    public CameraFollow camFollow;
    public Transform ballTransform;
    public Transform clubTransform;

    // Swing animation
    public float maxSwingBackAngle = 60f; // Maximum angle the club swings back

    // UI Element
    public Slider powerSlider;
    private void Start()
    {
        if (ballRb != null)
        {
            ballRb.isKinematic = true; // Freeze the ball at the start
        }
    }
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(ballRb.position, Vector3.up, rotationSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(ballRb.position, Vector3.down, rotationSpeed);
        }

        // Start charging on Space key down
        if (Input.GetKeyDown(KeyCode.Space) && BallIsStationary())
        {
            isCharging = true;
            powerCharge = 0f;
        }

        // While holding Space, increase powerCharge
        if (Input.GetKey(KeyCode.Space) && isCharging)
        {
            powerCharge += chargeSpeed * Time.deltaTime;
            powerCharge = Mathf.Clamp(powerCharge, 0f, maxPower);
            UpdatePowerUI();
<<<<<<< Updated upstream
            //AnimateClubBack();
=======
          
>>>>>>> Stashed changes
        }

        // Release Space to swing
        if (Input.GetKeyUp(KeyCode.Space) && isCharging)
        {
            Swing();
            AnimateClubBack();
        }
    }

    void Swing()
    {
        if (ballRb != null)
        {
            ballRb.isKinematic = false;
            Vector3 swingDirection = club.forward;
            ballRb.AddForce(swingDirection * powerCharge, ForceMode.Impulse);
        }
       
        if (camFollow != null)
        {
            camFollow.followRotation = false;
            camFollow.SetTarget(ballTransform);
        }

       
        // Animate club back to default
      //  StartCoroutine(ResetSwingAnimation());

        isCharging = false;
        powerCharge = 0f;
        UpdatePowerUI();

        //StartCoroutine(StopBall());

        // Start checking when ball stops
        StartCoroutine(WaitForBallToStop());
    }
    void AnimateClubBack()
    {
        if (clubPivot == null) return;

        float percent = powerCharge / maxPower;
        float targetAngle = Mathf.Lerp(0f, maxSwingBackAngle, percent);  // negative = back swing
        clubPivot.localRotation = Quaternion.Euler(targetAngle, 0f, 0f);
    }

    IEnumerator ResetSwingAnimation()
    {
        if (clubPivot == null) yield break;

        float duration = 0.1f;
        float elapsed = 0f;
        Quaternion startRot = clubPivot.localRotation;
        Quaternion endRot = Quaternion.identity;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            clubPivot.localRotation = Quaternion.Slerp(startRot, endRot, elapsed / duration);
            yield return null;
        }

        clubPivot.localRotation = endRot;
    }

    void UpdatePowerUI()
    {
        if (powerSlider != null)
        {
            powerSlider.value = powerCharge / maxPower;
        }
    }
    // Waits for the ball to stop moving, then resets
    IEnumerator WaitForBallToStop()
    {
        yield return new WaitForSeconds(0.5f); // small delay before checking

        while (ballRb.velocity.magnitude > 0.05f)
        {
            yield return null;
        }

      
        // Get the direction the club was last facing (used to determine back offset)
        Vector3 backDirection = -transform.forward;

        // Offset the club slightly behind the ball
        float clubOffsetDistance = 1f; //(1f = 1 meter back)
        Vector3 offsetPosition = ballTransform.position + backDirection * clubOffsetDistance;

        clubTransform.position = offsetPosition;

        //  Reset ball physics
        ballRb.isKinematic = true;
        ballRb.velocity = Vector3.zero;

        // Switch camera back to club
        if (camFollow != null)
        {
            camFollow.SetTarget(clubTransform);

        }
    }

    private IEnumerator StopBall()
    {
        // Start the timer to wait
        print("Timer Started");
        yield return new WaitForSeconds(5);
        print("Timer Ended");
        ballRb.velocity = Vector3.zero;
    }

    bool BallIsStationary()
    {
        return ballRb.velocity.magnitude < 0.05f;
    }

}

