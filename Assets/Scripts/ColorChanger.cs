using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
    public void MainMenu(int sceneIndex)
    {
        SceneManager.LoadScene(1);
    }
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Ball");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
       if(red = true)
        {
            orange = false;
            yellow = false;
            green = false;
            blue = false;
            purple = false;
            pink = false;
            white = false;
            gray = false;
            black = false;
        }
        if (orange = true)
        {
            red = false;
            yellow = false;
            green = false;
            blue = false;
            purple = false;
            pink = false;
            white = false;
            gray = false;
            black = false;
        }
        if (yellow = true)
        {
            red = false;
            orange = false;
            green = false;
            blue = false;
            purple = false;
            pink = false;
            white = false;
            gray = false;
            black = false;
        }
        if (green = true)
        {
            red = false;
            orange = false;
            yellow = false;
            blue = false;
            purple = false;
            pink = false;
            white = false;
            gray = false;
            black = false;
        }
        if (blue = true)
        {
            red = false;
            orange = false;
            yellow = false;
            green = false;
            purple = false;
            pink = false;
            white = false;
            gray = false;
            black = false;
        }
        if (purple = true)
        {
            red = false;
            orange = false;
            yellow = false;
            green = false;
            blue = false;
            pink = false;
            white = false;
            gray = false;
            black = false;
        }
        if (pink = true)
        {
            red = false;
            orange = false;
            yellow = false;
            green = false;
            blue = false;
            purple = false;
            white = false;
            gray = false;
            black = false;
        }
        if (white = true)
        {
            red = false;
            orange = false;
            yellow = false;
            green = false;
            blue = false;
            purple = false;
            pink = false;
            gray = false;
            black = false;
        }
        if (gray = true)
        {
            red = false;
            orange = false;
            yellow = false;
            green = false;
            blue = false;
            purple = false;
            pink = false;
            white = false;
            black = false;
        }
        if (black = true)
        {
            red = false;
            orange = false;
            yellow = false;
            green = false;
            blue = false;
            purple = false;
            pink = false;
            white = false;
            gray = false;
        }

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
