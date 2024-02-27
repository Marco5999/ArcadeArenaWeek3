using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderInGame : MonoBehaviour
{
    
    public string sceneToLoad;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           LoadScene();
        }
    }

    void LoadScene()
    {
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
    }
}
