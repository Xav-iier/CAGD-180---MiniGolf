using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Joshua Holdenried
 * This script allows the player to change the color of their golf ball
 * First Updated: 5/6/25
 * Last Updated: 5/6/25
 */

public class ColorChanger : MonoBehaviour
{
    public GameObject golfball; 
    public Color ColorPink;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void ChangeMaterialColor()
    {
        if (golfball != null)
        {
            Renderer targetRenderer = golfball.GetComponent<Renderer>();

            if (targetRenderer != null && targetRenderer.material != null)
            {
                targetRenderer.material.color = ColorPink;
            }
            else
            {
               print("Can Not Change Color");
            }
        }
       
    }
    public void Pink()
    {
        gameObject.GetComponent<Renderer>().material.color = ColorPink;
    }
}
