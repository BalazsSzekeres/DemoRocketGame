using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BodyCollision : MonoBehaviour
{
    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Friendly collision");
                break;

            case "Finish":
                LoadNextLevel();
                break;

            case "Fuel":
                Debug.Log("Friendly collision");
                break;

            default:
                ReloadLevel();
                break;
        }

    } 

    private void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Crash! Reloading Scene...");
        SceneManager.LoadScene(currentSceneIndex);
    }

    private void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex != SceneManager.sceneCountInBuildSettings - 1)
        {
            Debug.Log($"Success! Loading Next Scene ID {currentSceneIndex + 1}...");
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            Debug.Log("Finished last scene, reloading first one...");
            SceneManager.LoadScene(0);
        }
    }

}
