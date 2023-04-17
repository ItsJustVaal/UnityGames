using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{   
    [SerializeField] float delayTime = .5f;
    [SerializeField] ParticleSystem crashEffect;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            Invoke(methodName: "ReloadScene",time: delayTime);
        }    
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
}
