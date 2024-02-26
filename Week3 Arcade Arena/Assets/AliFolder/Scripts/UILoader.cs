using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UILoader : MonoBehaviour
{
    public GameObject uiPrompt; 
    public string sceneToLoad; 

    private bool canEnterPortal = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiPrompt.SetActive(true); 
            canEnterPortal = true; 
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiPrompt.SetActive(false); 
            canEnterPortal = false; 
        }
    }

    void Update()
    {
        if (canEnterPortal && Input.GetKeyDown(KeyCode.E))
        {
            
            LoadScene();
        }
    }

    void LoadScene()
    {
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
    }
}
