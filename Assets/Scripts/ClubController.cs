using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            AnimateClubBack();
        }

        // Release Space to swing
        if (Input.GetKeyUp(KeyCode.Space) && isCharging)
        {
            Swing();
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
            camFollow.SetTarget(ballTransform);
        }

       
        // Animate club back to default
        StartCoroutine(ResetSwingAnimation());

        isCharging = false;
        powerCharge = 0f;
        UpdatePowerUI();
       
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
    // NEW: Waits for the ball to stop moving, then resets
    IEnumerator WaitForBallToStop()
    {
        yield return new WaitForSeconds(0.5f); // small delay before checking

        while (ballRb.velocity.magnitude > 0.05f)
        {
            yield return null;
        }

        // Ball has stopped — move club to ball position
        clubTransform.position = ballTransform.position;

        // NEW: Reset ball physics
        ballRb.isKinematic = true;
        ballRb.velocity = Vector3.zero;

        // NEW: Switch camera back to club
        if (camFollow != null)
        {
            camFollow.SetTarget(clubTransform);

        }
    }
    bool BallIsStationary()
    {
        return ballRb.velocity.magnitude < 0.05f;
    }

}

