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
    public int lives;
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
            LoseLife();
        }
    }
    private void Move()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.MovePosition(transform.position + (Vector3.left * speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.MovePosition(transform.position + (Vector3.right * speed * Time.deltaTime));
        }
       
    }
    public void LoseLife()
    {
        // Reduce's players lives by 1
        lives--;
        gameManager.LoseLife();

        // Check if lives > 0 
        if (lives > 0)
        {
            // Respawn at the last shot position instead of the original respawn point
            transform.position = lastShotPosition;

            // Reset the ball's velocity to stop any movement
            if (rigidbody != null)
            {
                rigidbody.velocity = Vector3.zero;
                rigidbody.angularVelocity = Vector3.zero;
            }
            // Respawn - Sets the player's position, to the position of the respawn point
            transform.position = respawnPoint;
        }
        else
        {
            // Game Over
            print("Game Over");
            SceneManager.LoadScene(5);
        }

    }

}

