using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject golfBall;
    public float speed = 5f;
    public int lives;
    public float killHeight = -5;
    private Rigidbody rigidbody;
    private Vector3 respawnPoint;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();


    }
    void FixedUpdate()
    {
        Move();
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
}
