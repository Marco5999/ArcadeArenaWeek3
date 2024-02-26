using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalLevel : MonoBehaviour
{
    public string sceneToLoad; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        // Load the scene with the specified name
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
    }
}
