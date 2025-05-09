using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.SceneManagement;


/* Joshua Holdenried
 * This script allows the player to change the color of their golf ball
 * First Updated: 5/6/25
 * Last Updated: 5/9/25
 */

public enum BallColor
{
    red,
    orange,
    yellow,
    green,
    blue,
    purple,
    pink,
    white,
    gray,
    black
}

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

    public BallColor ballColor;
    public Transform GolfBallLocation;



    public void MainMenu(int sceneIndex)
    {
        SceneManager.LoadScene(1);
    }
    void Awake()
    {
       /*
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Ball");
       
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        transform.position = GolfBallLocation.position;
       */
        DontDestroyOnLoad(this.gameObject);
    }

      private void Start()
    {
        /*
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = ballColor;
        }
        */

        switch (ballColor)
        {
            case BallColor.red:
                Red();
                break;
            case BallColor.orange:
                Orange();
                break;
            case BallColor.yellow:
                Yellow();
                break;
            case BallColor.green:
                Green();
                break;
            case BallColor.blue:
                Blue();
                break;
            case BallColor.purple:
                Purple();
                break;
            case BallColor.pink:
                Pink();
                break;
            case BallColor.white:
                White();
                break;
            case BallColor.gray:
                Gray();
                break;
            case BallColor.black:
                Black();
                break;
            default:
                //do code if enum is not any of the above cases
                break;
        }
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
            }
            else
            {
                print("Can Not Change Color");
            }
        }
    }

}
