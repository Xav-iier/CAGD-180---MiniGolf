using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hole : MonoBehaviour
{
    public string nextSceneName = "Level2"; // Set this in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball")) 
        {
            SceneManager.LoadScene(nextSceneName);
        }
        if (other.CompareTag("Ball"))
        {
            StartCoroutine(LoadNextSceneAfterDelay(1f));
        }
    }
  

    IEnumerator LoadNextSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(nextSceneName);
    }
}

