using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Joshua Holdenried
 * This script allows the fan motor to rotate, showing that the fan has motion 
 * First Updated: 5/1/25
 * Last Updated: 5/1/25
 */

public class FanDisplay : MonoBehaviour
{
    public float rotationSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the fan motor each frame
        transform.Rotate(0, rotationSpeed, 0);
    }
}
