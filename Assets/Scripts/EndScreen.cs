using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu(int sceneIndex)
    {
        SceneManager.LoadScene(1);
    }
    public void Again(int sceneIndex)
    {
        SceneManager.LoadScene(0);
    }
    public void LevelSelect(int sceneIndex)
    {
        SceneManager.LoadScene(2);
    }
    public void Grass(int sceneIndex)
    {
        SceneManager.LoadScene(3);
    }
    public void Desert(int sceneIndex)
    {
        SceneManager.LoadScene(4);
    }
    public void School(int sceneIndex)
    {
        SceneManager.LoadScene(5);
    }

}
