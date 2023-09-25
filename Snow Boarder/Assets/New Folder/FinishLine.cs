using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float fltLoadDelay = 1f;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            
            Invoke("ReloadScene", fltLoadDelay);
        }
        
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
