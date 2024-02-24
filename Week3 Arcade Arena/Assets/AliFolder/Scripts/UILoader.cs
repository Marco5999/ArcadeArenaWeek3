using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UILoader : MonoBehaviour
{
    public GameObject uiPrompt; // Reference to the UI element displaying the prompt
    public string sceneToLoad; // Name of the scene to load when E is pressed

    private bool canEnterPortal = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiPrompt.SetActive(true); // Activate the UI prompt
            canEnterPortal = true; // Set flag to indicate that the player can enter the portal
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiPrompt.SetActive(false); // Deactivate the UI prompt
            canEnterPortal = false; // Reset the flag
        }
    }

    void Update()
    {
        if (canEnterPortal && Input.GetKeyDown(KeyCode.E))
        {
            // Load the desired scene when E is pressed
            LoadScene();
        }
    }

    void LoadScene()
    {
        // Load the scene with the specified name
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
    }
}
