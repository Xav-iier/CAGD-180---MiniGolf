using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Xavier Poston
 * This script allows the golf ball to move around
 * First Updated: 4/23/25
 * Last Updated: 4/23/25
 */

public class BallController : MonoBehaviour
{
    public GameObject golfBall;
    public float speed = 5f;
 
    public float killHeight = -5;
    private Rigidbody rigidbody;
    private Vector3 respawnPoint;
    private Vector3 lastShotPosition; // Store the position where the ball was last shot from
    public GameManger gameManager;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        respawnPoint = transform.position;
        lastShotPosition = transform.position; // lastShotPosition to starting position

    }
    void FixedUpdate()
    {
        // Move();
        // Check if the ball falls below the kill height
        if (transform.position.y < killHeight)
        {
            KillPlayer();
        }
    }
    
   



      public void KillPlayer()
    {
        //  Count this as a penalty stroke (or two, if you prefer) 
        if (gameManager != null)
            gameManager.AddStroke();// +1 hit every time the ball is ‘killed’

        // 2  Reset the ball’s physics so it doesn’t roll away immediately 
        if (rigidbody != null)
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }

        // 3️⃣  Respawn at the last shot position
        transform.position = lastShotPosition;
    }

}



