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
    public Color ColorRed;
    public Color ColorOrange;
    public Color ColorYellow;
    public Color ColorGreen;
    public Color ColorBlue;
    public Color ColorPurple;
    public Color ColorPink;
    public Color ColorWhite;
    public Color ColorGray;
    public Color ColorBlack;
    public bool red = false;
    public bool orange = false;
    public bool yellow = false;
    public bool green = false;
    public bool blue = false;
    public bool purple = false;
    public bool pink = false;
    public bool white = false;
    public bool gray = false;
    public bool black = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void Red()
    {
        if (golfball != null)
        {
            Renderer targetRenderer = golfball.GetComponent<Renderer>();

            if (targetRenderer != null && targetRenderer.material != null)
            {
                targetRenderer.material.color = ColorRed;
                red = true;
            }
            else
            {
                print("Can Not Change Color");
            }
        }
    }
    public void Orange()
    {
        if (golfball != null)
        {
            Renderer targetRenderer = golfball.GetComponent<Renderer>();

            if (targetRenderer != null && targetRenderer.material != null)
            {
                targetRenderer.material.color = ColorOrange;
                orange = true;
            }
            else
            {
                print("Can Not Change Color");
            }
        }
    }
    public void Yellow()
    {
        if (golfball != null)
        {
            Renderer targetRenderer = golfball.GetComponent<Renderer>();

            if (targetRenderer != null && targetRenderer.material != null)
            {
                targetRenderer.material.color = ColorYellow;
                yellow = true;
            }
            else
            {
                print("Can Not Change Color");
            }
        }
    }
     public void Green()
    {
        if (golfball != null)
        {
            Renderer targetRenderer = golfball.GetComponent<Renderer>();

            if (targetRenderer != null && targetRenderer.material != null)
            {
                targetRenderer.material.color = ColorGreen;
                green = true;
            }
            else
            {
                print("Can Not Change Color");
            }
        }
    }
    public void Blue()
    {
        if (golfball != null)
        {
            Renderer targetRenderer = golfball.GetComponent<Renderer>();

            if (targetRenderer != null && targetRenderer.material != null)
            {
                targetRenderer.material.color = ColorBlue;
                blue = true;
            }
            else
            {
                print("Can Not Change Color");
            }
        }
    }
    public void Purple()
    {
        if (golfball != null)
        {
            Renderer targetRenderer = golfball.GetComponent<Renderer>();

            if (targetRenderer != null && targetRenderer.material != null)
            {
                targetRenderer.material.color = ColorPurple;
                purple = true;
            }
            else
            {
                print("Can Not Change Color");
            }
        }
    }
    public void Pink()
    {
        if (golfball != null)
        {
            Renderer targetRenderer = golfball.GetComponent<Renderer>();

            if (targetRenderer != null && targetRenderer.material != null)
            {
                targetRenderer.material.color = ColorPink;
                pink = true;
            }
            else
            {
                print("Can Not Change Color");
            }
        }
    }
    public void White()
    {
        if (golfball != null)
        {
            Renderer targetRenderer = golfball.GetComponent<Renderer>();

            if (targetRenderer != null && targetRenderer.material != null)
            {
                targetRenderer.material.color = ColorWhite;
                white = true;
            }
            else
            {
                print("Can Not Change Color");
            }
        }
    }
    public void Gray()
    {
        if (golfball != null)
        {
            Renderer targetRenderer = golfball.GetComponent<Renderer>();

            if (targetRenderer != null && targetRenderer.material != null)
            {
                targetRenderer.material.color = ColorGray;
                gray = true;
            }
            else
            {
                print("Can Not Change Color");
            }
        }
    }
    public void Black()
    {
        if (golfball != null)
        {
            Renderer targetRenderer = golfball.GetComponent<Renderer>();

            if (targetRenderer != null && targetRenderer.material != null)
            {
                targetRenderer.material.color = ColorBlack;
                black = true;
            }
            else
            {
                print("Can Not Change Color");
            }
        }
    }

}
