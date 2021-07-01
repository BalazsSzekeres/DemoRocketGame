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
                Debug.Log("Friendly collision");
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
        SceneManager.LoadScene(currentSceneIndex);
    }

    

}
