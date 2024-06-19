using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenLoop : MonoBehaviour
{
    // Reset Game States
    void Awake(){
        GameManager.instance.dog = false;
        GameManager.instance.duck = false;
        GameManager.instance.cow = false;
        GameManager.instance.goat = false;
        GameManager.instance.pig = false;
        GameManager.instance.number = 0;
        GameManager.instance.spawnNumber = 1;
    }

    void Update(){
        // Touch Screen controls
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){   
            SceneManager.LoadScene(1);
        }

        // Mouse Click controls (for testing)
        if (Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene(1);
        }
    }
}
